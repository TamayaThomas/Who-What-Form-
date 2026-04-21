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
            new Film {FilmID = 1, UserId = 1, Title = "Jeepers Creepers 2", Rating = "R", Description = "Set a few days after the original, a championship basketball team's bus is attacked by The Creeper, the winged, flesh-eating terror, on the last day of his 23-day feeding frenzy.", ImageURL = "img/",},
            new Film {FilmID = 2, UserId = 1, Title = "Black Panther", Rating = "PG-13", Description = "T'Challa, heir to the hidden but advanced kingdom of Wakanda, must step forward to lead his people into a new future and must confront a challenger from his country's past.", ImageURL = "img/",},
            new Film {FilmID = 3, UserId = 1, Title = "Hidden Figures", Rating = "PG", Description = "Three female African-American mathematicians play a pivotal role in astronaut John Glenn's launch into orbit while dealing with racial and gender discrimination.", ImageURL = "img/",},
            new Film {FilmID = 4, UserId = 1, Title = "Home", Rating = "PG", Description = "Oh, a lovable misfit alien, runs away from his planet and takes shelter on Earth, where he befriends Tip, an adventurous young girl who is on a quest to find her displaced mother Lucy.", ImageURL = "img/",},
            new Film {FilmID = 5, UserId = 1, Title = "Lion King", Rating = "G", Description = "Lion prince Simba and his father are targeted by his bitter uncle, who wants to ascend the throne himself.", ImageURL = "img/",},
            new Film {FilmID = 8, UserId = 1, Title = "Lion King II: Simba's Pride ", Rating = "G", Description = "Simba's daughter is the key to a resolution of a bitter feud between Simba's pride and the outcast pride led by the mate of Scar.", ImageURL = "img/",},
            new Film {FilmID = 6, UserId = 1, Title = "Pitch Perfect 2", Rating = "PG-13", Description = "After a humiliating command performance at The Kennedy Center, the Barden Bellas enter an international competition that no American group has ever won in order to regain their status and right to perform.", ImageURL = "img/",},
            new Film {FilmID = 7, UserId = 1, Title = "Spider-men: Into the Spider-verse", Rating = "PG", Description = "Teen Miles Morales becomes the Spider-Man of his universe and must join with five spider-powered individuals from other dimensions to stop a threat for all realities.", ImageURL = "img/",},
            new Film {FilmID = 9, UsedId = 1, Title = "", Rating = "", Descritpion = "", ImageURL = "img/",},
            new Film {FilmID = 10, UsedId = 1, Title = "", Rating = "", Descritpion = "", ImageURL = "img/",},
            new Film {FilmID = 11, UsedId = 1, Title = "", Rating = "", Descritpion = "", ImageURL = "img/",},
            new Film {FilmID = 12, UsedId = 1, Title = "", Rating = "", Descritpion = "", ImageURL = "img/",},
            new Film {FilmID = 13, UsedId = 1, Title = "", Rating = "", Descritpion = "", ImageURL = "img/",},
            new Film {FilmID = 14, UsedId = 1, Title = "", Rating = "", Descritpion = "", ImageURL = "img/",},
            new Film {FilmID = 15, UsedId = 1, Title = "", Rating = "", Descritpion = "", ImageURL = "img/",},
            new Film {FilmID = 16, UsedId = 1, Title = "", Rating = "", Descritpion = "", ImageURL = "img/",},
            new Film {FilmID = 17, UsedId = 1, Title = "", Rating = "", Descritpion = "", ImageURL = "img/",},
            new Film {FilmID = 18, UsedId = 1, Title = "", Rating = "", Descritpion = "", ImageURL = "img/",},
            new Film {FilmID = 19, UsedId = 1, Title = "", Rating = "", Descritpion = "", ImageURL = "img/",},
            new Film {FilmID = 20, UsedId = 1, Title = "", Rating = "", Descritpion = "", ImageURL = "img/",},
            new Film {FilmID = 21, UsedId = 1, Title = "", Rating = "", Descritpion = "", ImageURL = "img/",},
            new Film {FilmID = 22, UsedId = 1, Title = "", Rating = "", Descritpion = "", ImageURL = "img/",},
            new Film {FilmID = 23, UsedId = 1, Title = "", Rating = "", Descritpion = "", ImageURL = "img/",},
            new Film {FilmID = 24, UsedId = 1, Title = "", Rating = "", Descritpion = "", ImageURL = "img/",},
            new Film {FilmID = 25, UsedId = 1, Title = "", Rating = "", Descritpion = "", ImageURL = "img/",}

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
            new Review {FilmID = 7, ReviewID = 10, Score = 5, ReviewText = "Spiderman should have been black since the suit has a built in durag IFYKYK"}
        );

        context.Actors.AddRange(
            new Actor {FilmID = 6, ActorID = 1, Fname = "Anna", Lname = "Kendrick", ImageURL = "img/",},
            new Actor {FilmID = 2, ActorID = 2, Fname = "Chadwick", Lname = "Boseman", ImageURL = "img/",},
            new Actor {FilmID = 1, ActorID = 3, Fname = "Eric", Lname = "Nenninger", ImageURL = "img/",},
            new Actor {FilmID = 5, ActorID = 4, Fname = "James E.", Lname = "Jones", ImageURL = "img/",},
            new Actor {FilmID = 3, ActorID = 5, Fname = "Taraji P.", Lname = "Henson", ImageURL = "img/",},
            new Actor {FilmID = 5, ActorID = 6, Fname = "Matthew", Lname = "Broderick", ImageURL = "img/",}

        );

        context.Musics.AddRange(
            new Music {FilmID = 2, SongID = 1, SongTitle = "All The Stars (with SZA)", ArtistName = "Kendrick Lamar", ImageURL = "img/",},
            new Music {FilmID = 2, SongID = 2, SongTitle = "King's Dead (with Kendrick Lamar, Future)", ArtistName = "Jay Rock", ImageURL = "img/",},
            new Music {FilmID = 4, SongID = 3, SongTitle = "Towards the Sun - From The 'Home' Soundtrack", ArtistName = "Rihanna", ImageURL = "img/",},
            new Music {FilmID = 6, SongID = 4, SongTitle = "World Championship Finale 2 - From 'Pitch Perfect 2' Soundstrack", ArtistName = "The Barden Bellas", ImageURL = "img/",},
            new Music {FilmID = 7, SongID = 5, SongTitle = "Scared of the Dark (feat, XXXTENTACION)", ArtistName = "Lil Wayne", ImageURL = "img/",}
       );

        context.Sources.AddRange(
            new Source {FilmID = 2, SourceID = 1, SourceName = "Marvel Comics", SourceType = "Comic"},
            new Source {FilmID = 7, SourceID = 2, SourceName = "Marvel Comics", SourceType = "Comic"}

        );
        context.SaveChanges();

    }

    
}