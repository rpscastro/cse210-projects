using System;

class Program
{

    static List<Video> _videos;
    static void Main(string[] args)
    {
        //Video 1
        Video video1 = new Video("The Lord Commands Lehi's Family to Leave Jerusalem | 1 Nephi 1–2",
                                 "Book of Mormon: Another Testament of Jesus Christ",
                                 1101);

        //Comments Video 1
        Comment comment1V1 = new Comment("@RodIanBulong001",
                                         "I am an investigator I already read this chapter in the book of mormon. I’m so grateful that I found this video. Watching all the way from the Philippines 🇵🇭.");

        Comment comment2V1 = new Comment("@damilareidowu6363",
                                         "I'm a new convert and this video helped me to compliment books of Mormon I'm reading");

        Comment comment3V1 = new Comment("@natepage529",
                                         "I am grateful for how relevant the Book of Mormon is to the times we are living in.");

        Comment comment4V1 = new Comment("@Joan-ol9ho",
                                         "This is the beginning of something great. One day I’ll be watching this with my children");

        //Adding comments to video 1
        video1.AddComment(comment1V1);
        video1.AddComment(comment2V1);
        video1.AddComment(comment3V1);
        video1.AddComment(comment4V1);


        //Video 2
        Video video2 = new Video("Alma and Amulek Are Delivered by the Power of God",
                                 "Book of Mormon: Another Testament of Jesus Christ",
                                 1383);
        //Comments video 2
        Comment comment1V2 = new Comment("@PyrrhicPax",
                                         "as a former Anti-Christian myself for several years, the story of Alma the Younger really speaks to me. He is one of my favorite prophets.");

        Comment comment2V2 = new Comment("@00Fisher00",
                                         "This was powerful.  When Amulek stood up to speak, his action was simple, but it really struck me.");

        Comment comment3V2 = new Comment("@alichuntz3763",
                                         "These videos have the power to change hearts.  They have strengthened my love for the Book of Mormon");

        Comment comment4V2 = new Comment("@TedDorff",
                                         "I really like how Amulek was portrayed. Very powerful!");

        //Adding comments to video 2
        video2.AddComment(comment1V2);
        video2.AddComment(comment2V2);
        video2.AddComment(comment3V2);
        video2.AddComment(comment4V2);


        //Video 3
        Video video3 = new Video("Jesus Christ Introduces the Sacrament | 3 Nephi 18",
                                 "Book of Mormon: Another Testament of Jesus Christ",
                                 658);
        //Comments video 3
        Comment comment1V3 = new Comment("@hollyodii5969",
                                         "The Sacrament prayer is most beautiful in first person by the Savior! It goes straight into the soul.");

        Comment comment2V3 = new Comment("@robertopaulpickett4030",
                                         "Powerful representation of this sacred event.");

        Comment comment3V3 = new Comment("@AkselRevan",
                                         "Jesus Christ is my Savior!");

        Comment comment4V3 = new Comment("@mommybrown4",
                                         "Beautiful videos. Thank you for bringing the Book of Mormon to life.");

        //Adding comments to video 3
        video3.AddComment(comment1V3);
        video3.AddComment(comment2V3);
        video3.AddComment(comment3V3);
        video3.AddComment(comment4V3);


        _videos = new List<Video>();
        _videos.Add(video1);
        _videos.Add(video2);
        _videos.Add(video3);

        DisplayInfo();

    }


    static void DisplayInfo()
    {

        foreach (Video video in _videos)
        {

            video.DisplayInfo();
            Console.WriteLine();
            video.DisplayComments();

        }
    }
}