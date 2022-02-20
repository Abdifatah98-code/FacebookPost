 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using System.Threading.Tasks;

namespace FacebookPost
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime  date { get; set; }
        // (Comment) its clsaa name and i use as dataType
        public Comment? comments { get; set; }

        // (Likes) its clsaa name and i use as dataType
        public Likes? likes { get; set; } 




        List<Post> posts = new List<Post>();


        public void createPost()
        {
            //(comments) its property that declered in the above and use as DataType
       
            comments = new Comment();
          //Id , User , comment =>Are all properties in The Comment class
            comments.Id =1;
            comments.User= "jamaal";
            comments.cumment = "Oh This Great";

            likes = new Likes();
            likes.Like ??=new List<bool>();
            likes.Like .Add(true);
            likes.Like.Add(true);

            posts.Add(new Post() { Id = 1, Title = "Post One", date = DateTime.Now ,comments=comments, likes=likes});
            posts.Add(new Post() { Id = 2, Title = "Post Two", date = DateTime.Now });
            posts.Add(new Post() { Id = 3, Title = "Post Three", date = DateTime.Now });
           
        }

        public void listPost()
        {
            foreach (var post in posts)
            {
                // This if statment Mean some Posts May be  doesn't have comments  
               
               if(post.likes != null && post.comments != null)
                {
                    Console.WriteLine($" : {post.Id} \n {post.Title} \n {post.date} \t :{post.comments.cumment} :=> Likes :{post.likes.Like.Count}");
                }
                else if (post.comments != null)
                {
                    Console.WriteLine($" : {post.Id} \n {post.Title} \n {post.date} :{post.comments.cumment}");

                }
                else if (post.likes != null)
                {

                    Console.WriteLine($" : {post.Id} \n {post.Title} \n {post.date}  :=> Likes :{post.likes.Like.Count}");
                }

                else
                {
                  
                    Console.WriteLine($" : {post.Id} \n {post.Title} \n {post.date} ");
     
                }

            }
           
            
        }

    }
}












//comments = new Comment();
//comments.Id ??= new List<int>();
//comments.Id.Add(1);
//comments.User ??= new List<string>();
//comments.User.Add("jamaal");
////comments.cumment ??= new List<string>();
//comments.cumment = "Oh This Great";

