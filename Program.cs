using System;


namespace IPZ
{
    class Image { }
    class AI_Algorithm
    {

    }
    class RealTimeGenerator
    {

    }
    class QuerryExecutor
    {

    }
    class Account
    {
        String Name;
        int ID;
    }
    class Post
    {
        Account PostAuthor;
        Image[] Images;
        Comment [] Comments;
        String Description;
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
        void Scanning() { }
        void ARView() { }
        void PostView() { }
        void CreatePost() { }
        void CreateComment() { }
    }
    class CameraView
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
