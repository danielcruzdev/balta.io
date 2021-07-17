using Blog.Models;
using Blog.Repositories;
using Microsoft.Data.SqlClient;
using System;

namespace Blog
{
    public class Program
    {
        private const string CONNECTION_STRING = "Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$";

        static void Main(string[] args)
        {
            using var connection = new SqlConnection(CONNECTION_STRING);
            var categoryRepository = new Repository<Category>(connection);
            var tagRepository = new Repository<Tag>(connection);
            var postRepository = new Repository<Post>(connection);
            var postTagRepository = new Repository<PostTag>(connection);


            var category = new Category()
            {
                Name = "Categoria - Desafio2",
                Slug = "categoria-desafio2"
            };

            var tag = new Tag()
            {
                Name = "Tag - desafio2",
                Slug = "tag-desafio2"
            };

            var post = new Post()
            {
                AuthorId = 1,
                CategoryId = 1,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                Body = "Body - desafio - post2",
                Slug = "desafio-post2",
                Summary = "sumarry - post2",
                Title = "post desafio2",
            };

            CreateCategory(categoryRepository, category);
            var tagId = CreateTag(tagRepository, tag);
            var postId = CreatePost(postRepository, post);

            var postTag = new PostTag()
            {
                PostId = (int)postId,
                TagId = (int)tagId
            };

            LinkPostToTag(postTagRepository, postTag);
        }

        private static long CreateCategory(Repository<Category> repository, Category category)
        {
            return repository.Create(category);
        }

        private static long CreateTag(Repository<Tag> repository, Tag tag)
        {
            return repository.Create(tag);
        }

        private static long CreatePost(Repository<Post> repository, Post post)
        {
            return repository.Create(post);
        }

        private static long LinkPostToTag(Repository<PostTag> repository, PostTag postTag)
        {
            return repository.Create(postTag);
        }
    }
}
