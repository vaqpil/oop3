Autor pushkin = new Autor();

pushkin.name = "Александр";
pushkin.first_name = "Пушкин";
pushkin.birth_day = new DateTime(1799, 04, 26);
pushkin.death_day = new DateTime(1837, 12, 29);
pushkin.genre = "Roman";
pushkin.country = "Россия";

pushkin.Print_autor();

pushkin.Print_bred();



Autor Lermontov = new Autor();
Lermontov.name = "Михаил";
Lermontov.first_name = "Лермонтов";
Lermontov.birth_day = new DateTime(1814, 10, 15);
Lermontov.death_day = new DateTime(1841, 07, 27);
Lermontov.genre = "Prose";
Lermontov.country = "Россия";

Lermontov.Print_autor();

Lermontov.Print_bred();



Autor block = new Autor();
block.name = "Александр";
block.first_name = "Блок";
block.birth_day = new DateTime(1880, 10, 29);
block.death_day = new DateTime(1921, 08, 07);
block.genre = "Poetry";
block.country = "Россия";

block.Print_autor();

block.Print_bred();





Books Ruslan_and_Ludmila = new Books();

Ruslan_and_Ludmila.name = "Руслан и Людмила";
Ruslan_and_Ludmila.genre = "Poem";
Ruslan_and_Ludmila.release = new DateTime(1820, 07, 01);
Ruslan_and_Ludmila.autor_name = "Александр Пушкин";
Ruslan_and_Ludmila.country = "Здесь страна происхождения книги";

Ruslan_and_Ludmila.Print_book();

Ruslan_and_Ludmila.Print_gran();
