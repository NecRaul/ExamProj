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

## Login

I've provided a default `.sqlite` database for use.

``` User Credentials
Username: admin
Password: admin
```

## How to take an exam

You must have atleast 25 questions in the database (10 easy, 10 normal, 5 hard) to take an exam.

## How to work with multiple databases at the same time

You can copy the `.sqlite` file that comes with this repo to `bin\Debug\net6.0-windows` folder under different names and change Data Source in `ExamProj.dll.config` to whichever database you want to work with at the time.

## To do list

* ~~Make an overall architecture of how everything is gonna work~~
* ~~Question Grid Form to delete, add, preview and keep a list of the questions/answers~~
* ~~Deleting multiple questions from Grid Form~~
* ~~Question CRUD Form to create/update questions~~
* ~~Validations for Question CRUD Form~~
* ~~Exam Form to actually exam the students~~
* ~~Validations for Exam Form~~
* ~~User class and distinguishing between student and teacher~~
* ~~Login Form~~
* ~~Home screen Form to connect everything~~
* ~~User Grid Form to delete, add, preview and keep a list of users~~
* ~~User CRUD Form to create/update users~~
* ~~Validations for User CRUD Form~~
* ~~Show who's taking the exam in Exam Form~~
* ~~User analytics (how many questions/answers etc.)~~
* ~~Show which questions were answered correctly, incorrectly and not answered in Exam Form~~
* ~~Make sure duplicate questions won't come up during the exam~~
* ~~Fix issue regarding not being able to update answers to questions~~
* ~~Add coloring to which answer is correct/incorrect after the exam is done~~
* ~~Fix the users grid to show analytics~~
* ~~Fix username not showing up in the exam form~~
