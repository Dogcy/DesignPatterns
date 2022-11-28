using TemplateMethod;

/*模板模式 TemplateMethod*/
ClassAbstract c;
c = new ConcreteClassA();
c.TemplateMethod();


c = new ConcreteClassB();
c.TemplateMethod();

c = new ConcreteClassc();
c.TemplateMethod();
