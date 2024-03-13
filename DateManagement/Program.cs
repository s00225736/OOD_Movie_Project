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
            MovieData db = new MovieData();

            using (db)
            {
                #region movies
                Movies m1 = new Movies() { MovieName = "Casablanca",Director = "Michael Curtiz", Date = 23 / 01 / 1943, Descriptions = "During WWII, Rick, a nightclub owner in Casablanca, agrees to help his former lover Ilsa and her husband. Soon, Ilsa's feelings for Rick resurface and she finds herself renewing her love for him." };
                Movies m2 = new Movies() { MovieName = "Blade Runner",Director = "Ridley Scott", Date = 25 / 06 / 1982, Descriptions = "Rick Deckard, an ex-policeman, becomes a special agent with a mission to exterminate a group of violent androids. As he starts getting deeper into his mission, he questions his own identity." };
                Movies m3 = new Movies() { MovieName = "Dune 2", Director = "Denis Villeneuve", Date = 01 / 03 / 2024, Descriptions = "Paul Atreides unites with Chani and the Fremen while seeking revenge against the conspirators who destroyed his family. Facing a choice between the love of his life and the fate of the universe, he must prevent a terrible future only he can foresee." };
                Movies m4 = new Movies() { MovieName = "Godfather 1", Director = "Francis Ford Coppola", Date = 25 / 08 / 1972, Descriptions = "Don Vito Corleone, head of a mafia family, decides to hand over his empire to his youngest son, Michael. However, his decision unintentionally puts the lives of his loved ones in grave danger." };
                Movies m5 = new Movies() { MovieName = "Indiana Jones And The Raider Of The Lost Ark", Director = "Steven Spielberg", Date = 07 / 08 / 1981, Descriptions = "Upon his arrival in India, Indiana Jones, an American adventurer, is asked by the villagers of a remote hamlet to retrieve a mystical stone and rescue young boys kidnapped from the village." };
                Movies m6 = new Movies() { MovieName = "Killers Of The Flower Moon", Director = "Martin Scorsese", Date = 20 / 10 / 2023, Descriptions = "Real love crosses paths with unspeakable betrayal as Mollie Burkhart, a member of the Osage Nation, tries to save her community from a spree of murders fueled by oil and greed." };
                Movies m7 = new Movies() { MovieName = "Monty Python And The Holy Grail ", Director = "Terry Gilliam and Terry Jones", Date = 25 / 05 / 1975, Descriptions = "King Arthur and his knights are tasked by God to find the legendary Holy Grail. During their journey, they encounter various people and obstacles that hinder them on their quest." };
                Movies m8 = new Movies() { MovieName = "Oppenheimer", Date = 21 / 07 / 2023, Director = "Christopher Nolan", Descriptions = "During World War II, Lt. Gen. Leslie Groves Jr. appoints physicist J. Robert Oppenheimer to work on the top-secret Manhattan Project. Oppenheimer and a team of scientists spend years developing and designing the atomic bomb. Their work comes to fruition on July 16, 1945, as they witness the world's first nuclear explosion, forever changing the course of history." };
                Movies m9 = new Movies() { MovieName = "Ran", Date = 01 / 06 / 1985, Director = "Akira Kurosawa", Descriptions = "An ageing warlord retires and entrusts his empire to his three sons. However, he soon realises that power has corrupted them and made them uncontrollable." };
                Movies m10 = new Movies() { MovieName = "Star Wars The Revenge Of The Sith", Director = "George Lucas", Date = 19 / 05 / 2005, Descriptions = "Anakin joins forces with Obi-Wan and sets Palpatine free from the evil clutches of Count Doku. However, he falls prey to Palpatine and the Jedis' mind games and gives into temptation." };

                #endregion

                #region reviews                
                //casablanca
                MovieReview r1 = new MovieReview() { ReviewerName = "BrenerTT", ReviewDesc = "We'll always have Paris", Movie = m1 };
                MovieReview r2 = new MovieReview() { ReviewerName = "Karst", ReviewDesc = "Three times. Three separate times I have tried to watch this, falling asleep each time and never being able to finish it. Not sure if I should blame the movie or my horrible sleep schedule, but it took way longer to watch this than it should’ve. Anyways, yeah it’s fine but not my type of thing.", Movie = m1 };
                MovieReview r3 = new MovieReview() { ReviewerName = "Reece", ReviewDesc = "I'm straight up crying on a plane right now because of this movie", Movie = m1 };
                
                //blade runner
                MovieReview r4 = new MovieReview() { ReviewerName = "BlinkerSolidman", ReviewDesc = "Final cut, looked amazing ", Movie = m2 };
                MovieReview r5 = new MovieReview() { ReviewerName = "Reyach", ReviewDesc = "Eerie and uncanny. Script is great. Visuals are beautiful", Movie = m2 };
                MovieReview r6 = new MovieReview() { ReviewerName = "Karst", ReviewDesc = "Perfect film. Made me want to make movies." , Movie = m2};

                //dune 2
                MovieReview r7 = new MovieReview() { ReviewerName = "Karst", ReviewDesc = "one of those moviegoing experiences i’ll cherish for the rest of my life", Movie = m3 };
                MovieReview r8 = new MovieReview() { ReviewerName = "TheFilmPope", ReviewDesc = "Denis Villeneuve has done something truly unique here.", Movie = m3 };
                MovieReview r9 = new MovieReview() { ReviewerName = "Cam Walsh", ReviewDesc = "This is truly the cinematic event of our generation… don’t take it for granted 100/100", Movie = m3 };

                //godfather
                MovieReview r10 = new MovieReview() { ReviewerName = "Karst", ReviewDesc = "I was sooooo ready to say this was overhyped but nope, it’s as good as everyone says it is. On to part 2.", Movie = m4 };
                MovieReview r11 = new MovieReview() { ReviewerName = "Tentin Quarantno", ReviewDesc = "I don't trust anyone who dislikes this movie.", Movie = m4 };
                MovieReview r12 = new MovieReview() { ReviewerName = "Trex888", ReviewDesc = "this is the greatest movie ever made", Movie = m4 };

                //indiana jones
                MovieReview r13 = new MovieReview() { ReviewerName = "Bravosky", ReviewDesc = "This film belongs in a museum.", Movie = m5 };
                MovieReview r14 = new MovieReview() { ReviewerName = "CarolineCain", ReviewDesc = "the fact that i had to watch this for an archaeology class is appalling", Movie = m5 };
                MovieReview r15 = new MovieReview() { ReviewerName = "Tmason00", ReviewDesc = "A masterpiece! I love it gets better with every watch.", Movie = m5 };

                //killers of the flower moom
                MovieReview r16 = new MovieReview() { ReviewerName = "OppenheimerFan", ReviewDesc = "“There was no mention of the murders.”Incredible final line by the director himself, Martin Scorsese.", Movie = m6 };
                MovieReview r17 = new MovieReview() { ReviewerName = "Luigi", ReviewDesc = "Lily Gladstone has to win the oscar", Movie = m6 };
                MovieReview r18 = new MovieReview() { ReviewerName = "Martin", ReviewDesc = "lily gladstone left me speechless and wow i really dont like leonardo dicaprio", Movie = m6 };

                //monty python
                MovieReview r19 = new MovieReview() { ReviewerName = "Amaya", ReviewDesc = "sometimes i think i am a mature person and sometimes i cry of laughter because a french man said i fart in your general direction", Movie = m7 };
                MovieReview r20 = new MovieReview() { ReviewerName = "Mattie Gazzard", ReviewDesc = "Never gets old", Movie = m7 };
                MovieReview r21 = new MovieReview() { ReviewerName = "KeerinLoocis", ReviewDesc = "I did not stop quoting it the whole time", Movie = m7 };

                //oppenheimer
                MovieReview r22 = new MovieReview() { ReviewerName = "Patrick Willems", ReviewDesc = "It’s so funny that this is a big summer blockbuster", Movie = m8 };
                MovieReview r23 = new MovieReview() { ReviewerName = "Flynn", ReviewDesc = "I thought this would be a Christopher Nolan film I could actually understand but I was wrong", Movie = m8 };
                MovieReview r24 = new MovieReview() { ReviewerName = "SuspirLiam", ReviewDesc = "can’t shake the image of the raindrop ripples and the sound of stamping feet….. nolan is a GENIUS", Movie = m8 };

                //ran
                MovieReview r25 = new MovieReview() { ReviewerName = "Karst", ReviewDesc = "I feel like I just witnessed color in film for the first time.There is a lot to love about Ran. It's way of finding heart and beauty in a story fueled by hatred and tension is one of my favorite aspects, I suppose. But then there's the color. And the editing. And everything else.", Movie = m9 };
                MovieReview r26 = new MovieReview() { ReviewerName = "Emily Housel", ReviewDesc = "if Kurosawa made a 3 hour film of just clouds and grass I’d probably watch it every day", Movie = m9 };
                MovieReview r27 = new MovieReview() { ReviewerName = "Zegan", ReviewDesc = "Akira Kurosawa is god or what?", Movie = m9 };

                //star wars
                MovieReview r28 = new MovieReview() { ReviewerName = "houston Coley", ReviewDesc = "it’s crazy how this movie was bad for a decade, and then it just like....became good", Movie = m10 };
                MovieReview r29 = new MovieReview() { ReviewerName = "Mario", ReviewDesc = "This is where the fun begins.", Movie = m10 };
                MovieReview r30 = new MovieReview() { ReviewerName = "Wes", ReviewDesc = "there is a very small but loud part of me that feels this is the best one", Movie = m10 };
                #endregion

                db.Movies.AddRange(new Movies[] { m1, m2, m3,m4,m5,m6,m7,m8,m9,m10 });
                db.MovieReviews.AddRange(new MovieReview[] { r1, r2, r3, r4, r5, r6, r7, r8, r9,r10,r11,r12,r13,r14,r15,r16,r17,r18,r18,r19,r20,r21,r22,r23,r24,r25,r26,r27,r28,r29,r30 });
                db.SaveChanges();

            }
        }
    }
}
