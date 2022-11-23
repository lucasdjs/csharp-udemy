using Exercicio_2_Demo_String_Builder.Entities;

Comment comment1 = new Comment("Have a nice trip!");
Comment comment2 = new Comment("Wow Thats awesome!");

Post p1 = new Post(
    DateTime.Parse("21/06/2018 13:05:44"),
    "Traveling to New Zealeand",
    "Im going to visit this wonderful contry!",
    12

    );
p1.AddComment(comment1);
p1.AddComment(comment2);


Post p2 = new Post(DateTime.Parse("28/07/2018 23:05:44"),
    "Good Nigth guys",
    "See you tomorrow!",
    5);

Comment c1 = new Comment("Good Nigth");
p2.AddComment(c1);
Comment c2 = new Comment("May the force be with you");
p2.AddComment(c2);

Console.WriteLine(p1);
Console.WriteLine(p2);
