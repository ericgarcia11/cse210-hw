using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> video1 = new List<string>{
            "Sultans Of Swing - Live Alchemy - Dire Straits (Solo Cover + TAB) w/pick",
            "Guillaume Vrac",
            "14:03"
        };
        List<string> comments1 = new List<string>{
            "@alexoliva5648",
            "People transcribing and playing note-for-note Alchemy songs have my deepest respect. Amazing work!",
            "@GuillaumeVrac",
            "Disclaimer: of (very) course i know Mark Knopfler plays with his fingers, but that's my version and i play with a pick.",
            "@filipavbarbosa",
            "this is amazing, most people won't realize the time and effort it takes to make a video like this. PLUS, having the skills to play this song. incredible job, man",
            "@Sam-su4sk",
            "This is great, well done!."
        };

        List<string> video2 = new List<string>{
            "Foo Fighters. Walk.",
            "Foo Fighters",
            "5:58"
        };
        List<string> comments2 = new List<string>{
            "@silmarr",
            "Dave Grohl: learns to fly before learning to walk",
            "@hummus-ux9ct",
            "Rest in Peace Taylor. Foo Fighters won't be the same without you. Your genius work on the drums cannot be replaced.",
            "@rybread5718",
            "I love how he looks at the coldplay sticker and then shakes his head in disapproval.",
            "@slimchancestudios6886",
            "When Dave grohl smiles the whole world smiles",
            "@sifk6163",
            "Foo Fighter videos are always so great. Better actors than 90% of Hollywood."
        };

        List<string> video3 = new List<string>{
            "WHY DOES NO ONE SUSPECT THAT BRUCE WAYNE IS BATMAN?",
            "Ei Nerd",
            "7:30"
        };

        List<string> comments3 = new List<string>{
            "@Dantedacomunidade",
            "Porque o Julius é o Batman, eu vi no Todo Mundo Odeia o Chris",
            "@vitorlhamas169",
            "Gotham tem o mesmo déficit que o pessoal de Metrópolis com o Superman kkk",
            "@black.lockhart",
            "O Batman do Brasil com certeza é o Peter Jordan, o cara é rico, tem o shape, super inteligente, slk",
            "@crgui15",
            "O Rio de Janeiro pra virar Gothan City só falta o Batman mesmo, e resto já tem tudo!",
            "@Heliolopes17",
            "Batman comendo um churros, kkkkkkkkkkkkkkkkkk"
        };

        List<Video> videoObjectsList = new List<Video>();

        Video videoObject1 = new Video(video1);
        while (comments1.Count() != 0){
            Comment comment = new Comment(comments1[0], comments1[1]);
            comments1.RemoveAt(0);
            comments1.RemoveAt(0);
            videoObject1.SetComments(comment);
        }

        Video videoObject2 = new Video(video2);
        while (comments2.Count() != 0){
            Comment comment = new Comment(comments2[0], comments2[1]);
            comments2.RemoveAt(0);
            comments2.RemoveAt(0);
            videoObject2.SetComments(comment);
        }

        Video videoObject3 = new Video(video3);
        while (comments3.Count() != 0){
            Comment comment = new Comment(comments3[0], comments3[1]);
            comments3.RemoveAt(0);
            comments3.RemoveAt(0);
            videoObject3.SetComments(comment);
        }

        videoObjectsList.Add(videoObject1);
        videoObjectsList.Add(videoObject2);
        videoObjectsList.Add(videoObject3);

        foreach(Video video in videoObjectsList){
            Console.WriteLine("=================================================");
            video.DisplayInfo();
            video.DisplayComments();
        }
    }
}