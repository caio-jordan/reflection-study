# Reflection

Reflection (ou reflexão) é uma técnica poderosa em .NET que permite a um programa examinar e manipular seu próprio código em tempo de execução. Isso inclui acessar informações sobre tipos, métodos, propriedades e eventos, além de instanciar objetos e invocar métodos dinamicamente. Com reflection, um programa pode até modificar comportamentos ou criar objetos de tipos desconhecidos no momento da compilação.
Como funciona a Reflection em .NET?
Em .NET, a reflection é baseada no namespace System.Reflection, que fornece classes e métodos para acessar a metadata (metadados) de um programa. Esses metadados são informações sobre o programa em si, como o nome de suas classes, seus métodos, atributos e propriedades. Eles são embutidos no código compilado, permitindo que o .NET acesse e trabalhe com essas informações em tempo de execução.
Por exemplo, ao usar reflection, um programa consegue:
Obter tipos e membros: Recuperar tipos (Type), incluindo classes, interfaces e estruturas, assim como acessar seus membros, como métodos (MethodInfo), propriedades (PropertyInfo), campos (FieldInfo), e eventos.
Instanciar objetos dinamicamente: Criar instâncias de tipos usando reflection, mesmo quando o tipo é desconhecido até o momento da execução, usando o método Activator.CreateInstance.
Invocar métodos dinamicamente: Executar métodos de um objeto com o método Invoke, usando seu nome ou sua definição em tempo de execução.
Trabalhar com atributos personalizados: Usar reflection para ler atributos customizados, que são metadados adicionais adicionados ao código, permitindo configurações dinâmicas ou validações específicas.
Exemplos práticos de uso
Reflection é amplamente utilizada em frameworks e ferramentas que exigem flexibilidade e personalização. Exemplos incluem:

- Serialização: Ferramentas que convertem objetos para JSON ou XML precisam identificar propriedades dinamicamente, especialmente quando lidam com tipos complexos ou desconhecidos.

- Injeção de dependências: Frameworks de IoC (Inversion of Control) criam instâncias de classes dinamicamente e injetam dependências usando reflection.

- Testes automatizados: Frameworks de testes, como NUnit, utilizam reflection para identificar métodos de teste e atributos associados para execução automatizada.

-  Ferramentas de desenvolvimento: IDEs e depuradores usam reflection para exibir informações sobre tipos e membros para os desenvolvedores.

Desempenho e segurança
Embora reflection seja extremamente poderosa, ela pode ser custosa em termos de desempenho, pois requer acesso a metadados e operações adicionais em tempo de execução. Além disso, como reflection permite manipular aspectos internos de uma aplicação, seu uso deve ser feito com cuidado para evitar riscos de segurança, como acessos não autorizados a membros privados.
