// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello i am Ankush from F#"
type Genre =
    | Horror
    | Drama
    | Thriller
    | Comedy
    | Fantasy
    | Sport

type Director = {
    Name: string
    Movies: int
}

type Movie = {
    Name: string
    RunLength: int
    Genre: Genre
    Director: Director
    IMDBRating: float
}

let dir1 = { Name = "Sian Heder"; Movies = 9 }
let dir2 = { Name = "Kenneth Branagh"; Movies = 23 }
let dir3 = { Name = "Adam McKay"; Movies = 27 }
let dir4 = { Name = "Ryusuke Hamaguchi"; Movies = 16 }
let directorDune = { Name = "Denis Villeneuve"; Movies = 24 }
let directorKingRichard = { Name = "Reinaldo Marcus Green"; Movies = 15 }
let directorLicoricePizza = { Name = "Paul Thomas Anderson"; Movies = 49 }
let directorNightmareAlley = { Name = "Guillermo Del Toro"; Movies = 22 }

let coda = { Name = "CODA"; RunLength = 111; Genre = Drama; Director = dir1; IMDBRating = 8.1 }
let belfast = { Name = "Belfast"; RunLength = 98; Genre = Comedy; Director = dir2; IMDBRating = 7.3 }
let dontLookUp = { Name = "Don't Look Up"; RunLength = 138; Genre = Comedy; Director = dir3; IMDBRating = 7.2 }
let driveMyCar = { Name = "Drive My Car"; RunLength = 179; Genre = Drama; Director = dir4; IMDBRating = 7.6 }
let dune = { Name = "Dune"; RunLength = 155; Genre = Fantasy; Director = directorDune; IMDBRating = 8.1 }
let kingRichard = { Name = "King Richard"; RunLength = 144; Genre = Sport; Director = directorKingRichard; IMDBRating = 7.5 }
let licoricePizza = { Name = "Licorice Pizza"; RunLength = 133; Genre = Comedy; Director = directorLicoricePizza; IMDBRating = 7.4 }
let nightmareAlley = { Name = "Nightmare Alley"; RunLength = 150; Genre = Thriller; Director = directorNightmareAlley; IMDBRating = 7.1 }

let movies = [coda; belfast; dontLookUp; driveMyCar; dune; kingRichard; licoricePizza; nightmareAlley]

let probableOscarWinners = List.filter (fun movie -> movie.IMDBRating > 7.4) movies

let cal runLength =
    let hours = runLength / 60
    let minutes = runLength % 60
    sprintf "%dh %dmin" hours minutes

let convertedRunLengths = List.map (fun movie -> cal movie.RunLength) movies

printfn "Probable Oscar Winners: %A" probableOscarWinners
printfn "Converted Run Lengths: %A" convertedRunLengths




