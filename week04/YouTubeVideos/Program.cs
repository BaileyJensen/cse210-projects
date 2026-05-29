using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("I spent 100 days in a cave!","Mr.Beast", 1800);
        Comment comment1 = new Comment("Iceice baby23", "Mr.beast!Give me the prize money");
        Comment comment2 = new Comment("Crazyinlove", "Marry me!!");
        Comment comment3 = new Comment("jimmylover", "Loved this video!");

        Video video2 = new Video("How to make ice cream","Gordon Ramsey", 300);
        Comment comment4 = new Comment("Icecream boi", "Is that organic?");
        Comment comment5 = new Comment("Billy788", "Does this go in the oven?");
        Comment comment6 = new Comment("Gordonlover145", "I could watch this all day");

        Video video3 = new Video("I got baptized!","52 Churches in 52 days", 2603);
        Comment comment7 = new Comment("Pasture75", "What do you like about that church anyways?");
        Comment comment8 = new Comment("Fred", "Love that church!");
        Comment comment9 = new Comment("sally2015", "inspiring!");
        Comment comment10 = new Comment("gally2020", "Similiar to my story");
        

        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);

        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);

        video3.AddComment(comment7);
        video3.AddComment(comment8);
        video3.AddComment(comment9);
        video3.AddComment(comment10);


        Console.WriteLine(video1.DisplayDetails());
        Console.WriteLine(comment1.DisplayComments());
        Console.WriteLine(comment2.DisplayComments());
        Console.WriteLine(comment3.DisplayComments());

        Console.WriteLine(video2.DisplayDetails());
        Console.WriteLine(comment4.DisplayComments());
        Console.WriteLine(comment5.DisplayComments());
        Console.WriteLine(comment6.DisplayComments());

        Console.WriteLine(video3.DisplayDetails());
        Console.WriteLine(comment7.DisplayComments());
        Console.WriteLine(comment8.DisplayComments());
        Console.WriteLine(comment9.DisplayComments());
        Console.WriteLine(comment10.DisplayComments());
    }
}