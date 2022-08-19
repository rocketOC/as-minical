# as-minical

command line calendars for Linux and Windows

# about

as-minical is a small utility that uses [minical-dotnet](https://github.com/rocketOC/minical-dotnet) to generate calendars from a list of dates. This tool will grow as minical-dotnet grows.

# examples

Note: RocketOC.AsMinical.exe was renamed to as-minical.exe and is in a folder covered by the path environment variable.

## git commits

```bash
$ git log --pretty=%ad --date=short | as-minical
```

```
Aug `22
+―――+―――+―――+―――+
|   |   |   |   |
+―――+―――+―――+―――+
| X |   |   |   |
+―――+―――+―――+―――+
|   |   |   |   |
+―――+―――+―――+―――+―――+
|   |   |   |   |   |
+―――+―――+―――+―――+―――+
|   |   |   |   |   |
+―――+―――+―――+―――+―――+
|   |   |   |   |   |
+―――+―――+―――+―――+―――+
    |   | X |   |   |
    +―――+―――+―――+―――+
```

## pipe in dates from anywhere
```bash
$ echo -e "2022-08-18\n2022-09-23" | as-minical
```

```

Aug `22                 Sep `22
+―――+―――+―――+―――+       +―――+―――+―――+―――+
|   |   |   |   |       |   |   |   |   |
+―――+―――+―――+―――+       +―――+―――+―――+―――+―――+
|   |   |   |   |       |   |   |   | X |   |
+―――+―――+―――+―――+       +―――+―――+―――+―――+―――+
|   |   | X |   |       |   |   |   |   |   |
+―――+―――+―――+―――+―――+   +―――+―――+―――+―――+―――+
|   |   |   |   |   |       |   |   |   |   |
+―――+―――+―――+―――+―――+       +―――+―――+―――+―――+
|   |   |   |   |   |       |   |   |   |   |
+―――+―――+―――+―――+―――+       +―――+―――+―――+―――+
|   |   |   |   |   |       |   |   |   |   |
+―――+―――+―――+―――+―――+       +―――+―――+―――+―――+
    |   |   |   |   |       |   |   |   |   |
    +―――+―――+―――+―――+       +―――+―――+―――+―――+

```

## flexible date parsing

```bash
rocket@oc MINGW64 ~
$ cat sickDays.txt
2022-08-03
08/04/2022
8/5/2022
8/6/22

rocket@oc MINGW64 ~
$ cat sickDays.txt | as-minical

Aug `22
+―――+―――+―――+―――+
| X |   |   |   |
+―――+―――+―――+―――+
| X |   |   |   |
+―――+―――+―――+―――+
| X |   |   |   |
+―――+―――+―――+―――+―――+
| X |   |   |   |   |
+―――+―――+―――+―――+―――+
|   |   |   |   |   |
+―――+―――+―――+―――+―――+
|   |   |   |   |   |
+―――+―――+―――+―――+―――+
    |   |   |   |   |
    +―――+―――+―――+―――+
```