// See https://aka.ms/new-console-template for more information
using OtusEducationHomework9.Models;

Console.WriteLine("MyCopy product");

var product = new Product(1000);
Console.WriteLine(product);

var copyProduct = product.MyClone();
Console.WriteLine(copyProduct);
copyProduct.Quantity = 2000;
Console.WriteLine(copyProduct);

Console.WriteLine();
Console.WriteLine("Copy spool using MyClone");
var spool = new Spool(1500,750,3500);
Console.WriteLine(spool);

var copySpool = spool.MyClone();
Console.WriteLine(copySpool);
copySpool.Quantity = 2000;
copySpool.Diameter = 600;
copySpool.Height = 2700;
Console.WriteLine(copySpool);

Console.WriteLine();
Console.WriteLine("Copy spool using Clone");

var copySpoolUsingClone = spool.Clone() as Spool;
Console.WriteLine(copySpoolUsingClone);
copySpoolUsingClone.Quantity = 1700;
copySpoolUsingClone.Diameter = 550;
copySpoolUsingClone.Height = 2000;
Console.WriteLine(copySpoolUsingClone);

Console.WriteLine();
Console.WriteLine("Copy grouppack using MyClone");
var grouppack = new GroupPack(1500, 750, 3500, 5);
Console.WriteLine(grouppack);

var copyGrouppack = grouppack.MyClone();
Console.WriteLine(copyGrouppack);
copyGrouppack.Quantity = 2000;
copyGrouppack.Diameter = 600;
copyGrouppack.Height = 2700;
copyGrouppack.CountSpools = 4;
Console.WriteLine(copyGrouppack);

Console.WriteLine();
Console.WriteLine("Copy grouppack using Clone");

var copyGrouppackUsingClone = grouppack.Clone() as GroupPack;
Console.WriteLine(copyGrouppackUsingClone);
copyGrouppackUsingClone.Quantity = 1700;
copyGrouppackUsingClone.Diameter = 550;
copyGrouppackUsingClone.Height = 2000;
copyGrouppackUsingClone.CountSpools = 3;
Console.WriteLine(copyGrouppackUsingClone);