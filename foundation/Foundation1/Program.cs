using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Video video1= new Video("hola mundo", "Dalinda" ,50);
        Comment commenta1 = new Comment("Dali", "muy buen video");
        Comment commenta2 = new Comment("Eric", "fue muy grato ver este video");
        Comment commenta3 = new Comment("Luke", "great video");
        video1.AddComment(commenta1);
        video1.AddComment(commenta2);
        video1.AddComment(commenta3);
        
        Video video2= new Video("table", "Marc" ,60);
        Comment commentb1 = new Comment("Minelia", "great information");
        Comment commentb2 = new Comment("Jane", "please send me the link");
        Comment commentb3 = new Comment("Alexander", "love it");
        Comment commentb4 = new Comment("Nicole", "i think this info is wrong");
        video2.AddComment(commentb1);
        video2.AddComment(commentb2);
        video2.AddComment(commentb3);
        video2.AddComment(commentb4);
        
        Video video3= new Video("casa", "Ade" ,80);
        Comment commentc1 = new Comment("Enriqueta", "love it");
        Comment commentc2 = new Comment("Maria", "I did not realize I needed this video until I watched it!");
        Comment commentc3 = new Comment("Frank", "The hard work you put into this video really shows");
        Comment commentc4 = new Comment("Carol", "good");
        video3.AddComment(commentc1);
        video3.AddComment(commentc2);
        video3.AddComment(commentc3);
        video3.AddComment(commentc4);
        
        List<Video> videos= new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (var v in videos)
        {
            v.Display();
        }
        







    }
}  