using FactoryStrategy;

/*  
    可觀察與OperationFactory差異
    在於減少一個類別的使用(static factory)    
 */
Context context = new Context(Input.A);
context.ContextInterface();
