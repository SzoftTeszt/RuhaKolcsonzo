# RuhaKölcsönző - starter projekt

Ez a repository a csoportfeladat közös induló projektje.

## Mi van készen?
- EF Core modellek: `Ugyfel`, `Ruha`, `Kolcsonzes`
- `RuhaKolcsonzoContext`
- SQL Server LocalDB kapcsolat
- CSV seed
- működő `MainForm`
- négy külön modul-form, amelyek jelenleg csak TODO feliratot tartalmaznak

## Első indítás
Visual Studio:
1. Startup Project: `RuhaKolcsonzo.Desktop`
2. Package Manager Console Default project: `RuhaKolcsonzo.Data`
3. Futtasd:
   `Add-Migration ElsoMigration`
   `Update-Database`
4. Indítsd a projektet.

## 3 fős csoport
- A: `UgyfelekForm.cs` + `.Designer.cs`
- B: `RuhakForm.cs` + `.Designer.cs`
- C: `KolcsonzesekForm.cs` + `.Designer.cs`
- `KimutatasokForm` felosztható annak, aki előbb elkészül.

## 2 fős csoport
- A: `UgyfelekForm*` + `KimutatasokForm*`
- B: `RuhakForm*` + `KolcsonzesekForm*`

A `MainForm`, `Program.cs`, modellek, Context és SeedData közös alap: ezeket ne módosítsátok.

## Git munkafolyamat - branch nélkül
Mindenki közvetlenül a `main` ágon dolgozik. Külön brancheket nem használunk.

Munka előtt mindig:
```bash
git pull
```

Mindenki csak a saját moduljának `.cs` és `.Designer.cs` fájljait módosítsa. A `MainForm`, `Program.cs`, modellek, Context és SeedData közös alap, ezeket ne módosítsátok.

Saját rész mentése:
```bash
git add .
git commit -m "Ruhak modul kesz"
git pull
git push
```

Mivel a csapattagok külön fájlokon dolgoznak, a Git-ütközés esélye kicsi.
