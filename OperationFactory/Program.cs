using OperationFactory;

// 簡單工廠模式 OperationFactory
Product product;
product = Factory.OperationFactoryProduct("X");
string result = product.GetResult();
Console.WriteLine(result);

Console.Read();

/* 工廠模式最主要的精神就是將 new Class 這個動作另外封裝成一個 Factory Class，這個 Factory Class 專門負責實體化這些類別。  */
/* 差別在可以靠變數來決定要實體化的類別 */