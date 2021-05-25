using System;


namespace IPZ
{
    class Image { }
    class Location { }
    class ArchitectureStyle { }
    class Building
    {
        String Name;
        String Description;
        Location Location;
        ArchitectureStyle ArchitectureStyle;
    }
    class Display { }
    class Data { }
    public class AI_Algorithm
    {
        Data data;
        public void DataAnalys() { }
    }
    public class RealTimeGenerator
    {
        public void GetStateByTime() { }
        public void GenerateRealTimeObject() { }
    }
    abstract class Account // абстрактный клас сделан что-бы каждый пользователь имел аккаунт , 
    // а уже потом мы присваеваем абстрактному акаунту один из вариантов (модер или стандарт)
    {
        String Name;
        int ID;
        Post[] MyPotsts;
        Post[] Saved;
        void AddPost(Post post) { }
        void SavePost(Post post) { }
    }
    class StandartAccount : Account { } 
    class ModerAccount : Account
    {
        void ApproveBuilding() { }
        void ApprovePost() { }
        void DeclineBuilding() { }
        void DeclinePost() { }
        void EditBuilding() { }
        void EditPost() { }
        void EditComment() { }
    }
    class Post
    {
        Account PostAuthor;
        Image[] Images;
        Comment [] Comments;
        String Description;
        void AddComment(Comment comment) { }
        void LoadComment(Comment comment) { }
    }
    class Comment
    {
        Account CommentAuthor;
        String message;
    }
    class User
    {
        Account account;
        void Regestration() { }
        void Scanning(CameraView camera) 
        {
            AI_Algorithm Alg = new AI_Algorithm();
            camera.MakePhoto();
            Alg.DataAnalys();
            camera.Display();
        }
        void ARView() 
        {
            CameraView camera = new CameraView();
            RealTimeGenerator ar = new RealTimeGenerator();
            ar.GenerateRealTimeObject();
            ar.GetStateByTime();
            camera.Display();
        }
        void CreatePost() { }
        void CreateComment(Post post) { }
        void AddBuilding(Data data) { }
    }
    class CameraView
    {
        public void Display() { }
        public void MakePhoto() { }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
