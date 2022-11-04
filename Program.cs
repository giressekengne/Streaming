using Streaming;
using System;

namespace Streaming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            AppMusique app1 = new AppMusique("spotify");
        }
    }

    public  abstract class StreamingPlatform : Iplayer
    {
        protected String appName;

        void Iplayer.Backward()
        {
            throw new NotImplementedException();
        }

        void Iplayer.Forward()
        {
            throw new NotImplementedException();
        }

        void Iplayer.Play()
        {
            throw new NotImplementedException();
        }

        void Iplayer.Rate()
        {
            throw new NotImplementedException();
        }

        void Iplayer.Stop()
        {
            throw new NotImplementedException();
        }

        protected class Song
        {
            public String title;
            public String Autore;
            public String description;
            public bool stato;
            
           
            // costruttore
            public Song(string title,String autore)
            {
                this.Title = title;
            }
            public string Title { get => title; set => title = value; }

            public string Rate(String description)
            {
                return description;
            }

            public bool Stato(bool stato)
            {
                return stato;
            }


        }
    }


    public class AppMusique: StreamingPlatform
    {
        private Song[] songs;

        public AppMusique(String appName)
        {
            songs = new Song[10];
            songs[0] = new Song("free from disire","gala");
            songs[0] = new Song("fuori di testa","Maniskin");
            songs[0] = new Song("bala","Alessandro");
            songs[0] = new Song("heal the word","Micheal jackson");
            songs[0] = new Song("in assenza di te","Laura pausini");
            songs[0] = new Song("non c'è","Laura pausini");
            songs[0] = new Song("arrivi tu","allessandra amoroso");
            songs[0] = new Song("jalou","dajou");
            songs[0] = new Song("luna tu","andrea boceli");
            songs[0] = new Song("j'me tire","maite gims");

        }


    }



    public interface Iplayer
    {
        protected void Play();
        protected void Stop();
        protected void Rate();
        protected void Forward();
        protected void Backward();
    }

}


