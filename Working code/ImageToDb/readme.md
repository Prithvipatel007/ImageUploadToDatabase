# ImageToDb
Hello there, in this repository i want to share how to save image into database

# Introduction
Before you clone/fork this project, let me tell you something about this project
Firstly in this project i convert images file to byte and store that in database

# How To Call Image
What we need to call the image is just fill the src in img tags with ```data:image/png;base64,@{Convert.ToBase64String(Model.Img)}```

# Examples
You can find it in Index function of ImagesController
Or simply try to add Images in 
***http://localhost:yourport/images/create***
And check the result in
***http://localhost:yourport:images***
