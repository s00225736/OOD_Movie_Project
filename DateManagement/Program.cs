using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOD_Movie_Project;

namespace DateManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MovieData db = new MovieData("MovieProject");

            using (db)
            {
                //some movies 
                Movies m1 = new Movies() {MovieName = "Casablanca", Date = 23 / 01 / 1943, descriptions = "During WWII, Rick, a nightclub owner in Casablanca, agrees to help his former lover Ilsa and her husband. Soon, Ilsa's feelings for Rick resurface and she finds herself renewing her love for him." };
                Movies m2 = new Movies() {MovieName = "Blade Runner", Date = 25 / 06 / 1982 , descriptions = "Rick Deckard, an ex-policeman, becomes a special agent with a mission to exterminate a group of violent androids. As he starts getting deeper into his mission, he questions his own identity." };
                Movies m3 = new Movies() { MovieName = "Dune 2", Date = 01 / 03 / 2024, descriptions = "Paul Atreides unites with Chani and the Fremen while seeking revenge against the conspirators who destroyed his family. Facing a choice between the love of his life and the fate of the universe, he must prevent a terrible future only he can foresee." };
                Movies m4 = new Movies() { MovieName = "Godfather 1", Date = 25 / 08 / 1972, descriptions = "Don Vito Corleone, head of a mafia family, decides to hand over his empire to his youngest son, Michael. However, his decision unintentionally puts the lives of his loved ones in grave danger." };
                Movies m5 = new Movies() { MovieName = "Indiana Jones And The Raider Of The Lost Ark", Date = 07 / 08 / 1981, descriptions = "Upon his arrival in India, Indiana Jones, an American adventurer, is asked by the villagers of a remote hamlet to retrieve a mystical stone and rescue young boys kidnapped from the village." };
                Movies m6 = new Movies() { MovieName = "Killers Of The Flower Moon", Date = 20 / 10 / 2023, descriptions = "Real love crosses paths with unspeakable betrayal as Mollie Burkhart, a member of the Osage Nation, tries to save her community from a spree of murders fueled by oil and greed." };
                Movies m7 = new Movies() { MovieName = "Monty Python And The Holy Grail ", Date = 25 / 05 / 1975, descriptions = "King Arthur and his knights are tasked by God to find the legendary Holy Grail. During their journey, they encounter various people and obstacles that hinder them on their quest." };
                Movies m8 = new Movies() { MovieName = "Oppenheimer", Date = 21 / 07 / 2023, descriptions = "During World War II, Lt. Gen. Leslie Groves Jr. appoints physicist J. Robert Oppenheimer to work on the top-secret Manhattan Project. Oppenheimer and a team of scientists spend years developing and designing the atomic bomb. Their work comes to fruition on July 16, 1945, as they witness the world's first nuclear explosion, forever changing the course of history." };
                Movies m9 = new Movies() { MovieName = "Ran", Date = 01 / 06 / 1985, descriptions = "An ageing warlord retires and entrusts his empire to his three sons. However, he soon realises that power has corrupted them and made them uncontrollable." };
                Movies m10 = new Movies() { MovieName = "Star Wars The Revenge Of The Sith", Date = 19 / 05 / 2005, descriptions = "Anakin joins forces with Obi-Wan and sets Palpatine free from the evil clutches of Count Doku. However, he falls prey to Palpatine and the Jedis' mind games and gives into temptation." };

                //some reviews
                MovieReview r1 = new MovieReview() {ReviewerName = "Karst", ReviewDesc = "one of those moviegoing experiences i’ll cherish for the rest of my life" };
                MovieReview r2 = new MovieReview() { ReviewerName = "TheFilmPope" , ReviewDesc = "Denis Villeneuve has done something truly unique here." };
                MovieReview r3 = new MovieReview() { ReviewerName = "Cam Walsh" , ReviewDesc = "This is truly the cinematic event of our generation… don’t take it for granted 100/100" };
                MovieReview r4 = new MovieReview() { ReviewerName = "Karst" , ReviewDesc = "Three times. Three separate times I have tried to watch this, falling asleep each time and never being able to finish it. Not sure if I should blame the movie or my horrible sleep schedule, but it took way longer to watch this than it should’ve. Anyways, yeah it’s fine but not my type of thing." };
                MovieReview r5 = new MovieReview() { ReviewerName = "BrenerTT" , ReviewDesc = "We'll always have Paris" };
                MovieReview r6 = new MovieReview() { ReviewerName = "Reyach" , ReviewDesc = "Eerie and uncanny. Script is great. Visuals are beautiful" };
                MovieReview r7 = new MovieReview() { ReviewerName = "BlinkerSolidman" , ReviewDesc = "Final cut, looked amazing "};
                MovieReview r8 = new MovieReview() { ReviewerName = "Tmason00", ReviewDesc = "A masterpiece! I love it gets better with every watch." };
                MovieReview r9 = new MovieReview() { ReviewerName = "Karst", ReviewDesc = "I was sooooo ready to say this was overhyped but nope, it’s as good as everyone says it is. On to part 2." };
                MovieReview r10 = new MovieReview() { ReviewerName = "Karst", ReviewDesc = "Perfect film. Made me want to make movies." };
                MovieReview r11 = new MovieReview() { ReviewerName = "Tentin Quarantno", ReviewDesc = "I don't trust anyone who dislikes this movie." };
                MovieReview r12 = new MovieReview() { ReviewerName = "KeerinLoocis", ReviewDesc = "I did not stop quoting it the whole time" };
                MovieReview r13 = new MovieReview() { ReviewerName = "Bravosky", ReviewDesc = "This film belongs in a museum." };
                MovieReview r14 = new MovieReview() { ReviewerName = "CarolineCain", ReviewDesc = "the fact that i had to watch this for an archaeology class is appalling" };
                MovieReview r15 = new MovieReview() { ReviewerName = "OppenheimerFan", ReviewDesc = "“There was no mention of the murders.”Incredible final line by the director himself, Martin Scorsese." };
                MovieReview r16 = new MovieReview() { ReviewerName = "Luigi", ReviewDesc = "Lily Gladstone has to win the oscar" };
                MovieReview r17 = new MovieReview() { ReviewerName = "Martin", ReviewDesc = "lily gladstone left me speechless and wow i really dont like leonardo dicaprio" };
                MovieReview r18 = new MovieReview() { ReviewerName = "Patrick Willems", ReviewDesc = "It’s so funny that this is a big summer blockbuster" };
                MovieReview r19 = new MovieReview() { ReviewerName = "Flynn", ReviewDesc = "I thought this would be a Christopher Nolan film I could actually understand but I was wrong" };
                MovieReview r20 = new MovieReview() { ReviewerName = "SuspirLiam", ReviewDesc = "can’t shake the image of the raindrop ripples and the sound of stamping feet….. nolan is a GENIUS" };
                MovieReview r21 = new MovieReview() { ReviewerName = "Mattie Gazzard", ReviewDesc = "Never gets old" };
                MovieReview r22 = new MovieReview() { ReviewerName = "Amaya", ReviewDesc = "sometimes i think i am a mature person and sometimes i cry of laughter because a french man said i fart in your general direction" };
                MovieReview r23 = new MovieReview() { ReviewerName = "Trex888", ReviewDesc = "this is the greatest movie ever made" };
                MovieReview r24 = new MovieReview() { ReviewerName = "Karst", ReviewDesc = "I feel like I just witnessed color in film for the first time.There is a lot to love about Ran. It's way of finding heart and beauty in a story fueled by hatred and tension is one of my favorite aspects, I suppose. But then there's the color. And the editing. And everything else." };
                MovieReview r25 = new MovieReview() { ReviewerName = "Emily Housel", ReviewDesc = "if Kurosawa made a 3 hour film of just clouds and grass I’d probably watch it every day" };
                MovieReview r26 = new MovieReview() { ReviewerName = "Zegan", ReviewDesc = "Akira Kurosawa is god or what?" };
                MovieReview r27 = new MovieReview() { ReviewerName = "houston Coley", ReviewDesc = "it’s crazy how this movie was bad for a decade, and then it just like....became good" };
                MovieReview r28 = new MovieReview() { ReviewerName = "Mario", ReviewDesc = "This is where the fun begins." };
                MovieReview r29 = new MovieReview() { ReviewerName = "Wes", ReviewDesc = "there is a very small but loud part of me that feels this is the best one" };


            }
        }
    }
}
