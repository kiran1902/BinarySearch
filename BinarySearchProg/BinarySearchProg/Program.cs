using BinarySearchProg;

Binary<int> binary = new Binary<int>(56);
binary.Insert(30);
binary.Insert(70);
binary.Insert(22);
binary.Insert(40);
binary.Insert(60);
binary.Insert(95);
binary.Insert(11);
binary.Insert(65);
binary.Insert(3);
binary.Insert(16);
binary.Insert(63);
binary.Insert(67);
binary.Display();
Console.WriteLine(binary.Search(56, binary));