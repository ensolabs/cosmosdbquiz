# Beskrivelse av skjema for databaser: 

## Graphdb
### Vertices (noder)

```javascript
{
    "Movie":{
        "Id": string,
        "Budget": int,
        "Imdb_Id": string,
        "Original_language": string,
        "Original_title": string,
        "Overview": string,
        "Popularity": double,
        "ReleaseDate": DateTime,
        "Revenue": double,
        "Runtime": int,
        "Tagline": string,
        "Title": string,
        "Vote_average": double,
        "Vote_count": double
    }
}

{
    "Language":{
        "Id": string,
        "Name": string
    }
}

{
    "Actor":{
        "Id": string,
        "Gender": int, // 1= kvinne 2= mann
        "Name": string
    }
}

{
    "Genre":{
        "Id": string,
        "Name": string
    }
}

{
    "ProductionCompany": {
        "Id": string,
        "Name": string
    }
}
```

### Edges (relasjoner)

```
Edges: 
"ACTED_IN"
"HAS_PRODUCED"
"HAS_GENRE"
"HAS LANGUAGE"

Forklaring:
(vertex)->(RELATION)->(vertex)

productionCompany -> HAS_PRODUCED -> movie

actor -> ACTED_IN -> movie

movie -> HAS_GENRE -> genre

movie -> HAS_LANGUAGE -> language
```

## DocumentDB og MongoDB
``` javascript
[
  {
    "adult": bool,
    "backdrop_path": string,
    "belongs_to_collection": null,
    "budget": int,
    "genres": [
      {
        "id": int,
        "name": string // F.eks "Adventure"
      }
    ],
    "homepage": string, // url
    "id": string,
    "imdb_id": string,
    "original_language": string,
    "original_title": string,
    "overview": string,
    "popularity": double,
    "poster_path": string,
    "production_companies": [
      {
        "name": string,
        "id": int
      }
    ],
    "production_countries": [
      {
        "iso_3166_1": string, // f.eks "US"
        "name": string // f.eks "United States of America"
      }
    ],
    "release_date": string, // f.eks "2017-09-05"
    "revenue": int, // sikkert $$$
    "runtime": int, // minutes
    "spoken_languages": [
      {
        "iso_639_1": string, // f.eks "en"
        "name": string // f.eks "English"
      }
    ],
    "status": string,
    "tagline": string,
    "title": string,
    "video": bool,
    "vote_average": double,
    "vote_count": int,
    "cast": [
      {
        "cast_id": int,
        "character": string,
        "credit_id": string,
        "gender": int, // 1= kvinne 2 = mann
        "id": int,
        "name": string,
        "order": int,
        "profile_path": string
      }
    ]
  }
]
```

## Table storage
| Partition key | Row key | Gender | Name |
|---------------|---------|--------|------|
| gender      |  id   |gender|name|


