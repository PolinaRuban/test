1. Change string Directory in ReadFromTextFile class. (it will not be used until you will change the menu)
2. You have the database named Database.mdf
3. So please, do this:
-Open app.config
-Change connectionString (AttachDbFilename from my path to yours)
(OR visit https://stackoverflow.com/questions/4324052/ef4-code-first-causes-invalidoperationexception/21263522#21263522 and do everything according to the the 3 answer)

If something will be wrong, after first steps:
-open Package Manager Console
-write "update-database" (I hope everything will be ok.) (You will see "Run seed method")

That's it! Enjoy. Use F5 for running the project.
