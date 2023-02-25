# ExamProj

I had a math teacher back in high school who tried to make an exam app that you could put questions/answers into and then randomize them to give to students. This is gonna be something of that sort.

I've already worked on a similar project before but because it's for commercial use I can't upload my work here so instead I decided on using this to showcase my skills/make my teacher happy.

## Dependencies

``` C# Dependecies
DevExpress.Win.Design
Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.Sqlite
Microsoft.EntityFrameworkCore.Tools
```

## DevExpress

If there's an issue regarding DevExpress during the initial build, use Project Converter to change version to fit your version.

## Why DevExpress

The components look better and are easier to work with than the default WinForms ones.

## How to run it

After converting/building the project, put the database file **`ExamDb.sqlite`** in `bin\Debug\net6.0-windows` folder. At that point, you can carry the `net6.0-windows` folder with you to any machine running Windows and carry your questions/answers there with you.

## How to work with multiple databases at the same time

You can copy the `.sqlite` file that comes with this repo to `bin\Debug\net6.0-windows` folder under different names and change Data Source in `ExamProj.dll.config` to whichever database you want to work with at the time.

## To do list

* ~~Make an overall architecture of how everything is gonna work~~
* ~~Grid form to delete, add, preview and keep a list of the questions/answers~~
* ~~Deleting multiple questions from Grid form~~
* ~~CRUD form to create/update questions~~
* Validations for CRUD form
* Exam form to actually exam the students
