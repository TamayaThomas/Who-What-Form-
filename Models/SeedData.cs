using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Components.Web;
using System.ComponentModel;

namespace Who_What_Form_.Models;


public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using var context = new AppDbContext(serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>());

        if (context.Films.Any()) 
        {
            return;
        }

        context.Accounts.AddRange(
            new Account {UserId = 1, Username = "DemoUser", Email = "DemoUser@gmail.com", Password = "demouser"}
        );

        context.Films.AddRange(
            new Film {FilmID = 1, UserId = 1, Title = "Jeepers Creepers 2", Rating = "R", Description = "Set a few days after the original, a championship basketball team's bus is attacked by The Creeper, the winged, flesh-eating terror, on the last day of his 23-day feeding frenzy.", ImageUrl = "img/JeepersCreepers2.webp",},
            new Film {FilmID = 2, UserId = 1, Title = "Black Panther", Rating = "PG-13", Description = "T'Challa, heir to the hidden but advanced kingdom of Wakanda, must step forward to lead his people into a new future and must confront a challenger from his country's past.", ImageUrl = "img/BlackPanther.jpg",},
            new Film {FilmID = 3, UserId = 1, Title = "Hidden Figures", Rating = "PG", Description = "Three female African-American mathematicians play a pivotal role in astronaut John Glenn's launch into orbit while dealing with racial and gender discrimination.", ImageUrl = "img/HiddenFigures.webp",},
            new Film {FilmID = 4, UserId = 1, Title = "Home", Rating = "PG", Description = "Oh, a lovable misfit alien, runs away from his planet and takes shelter on Earth, where he befriends Tip, an adventurous young girl who is on a quest to find her displaced mother Lucy.", ImageUrl = "img/Home.webp",},
            new Film {FilmID = 5, UserId = 1, Title = "Lion King", Rating = "G", Description = "Lion prince Simba and his father are targeted by his bitter uncle, who wants to ascend the throne himself.", ImageUrl = "img/LionKing.webp",},
            new Film {FilmID = 8, UserId = 1, Title = "Lion King II: Simba's Pride ", Rating = "G", Description = "Simba's daughter is the key to a resolution of a bitter feud between Simba's pride and the outcast pride led by the mate of Scar.", ImageUrl = "img/LionKingII.webp",},
            new Film {FilmID = 6, UserId = 1, Title = "Pitch Perfect 2", Rating = "PG-13", Description = "After a humiliating command performance at The Kennedy Center, the Barden Bellas enter an international competition that no American group has ever won in order to regain their status and right to perform.", ImageUrl = "img/PitchPerfect2.webp",},
            new Film {FilmID = 7, UserId = 1, Title = "Spider-men: Into the Spider-verse", Rating = "PG", Description = "Teen Miles Morales becomes the Spider-Man of his universe and must join with five spider-powered individuals from other dimensions to stop a threat for all realities.", ImageUrl = "img/SpidermenITSV.webp",},
            new Film {FilmID = 9, UserId = 1, Title = "The Hate U Give", Rating = "PG-13", Description = "Starr witnesses the fatal shooting of her childhood best friend Khalil at the hands of a police officer. Now, facing pressure from all sides of the community, Starr must find her voice and stand up for what's right.", ImageUrl = "img/TheHateUGive.jpeg",},
            new Film {FilmID = 10, UserId = 1, Title = "Chowder", Rating = "TV-Y7-FV", Description = "In Marzipan City, excitable young food-loving Chowder is the apprentice of Mung Daal, a very old chef who runs a catering company with his wife Truffles and assistant Shnitzel.", ImageUrl = "img/Chowder.webp",},
            new Film {FilmID = 11, UserId = 1, Title = "The Blackening", Rating = "R", Description = "Seven friends go away for the weekend and end up trapped in a cabin with a killer who has a vendetta. Will their street smarts and knowledge of horror movies help them stay alive? Probably not.", ImageUrl = "img/TheBlackening.webp",},
            new Film {FilmID = 12, UserId = 1, Title = "Boo! A Madea Halloween", Rating = "PG-13", Description = "Madea lands in the midst of mayhem when she spends a haunted Halloween fending off killers, paranormal poltergeists, ghosts, ghouls, and zombies while keeping a watchful eye on her wild teenage great-niece.", ImageUrl = "img/MadeaBoo.webp",},
            new Film {FilmID = 13, UserId = 1, Title = "A Wrinkle in Time", Rating = "PG", Description = "After the disappearance of her scientist father, three peculiar beings send Meg, her brother, and her friend to space in order to find him.", ImageUrl = "img/AWrinkleInTime.jpeg",},
            new Film {FilmID = 14, UserId = 1, Title = "The Hunger Games", Rating = "PG-13", Description = "Katniss Everdeen voluntarily takes her younger sister's place in the Hunger Games: a televised competition in which two teenagers from each of the twelve Districts of Panem are chosen at random to fight to the death.", ImageUrl = "img/TheHungerGames.webp",},
            new Film {FilmID = 15, UserId = 1, Title = "When They See Us", Rating = "TV-MA", Description = "Five teens from Harlem become trapped in a nightmare when they're falsely accused of a brutal attack in Central Park. Based on the true story.", ImageUrl = "img/WhenTheySeeUs.webp",},
            new Film {FilmID = 16, UserId = 1, Title = "Fruitvale Station", Rating = "R", Description = "The story of Oscar Grant III, a 22-year-old Bay Area resident, who crosses paths with friends, enemies, family, and strangers on the last day of 2008.", ImageUrl = "img/FruitvaleStation.webp",},
            new Film {FilmID = 17, UserId = 1, Title = "42", Rating = "PG-13", Description = "In 1947, Jackie Robinson becomes the first African-American to play in Major League Baseball in the modern era when he was signed by the Brooklyn Dodgers and faces considerable racism in the process.", ImageUrl = "img/42.webp",},
            new Film {FilmID = 18, UserId = 1, Title = "They Clonded Tyrone", Rating = "R", Description = "A series of eerie events thrusts an unlikely trio onto the trail of a nefarious government conspiracy in this pulpy mystery caper.", ImageUrl = "img/TheyClonedTyrone.jpg",},
            new Film {FilmID = 19, UserId = 1, Title = "What Happened to Monday", Rating = "TV-MA", Description = "In a world where families are limited to one child due to overpopulation, a set of identical septuplets must avoid being put to a long sleep by the government and dangerous infighting while investigating the disappearance of one of their own.", ImageUrl = "img/WhatHappenedtoMonday",},
            new Film {FilmID = 20, UserId = 1, Title = "Pele: Birth of a Legend", Rating = "PG", Description = "Pele's meteoric rise from the slums of Sao Paulo to leading Brazil to its first World Cup victory at the age of 17 is chronicled in this biographical drama.", ImageUrl = "img/Pele.webp",},
            new Film {FilmID = 21, UserId = 1, Title = "Project Power", Rating = "R", Description = "When a pill that gives its users unpredictable superpowers for five minutes hits the streets of New Orleans, a teenage dealer and a local cop must team with an ex-soldier to take down the group responsible for its creation.", ImageUrl = "img/ProjectPower.png",},
            new Film {FilmID = 22, UserId = 1, Title = "The Fresh Prince of Bel-Air", Rating = "TV-PG", Description = "After getting into a fight, a streetwise teenager from a poor neighborhood in West Philadelphia, Pennsylvania is sent by his mother to live with his wealthy aunt, uncle, and cousins at their mansion in Bel-Air, Los Angeles in California.", ImageUrl = "img/Bel-Air.webp",},
            new Film {FilmID = 23, UserId = 1, Title = "Living Single", Rating = "TV-PG", Description = "Follows the lives of several single male and female roommates and friends in 1990s Brooklyn, New York.", ImageUrl = "img/LivingSingle.webp",},
            new Film {FilmID = 24, UserId = 1, Title = "Courage the Cowardly Dog", Rating = "TV-Y7", Description = "The offbeat adventures of Courage, a cowardly dog who must overcome his own fears to heroically defend his unknowing farmer owners from all kinds of dangers, paranormal events and menaces that appear around their land.", ImageUrl = "img/CouragetheCowardlyDog.webp",},
            new Film {FilmID = 25, UserId = 1, Title = "Friday", Rating = "R", Description = "It's Friday, and Craig and Smokey must come up with $200 they owe a local bully or there won't be a Saturday.", ImageUrl = "img/Friday.webp",}
        );

        context.Reviews.AddRange(
            new Review {FilmID = 1, ReviewID = 1, Score = 4, ReviewText = "I believe this is better than the first, to bad Scotty wasn't taken first"},
            new Review {FilmID = 2, ReviewID = 2, Score = 5, ReviewText = "Favorite Marvel movie right next to IronMan"},
            new Review {FilmID = 2, ReviewID = 3, Score = 5, ReviewText = "Wished it was 4 hours long!!!"},
            new Review {FilmID = 3, ReviewID = 4, Score = 5, ReviewText = "Love a black women from infitity to infitity"},
            new Review {FilmID = 3, ReviewID = 5, Score = 5, ReviewText = "Wished I had the brains to do math like that"},
            new Review {FilmID = 4, ReviewID = 6, Score = 3, ReviewText = "Rihanna was the main reason why i watched"},
            new Review {FilmID = 5, ReviewID = 7, Score = 5, ReviewText = "Will forever watch this movie!!"},
            new Review {FilmID = 5, ReviewID = 8, Score = 5, ReviewText = "Had to rewatch because the Live Action couldnt compare"},
            new Review {FilmID = 8, ReviewID = 11, Score = 5, ReviewText = "DECEPTION, DISGRACE"},
            new Review {FilmID = 6, ReviewID = 9, Score = 2, ReviewText = "Honestly mostly liked the song"},
            new Review {FilmID = 7, ReviewID = 10, Score = 5, ReviewText = "Spiderman should have been black since the suit has a built in durag IFYKYK"},
            new Review {FilmID = 9, ReviewID = 11, Score = 4, ReviewText = "Wish the movie stayed accurate with complexion of Star but beside that great!!"},
            new Review {FilmID = 10, ReviewID = 12, Score = 5, ReviewText = "Radda Radda"},
            new Review {FilmID = 10, ReviewID = 13, Score = 5, ReviewText = "Chowder and the little torch dude are funny together"},
            new Review {FilmID = 11, ReviewID = 14, Score = 4, ReviewText = "Love the scene when the group is trying to name characters from Friends."},
            new Review {FilmID = 12, ReviewID = 15, Score = 3, ReviewText = "Only watch when I can't find anything else"},
            new Review {FilmID = 13, ReviewID = 16, Score = 5, ReviewText = "The neighboorhood scene was perfectly done"},
            new Review {FilmID = 13, ReviewID = 17, Score = 5, ReviewText = "Love the soundtrack, including the Bailey twins was top tier"},
            new Review {FilmID = 14, ReviewID = 18, Score = 4, ReviewText = "Don't think I could muster up the will to survive like Katniss"},
            new Review {FilmID = 15, ReviewID = 19, Score = 5, ReviewText = "Can only watch once. EXONARTED FIVE!!!"},
            new Review {FilmID = 16, ReviewID = 20, Score = 5, ReviewText = "FOREVER REMEMBER Oscar Grant III!!!!"},
            new Review {FilmID = 17, ReviewID = 21, Score = 5, ReviewText = "The story of Jackie Robinson aka the Goat"},
            new Review {FilmID = 18, ReviewID = 22, Score = 4, ReviewText = "The realization of it being in the chicken was greatly done."},
            new Review {FilmID = 18, ReviewID = 23, Score = 5, ReviewText = "Love the twist at the end"},
            new Review {FilmID = 19, ReviewID = 24, Score = 3, ReviewText = "Monday being that selfish threw the whole movie off for me"},
            new Review {FilmID = 20, ReviewID = 25, Score = 5, ReviewText = "Love how they include the real Pele in the hotel scene."},
            new Review {FilmID = 21, ReviewID = 26, Score = 4, ReviewText = "Didn't explain if the duaghter powers are going to stay"},
            new Review {FilmID = 21, ReviewID = 27, Score = 5, ReviewText = "Kind of reminds me of how the supes in the Boys get there power"},
            new Review {FilmID = 22, ReviewID = 28, Score = 3, ReviewText = "Loved when it used to come on Nick at Night right after Full House"},
            new Review {FilmID = 23, ReviewID = 29, Score = 4, ReviewText = "A classic"},
            new Review {FilmID = 24, ReviewID = 30, Score = 4, ReviewText = "Courage should have convinvced his people to move out of the middle of nowwhere"},
            new Review {FilmID = 24, ReviewID = 31, Score = 5, ReviewText = "Was scared but forever stood on ten toes"},
            new Review {FilmID = 25, ReviewID = 32, Score = 4, ReviewText = "Never owe $200"}
        );

        context.Actors.AddRange(
            new Actor {FilmID = 6, ActorID = 1, Fname = "Anna", Lname = "Kendrick", ImageUrl = "img/AnnaKendrick.webp",},
            new Actor {FilmID = 2, ActorID = 2, Fname = "Chadwick", Lname = "Boseman", ImageUrl = "img/Chadwick.webp",},
            new Actor {FilmID = 1, ActorID = 3, Fname = "Eric", Lname = "Nenninger", ImageUrl = "img/eric.webp",},
            new Actor {FilmID = 5, ActorID = 4, Fname = "James E.", Lname = "Jones", ImageUrl = "img/JamesE.Jones.jpeg",},
            new Actor {FilmID = 3, ActorID = 5, Fname = "Taraji P.", Lname = "Henson", ImageUrl = "img/TarajiP..jpg",},
            new Actor {FilmID = 5, ActorID = 6, Fname = "Matthew", Lname = "Broderick", ImageUrl = "img/MatthewBroderick.webp",},
            new Actor {FilmID = 18, ActorID = 7, Fname = "Jamie", Lname = "Foxx", ImageUrl = "img/jamiefoxx.jpg"},
            new Actor {FilmID = 11, ActorID = 8, Fname = "Grace", Lname = "Byers", ImageUrl = "img/GraceByers.jpg" },
            new Actor {FilmID = 9, ActorID = 9, Fname = "Regina", Lname = "Hall", ImageUrl = "img/ReginaHall.webp"},
            new Actor {FilmID = 12, ActorID = 10, Fname = "Tyler", Lname = "Perry", ImageUrl = "img/Tyler.webp"},
            new Actor {FilmID = 13, ActorID = 11, Fname = "Storm", Lname = "Reid", ImageUrl = "img/StormReid.webp"},
            new Actor {FilmID = 14, ActorID = 12, Fname = "Jennifer", Lname = "Lawrence", ImageUrl = "img/Jennifer.webp"},
            new Actor {FilmID = 16, ActorID = 13, Fname = "Michael B.", Lname = "Jordan", ImageUrl = "img/MBJ.webp"},
            new Actor {FilmID = 17, ActorID = 14, Fname = "T.R.", Lname = "Knight", ImageUrl = "img/TRKnight.webp"},
            new Actor {FilmID = 22, ActorID = 15, Fname = "Will", Lname = "Smith", ImageUrl = "img/WillSmith.webp"},
            new Actor {FilmID = 23, ActorID = 16, Fname = "Queen", Lname = "Latifah", ImageUrl = "img/QueenLatifah.webp"},
            new Actor {FilmID = 25, ActorID = 17, Fname = "Ice", Lname = "Cube", ImageUrl = "img/IceCube.webp"}

        );

        context.Musics.AddRange(
            new Music {FilmID = 2, SongID = 1, SongTitle = "All The Stars (with SZA)", ArtistName = "Kendrick Lamar", ImageUrl = "img/KendrickLamar.webp",},
            new Music {FilmID = 2, SongID = 2, SongTitle = "King's Dead (with Kendrick Lamar, Future)", ArtistName = "Jay Rock", ImageUrl = "img/JayRock.webp",},
            new Music {FilmID = 4, SongID = 3, SongTitle = "Towards the Sun - From The 'Home' Soundtrack", ArtistName = "Rihanna", ImageUrl = "img/R.jpeg",},
            new Music {FilmID = 6, SongID = 4, SongTitle = "World Championship Finale 2 - From 'Pitch Perfect 2' Soundstrack", ArtistName = "The Barden Bellas", ImageUrl = "img/PitchPerfect2.webp",},
            new Music {FilmID = 7, SongID = 5, SongTitle = "Scared of the Dark (feat, XXXTENTACION)", ArtistName = "Lil Wayne", ImageUrl = "img/LilWayne.jpeg",},
            new Music {FilmID = 13, SongID = 6, SongTitle = "Warrior", ArtistName = "Chloe & Halle Bailey", ImageUrl = "img/BaileyTwins.jpeg"},
            new Music {FilmID = 14, SongID = 7, SongTitle = "The Hanging Tree", ArtistName = "James Newton Howard, Jennifer Lawrance", ImageUrl = "img/Jennifer.webp"},
            new Music {FilmID = 21, SongID = 8, SongTitle = "Grinding All My Life", ArtistName = "Nipsey Hussle", ImageUrl = "img/Nipsey.webp"},
            new Music {FilmID = 22, SongID = 9, SongTitle = "The Fresh Prince of Bel-Air", ArtistName = "Will Smith", ImageUrl = "img/WillSmith.webp"}
       );

        context.Sources.AddRange(
            new Source {FilmID = 2, SourceID = 1, SourceName = "Marvel Comics", SourceType = "Comic"},
            new Source {FilmID = 7, SourceID = 2, SourceName = "Marvel Comics", SourceType = "Comic"},
            new Source {FilmID = 9, SourceID = 3, SourceName = "The Hate U Give", SourceType = "Book"},
            new Source {FilmID = 13, SourceID = 4, SourceName = "A Wrinkle in Time", SourceType = "Book"},
            new Source {FilmID = 14, SourceID = 5, SourceName = "The Hunger Games", SourceType = "Book"}

        );
        context.SaveChanges();

    }

    
}