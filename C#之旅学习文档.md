# C# 之旅（A Tour of C#）

> 整理自微软官方 Microsoft Learn 文档，内容忠实保留原文。
> 原始入口：<https://learn.microsoft.com/zh-cn/dotnet/csharp/tour-of-csharp/>
> 整理日期：2026-08-19

## 目录

1. [C# 语言介绍](#C-语言介绍) — 原文：https://learn.microsoft.com/zh-cn/dotnet/csharp/tour-of-csharp/overview
2. [C# 语言策略（注释版）](#C-语言策略注释版) — 原文：https://learn.microsoft.com/zh-cn/dotnet/csharp/tour-of-csharp/strategy
3. [使用 C# 可以构建的内容](#使用-C-可以构建的内容) — 原文：https://learn.microsoft.com/zh-cn/dotnet/csharp/tour-of-csharp/what-you-can-build
4. [教程：探索 C# 语言（Hello World 入门）](#教程：探索-C-语言Hello-World-入门) — 原文：https://learn.microsoft.com/zh-cn/dotnet/csharp/tour-of-csharp/tutorials/hello-world
5. [Java 开发者学习 C# 的路线图](#Java-开发者学习-C-的路线图) — 原文：https://learn.microsoft.com/zh-cn/dotnet/csharp/tour-of-csharp/tips-for-java-developers
6. [JavaScript 和 TypeScript 开发者学习 C# 的路线图](#JavaScript-和-TypeScript-开发者学习-C-的路线图) — 原文：https://learn.microsoft.com/zh-cn/dotnet/csharp/tour-of-csharp/tips-for-javascript-developers
7. [Python 开发者学习 C# 的路线图](#Python-开发者学习-C-的路线图) — 原文：https://learn.microsoft.com/zh-cn/dotnet/csharp/tour-of-csharp/tips-for-python-developers

---

## C# 语言介绍
本文简要概述了 C# 语言。 无论你是编写第一个程序还是一位经验丰富的开发人员探索 C# ，你都会在这里找到关键概念和功能。

提示

**编程新手？** 浏览本文以大概了解，然后开始 [初学者教程](https://learn.microsoft.com/zh-cn/dotnet/csharp/tour-of-csharp/tutorials/)，动手写代码。

**来自 Java、JavaScript 或 Python？** 阅读本文旁边的 [Java](https://learn.microsoft.com/zh-cn/dotnet/csharp/tour-of-csharp/tips-for-java-developers)、 [JavaScript](https://learn.microsoft.com/zh-cn/dotnet/csharp/tour-of-csharp/tips-for-javascript-developers) 或 [Python](https://learn.microsoft.com/zh-cn/dotnet/csharp/tour-of-csharp/tips-for-python-developers) 开发人员的提示。

**经验丰富但对 C# 仍然新手的开发人员？** 本文介绍 C# 的独特之处。 请参阅 [使用 C# 构建的内容](https://learn.microsoft.com/zh-cn/dotnet/csharp/tour-of-csharp/what-you-can-build) ，以查找符合目标的工作负荷。

C# 语言是适用于 [.NET](https://learn.microsoft.com/zh-cn/dotnet/csharp/) 平台（免费的跨平台开源开发环境）的最流行语言。 C# 程序可以在许多不同的设备上运行，从物联网 (IoT) 设备到云以及介于两者之间的任何设备。 可为手机、台式机、笔记本电脑和服务器编写应用。 有关应用程序类型的概述，请参阅 [可以使用 C# 生成的内容](https://learn.microsoft.com/zh-cn/dotnet/csharp/tour-of-csharp/what-you-can-build) 。

C# 是一种跨平台的通用语言，可以让开发人员在编写高性能代码时提高工作效率。 C# 在生态系统和许多 [工作负载](https://learn.microsoft.com/zh-cn/dotnet/standard/glossary#workload)方面具有广泛的支持。 基于面向对象的原则，它融合了其他范例中的许多功能，尤其是函数编程。 低级功能支持高效方案，无需编写不安全的代码。 大多数运行时和库都是用 C# 编写的，C# 中的进步通常有利于所有 .NET 开发人员。

C# 属于 C 语言家族。 如果使用 C、C++、JavaScript、TypeScript 或 Java，则 C[# 语法](https://learn.microsoft.com/zh-cn/dotnet/csharp/language-reference/keywords/)很熟悉。 与 C 和 C++ 一样，分号 （`;`） 定义语句的末尾。 C# 标识符区分大小写。 C# 使用相同的大括号， `{` 以及 `}`控件语句（如 `if`、 `else`和 `switch`）循环构造（如 `for` 和 `while`）。 C# 还具有适用于任何集合类型的 `foreach` 语句。

### Hello World

“Hello， World”程序传统上引入了编程语言。 下面是 C# 中的程序：
    
    
    // This line prints "Hello, World"
    Console.WriteLine("Hello, World");
    

以 `//` 开头的行是单行注释。 C# 单行注释以`//` 开头，持续到当前行的末尾。 C# 还支持多行注释。 多行注释以`/*` 开头，以 `*/` 结尾。 System 命名空间中的 Console 类的 WriteLine 方法生成程序的输出。 标准类库提供此类，默认情况下，每个 C# 程序都会自动引用这些库。 另一种程序形式要求你声明程序入口点所在的类和方法。 使用顶级语句时，编译器会合成这些元素。

此替代格式仍然有效，并且包含所有 C# 程序中的许多基本概念。 许多现有的 C# 示例使用以下等效格式：
    
    
    using System;
    ﻿namespace TourOfCsharp;
    
    class Program
    {
        static void Main()
        {
            // This line prints "Hello, World" 
            Console.WriteLine("Hello, World");
        }
    }
    

前面的“Hello, World”程序以 `using` 指令开头，该指令用于引用 `System` 命名空间。 命名空间提供了一种用于组织 C# 程序和库的分层方法。 命名空间包含类型和其他命名空间。 例如，命名空间 `System` 包含许多类型，例如 `Console` 程序中引用的类，以及许多其他命名空间，例如 `IO` 和 `Collections`。 借助引用给定命名空间的 `using` 指令，可以非限定的方式使用作为相应命名空间成员的类型。 由于使用 `using` 指令，因此程序可以使用 `Console.WriteLine` 作为 `System.Console.WriteLine` 的简写。 在前面的示例中，该命名空间是[隐式](https://learn.microsoft.com/zh-cn/dotnet/csharp/language-reference/keywords/using-directive#the-global-modifier)包含的。

注释

前面的程序声明 `Program` 具有单个成员的类：名为 `Main` 的方法。 许多现有的 C# 示例和教程都使用此格式。 按照约定，如果没有顶级语句，则名为 `Main` 静态方法作为 C# 程序的 [入口点](https://learn.microsoft.com/zh-cn/dotnet/csharp/fundamentals/program-structure/main-command-line) 。 这两种格式都编译为同一代码。 无需使用这种文件格式——文件应用和高级别语句是更简单的起步方法。

### 基于文件的应用

C# 是 _一种已编译_ 的语言。 在大多数 C# 程序中，使用 [`dotnet build`](https://learn.microsoft.com/zh-cn/dotnet/core/tools/dotnet-build) 命令将一组源文件编译为二进制包。 然后，使用 [`dotnet run`](https://learn.microsoft.com/zh-cn/dotnet/core/tools/dotnet-run) 命令运行程序。 可以简化此过程，因为 `dotnet run` 会在必要时先编译程序然后运行。 这些工具支持丰富的配置选项和命令行参数语言。 . `dotnet` NET SDK 中包含的命令行接口（CLI）提供了许多 [工具来](https://learn.microsoft.com/zh-cn/dotnet/core/tools/) 生成和修改 C# 文件。

从 C# 14 和 .NET 10 开始，可以创建 _基于文件的应用_ ，从而简化 C# 程序的生成和运行。 使用 `dotnet run` 命令运行包含在单个 `*.cs` 文件中的程序。 例如，如果以下代码存储在名为 `hello-world.cs` 的文件中，可以通过键入 `dotnet run hello-world.cs` 来运行它。
    
    
    #!/usr/bin/env dotnet
    
    Console.WriteLine("Hello, World!");
    

程序的第一行包含 Unix 操作系统的 `#!` 序列 (shebang)。 这样就可以在对文件设置 _执行_ 权限`+x`时直接使用文件名称执行文件。 例如，可以直接从命令行运行 C# 文件：
    
    
    ./hello-world.cs
    

这些程序的源必须是单个文件，否则所有 C# 语法都有效。 可以将基于文件的应用用于小型命令行实用工具、原型或其他试验。

### 熟悉的 C# 功能

C# 对于初学者而言很容易上手，但同时也为经验丰富的专业应用程序开发人员提供了高级功能。 你很快就能提高工作效率。 你可以根据应用程序的需要学习更专业的技术。

C# 应用受益于运行时的 [自动内存管理](https://learn.microsoft.com/zh-cn/dotnet/standard/automatic-memory-management)。 C# 应用还可以使用 .NET SDK 提供的丰富[运行时库](https://learn.microsoft.com/zh-cn/dotnet/standard/runtime-libraries-overview)。 有些组件独立于平台，例如文件系统库、数据集合与数学库。 其他工作负荷特定于单个 [工作负荷](https://learn.microsoft.com/zh-cn/dotnet/csharp/tour-of-csharp/what-you-can-build)，例如 ASP.NET 核心 Web 库或 .NET MAUI UI 库。 [NuGet](<https://nuget.org>) 上的一个丰富的开放源代码生态系统可增强作为运行时一部分的库。 这些库提供更多可用的组件。

C# 是一种强类型语言。 声明的每个变量都有一个在编译时已知的类型。 编译器或编辑工具会告诉你是否错误地使用了该类型。 可以在运行程序之前修复这些错误。 以下[基础数据类型](https://learn.microsoft.com/zh-cn/dotnet/csharp/fundamentals/types/)内置于语言和运行时中：值类型（例如 `int`、`double`、`char`）、引用类型（例如 `string`）、数组和其他集合。 编写程序时，你会创建自己的类型。 这些类型可以是值的 `struct` 类型，也可以是定义面向对象的行为的 `class` 类型。 可以将 `record` 修饰符添加到 `struct` 或 `class` 类型，以便编译器合成用于执行相等性比较的代码。 还可以创建 `interface` 定义，用于定义实现该接口的类型必须提供的协定或一组成员。 还可以定义泛型类型和方法。 [泛型](https://learn.microsoft.com/zh-cn/dotnet/csharp/fundamentals/types/generics)使用类型参数为使用的实际类型提供占位符。

编写代码时，可以将函数（也称为[方法](https://learn.microsoft.com/zh-cn/dotnet/csharp/programming-guide/classes-and-structs/methods)）定义为 `struct` 和 `class` 类型的成员。 这些方法定义类型的行为。 可以使用不同数量或类型的参数重载方法。 方法可以选择性地返回一个值。 除了方法之外，C# 类型还可以带有[属性](https://learn.microsoft.com/zh-cn/dotnet/csharp/programming-guide/classes-and-structs/properties)，即由称作访问器的函数支持的数据元素。 C# 类型可以定义[事件](https://learn.microsoft.com/zh-cn/dotnet/csharp/events-overview)，从而允许类型向订阅者通知重要操作。 C# 支持面向对象的技术，例如 `class` 类型的继承和多形性。

C# 应用使用[异常](https://learn.microsoft.com/zh-cn/dotnet/csharp/fundamentals/exceptions/)来报告和处理错误。 如果使用C++或 Java，则这种做法很熟悉。 当无法执行预期的操作时，代码会引发异常。 其他代码（无论位于调用堆栈上面的多少个级别）可以选择性地使用 `try` \- `catch` 块进行恢复。

提示

若要详细了解类型、方法和异常，请访问 [C# 基础知识](https://learn.microsoft.com/zh-cn/dotnet/csharp/fundamentals/program-structure/) 部分。 它涵盖 [类型系统](https://learn.microsoft.com/zh-cn/dotnet/csharp/fundamentals/types/)、 [面向对象的编程](https://learn.microsoft.com/zh-cn/dotnet/csharp/fundamentals/object-oriented/)和深度 [异常处理](https://learn.microsoft.com/zh-cn/dotnet/csharp/fundamentals/exceptions/) 。

### 独特的 C# 功能

你可能不太熟悉 C# 的某些元素。

C# 提供[模式匹配](https://learn.microsoft.com/zh-cn/dotnet/csharp/fundamentals/functional/pattern-matching)。 这些表达式使你能够检查数据并根据其特征做出决策。 模式匹配为基于数据的控制流提供了极好的语法。 以下代码演示如何使用模式匹配语法来表达布尔 and、or 和 xor 运算的方法 ______：
    
    
    public static bool Or(bool left, bool right) =>
        (left, right) switch
        {
            (true, true) => true,
            (true, false) => true,
            (false, true) => true,
            (false, false) => false,
        };
    
    public static bool And(bool left, bool right) =>
        (left, right) switch
        {
            (true, true) => true,
            (true, false) => false,
            (false, true) => false,
            (false, false) => false,
        };
    public static bool Xor(bool left, bool right) =>
        (left, right) switch
        {
            (true, true) => false,
            (true, false) => true,
            (false, true) => true,
            (false, false) => false,
        };
    

可以使用 `_` 作为任何值的总括简化模式匹配表达式。 以下示例演示如何简化 and 方法：
    
    
    public static bool ReducedAnd(bool left, bool right) =>
        (left, right) switch
        {
            (true, true) => true,
            (_, _) => false,
        };
    

前面的示例还声明 _元组_ 、轻型数据结构。 _元组_ 是具有可选名称和单个类型的有序固定长度值序列。 将序列括在 `(` 和 `)` 标签中。 声明 `(left, right)` 定义一个元组，其中包含两个布尔值： `left` 和 `right`。 每个 switch 臂都声明元组值，例如 `(true, true)`。 元组提供方便的语法来声明具有任何类型的多个值的单个值。

_集合表达式_ 提供用于提供集合值的通用语法。 在字符之间`[``]`写入值或表达式，编译器将该表达式转换为所需的集合类型：
    
    
    int[] numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
    List<string> names = ["Alice", "Bob", "Charlie", "David"];
    
    IEnumerable<int> moreNumbers = [.. numbers, 11, 12, 13];
    IEnumerable<string> empty = [];
    

前面的示例显示了可以使用集合表达式初始化的不同集合类型。 一个示例使用 `[]` 空集合表达式来声明空集合。 另一个示例使用 `..`_spread 元素_ 展开集合并将其所有值添加到集合表达式。

可以使用 _索引_ 和 _范围_ 表达式从可索引集合中检索一个或多个元素：
    
    
    string second = names[1]; // 0-based index
    string last = names[^1]; // ^1 is the last element
    int[] smallNumbers = numbers[0..5]; // elements at indexes 0 to 4
    

`^` 索引表示 _从末尾_ 而不是从头开始。 `^0` 元素位于集合的末尾之后，因此 `^1` 是最后一个元素。 在范围表达式 `..` 中表示要包含的元素范围。 范围从第一个索引开始，并包含所有元素，直到最后一个索引处的元素（但不包括该元素）。

有关索引和范围表达式的详细信息，请参阅 [“浏览索引和范围”](https://learn.microsoft.com/zh-cn/dotnet/csharp/tutorials/ranges-indexes) 一文。

[语言集成查询 (LINQ)](https://learn.microsoft.com/zh-cn/dotnet/csharp/linq/) 提供一种基于模式的通用语法来查询或转换任何数据集合。 LINQ 统一了查询内存中集合、结构化数据（例如 XML 或 JSON）、数据库存储，甚至基于云的数据 API 的语法。 你只需学习一套语法即可搜索和操作数据，无论其存储在何处。 以下查询查找平均学分大于 3.5 的所有学生：
    
    
    var honorRoll = from student in Students
                    where student.GPA > 3.5
                    select student;
    

上面的查询适用于 `Students` 表示的许多存储类型。 它可以是对象的集合、数据库表、云存储 Blob 或 XML 结构。 相同的查询语法适用于所有存储类型。

使用[基于任务的异步编程模型](https://learn.microsoft.com/zh-cn/dotnet/csharp/asynchronous-programming/)，可以编写看起来像是同步运行的代码，即使它是异步运行的。 它利用 `async` 和 `await` 关键字来描述异步方法，以及表达式何时进行异步计算。 以下示例等待异步 Web 请求。 异步操作完成后，该方法返回响应的长度：
    
    
    public static async Task<int> GetPageLengthAsync(string endpoint)
    {
        var client = new HttpClient();
        var uri = new Uri(endpoint);
        byte[] content = await client.GetByteArrayAsync(uri);
        return content.Length;
    }
    

C# 还支持使用 `await foreach` 语句来迭代由异步操作支持的集合，例如 GraphQL 分页 API。 以下示例以块的形式读取数据，并返回一个迭代器，该迭代器提供对每个可用元素的访问：
    
    
    public static async IAsyncEnumerable<int> ReadSequence()
    {
        int index = 0;
        while (index < 100)
        {
            int[] nextChunk = await GetNextChunk(index);
            if (nextChunk.Length == 0)
            {
                yield break;
            }
            foreach (var item in nextChunk)
            {
                yield return item;
            }
            index++;
        }
    }
    

调用方可以使用 `await foreach` 语句遍历集合：
    
    
    await foreach (var number in ReadSequence())
    {
        Console.WriteLine(number);
    }
    

最后，作为.NET生态系统的一部分，可以将[Visual Studio](<https://visualstudio.microsoft.com/vs>)或[Visual Studio Code](<https://code.visualstudio.com>)与 [C# 开发工具包](<https://code.visualstudio.com/docs/csharp/get-started>)配合使用。 这些工具提供了对 C# 的丰富理解，包括你编写的代码。 它们还提供调试功能。

提示

若要详细了解模式匹配、LINQ 和异步编程，请参阅 [功能技术](https://learn.microsoft.com/zh-cn/dotnet/csharp/fundamentals/functional/pattern-matching)、 [LINQ 概述](https://learn.microsoft.com/zh-cn/dotnet/csharp/linq/)和 [异步编程](https://learn.microsoft.com/zh-cn/dotnet/csharp/asynchronous-programming/) 部分。

### 后续步骤

本文提供了 C# 语言的快速教程。 根据您的经验，接下来可以去的地方是：

  * **开始编码** ：逐步学习 [C# 初学者教程](https://learn.microsoft.com/zh-cn/dotnet/csharp/tour-of-csharp/tutorials/) 。
  * **更深入** ：访问 [C# 基础知识](https://learn.microsoft.com/zh-cn/dotnet/csharp/fundamentals/program-structure/) 部分，详细了解类型系统、面向对象的编程和错误处理。
  * **构建内容** ：探索 [可使用 C# 构建的内容](https://learn.microsoft.com/zh-cn/dotnet/csharp/tour-of-csharp/what-you-can-build) ，以查找感兴趣的想法。
  * **来自另一种语言？** 阅读适用于 [Java](https://learn.microsoft.com/zh-cn/dotnet/csharp/tour-of-csharp/tips-for-java-developers)、[JavaScript](https://learn.microsoft.com/zh-cn/dotnet/csharp/tour-of-csharp/tips-for-javascript-developers) 或 [Python](https://learn.microsoft.com/zh-cn/dotnet/csharp/tour-of-csharp/tips-for-python-developers) 开发人员的指南。
  * **生成基于文件的应用** ：了解如何为小型程序和原型 [生成基于文件的应用](https://learn.microsoft.com/zh-cn/dotnet/csharp/fundamentals/tutorials/file-based-programs) 。

---

## 带批注的 C# 策略
小窍门

本文最适用于想要了解 C# 设计理念的专业人员和学生以及语言的发展方式。 如果你不熟悉 C#，请改为学习 [C#](https://learn.microsoft.com/zh-cn/dotnet/csharp/tour-of-csharp/overview) 或 [初学者教程](https://learn.microsoft.com/zh-cn/dotnet/csharp/tour-of-csharp/tutorials/) 。

我们将不断改进 C# 以满足开发人员不断变化的需求，并保持最先进的编程语言。 我们将积极而广泛地进行创新，与负责 .NET 库、开发人员工具和工作负载支持的团队密切合作，同时谨慎地遵循语言的精神。 认识到正在使用 C# 的域的多样性，我们更喜欢有利于所有或大多数开发人员的语言和性能改进，并保持对向后兼容性的高度承诺。 我们将继续为更广泛的 .NET 生态系统提供支持，并在 C# 的未来中扩大其作用，同时保持设计决策的管理。

### 战略如何指导 C#

C# 策略指导我们对 C# 演变的决策，这些注释提供有关我们如何思考关键语句的见解。

> “我们将急切和广泛地创新”

C# 社区继续增长，C# 语言继续发展，以满足社区的需求和期望。 我们从许多来源中汲取灵感，以选择有利于大量 C# 开发人员的功能，并在工作效率、可读性和性能方面提供一致的改进。

> “小心翼翼地遵循语言精神”

我们在 C# 语言的理念和历史背景下评价新想法。 我们优先考虑对大多数现有 C# 开发人员有意义的创新。

> “使所有或大多数开发人员受益的改进”

开发人员在所有 .NET [工作负载](https://learn.microsoft.com/zh-cn/dotnet/csharp/tour-of-csharp/what-you-can-build)中使用 C# 。 开发人员使用 C# 构建 Web 前端和后端、云原生应用和桌面应用。 C# 支持跨平台应用程序。 我们专注于那些最直接产生影响的新功能，或者通过对通用库进行改进来增强其效果。 语言功能开发包括集成到我们的开发人员工具和学习资源中。

> “高度致力于向后兼容性”

我们尊重目前广泛使用的大量 C# 代码。 对于任何潜在的重大变更，都将仔细考虑其对 C# 社区的破坏规模和影响。

> “维护管理”

[C# 语言设计](<https://github.com/dotnet/csharplang/tree/main/meetings>) 公开进行，与社区共同参与。 任何人都可以在我们的 [GitHub 存储库](<https://github.com/dotnet/csharplang>)中提出新的 C# 功能。 [语言设计团队](<https://github.com/dotnet/csharplang/tree/main/meetings>)在权衡社区意见后做出最终决定。

---

## 你可以用 C# 构建什么
C# 支持各种应用程序类型。 无论要构建哪种类型的软件，它都有一个 [工作负荷](https://learn.microsoft.com/zh-cn/dotnet/standard/glossary#workload) 。 本文概述了最常见的应用程序类型，并提供了每个应用程序入门的链接。

小窍门

**编程新手？** 暂时不用担心选择任务。 首先专注于 [学习 C# 语言](https://learn.microsoft.com/zh-cn/dotnet/csharp/tour-of-csharp/tutorials/) 。 熟悉基础知识后，可以浏览这些应用程序类型。

**经验丰富的开发人员？** 直接跳转到与您的目标匹配的任务。 每个部分都链接到所需的文档和教程。

### AI 和机器学习

C# 与 AI 和机器学习工具集成：

  * **[代理框架](https://learn.microsoft.com/zh-cn/agent-framework/overview/?pivots=programming-language-csharp)** \- 为 Azure、OpenAI、人类、Ollama 等生成代理和工作流。
  * **[Foundry 工具](https://learn.microsoft.com/zh-cn/azure/ai-services/)** \- 访问预先构建的 AI 功能，例如视觉、语言理解和语音识别。
  * **[ML.NET](https://learn.microsoft.com/zh-cn/dotnet/machine-learning/)** \- 在 C# 中生成自定义机器学习模型，而无需具备深入的 ML 专业知识。

入门： [ML.NET 教程](https://learn.microsoft.com/zh-cn/dotnet/machine-learning/)。

### Web 应用程序

使用 [ASP.NET Core](https://learn.microsoft.com/zh-cn/aspnet/core/)（用于创建新式 Web 应用和 API 的跨平台框架）构建 Web 应用程序。 你可以生成：

  * 使用 Razor Pages 或 MVC **服务器端生成的 Web 应用** 。
  * 使用 **Blazor**[进行交互式 Web UI](https://learn.microsoft.com/zh-cn/aspnet/core/blazor/)，使你能够在 C# 而不是 JavaScript 中编写客户端逻辑。
  * **Web API** 和后端服务的 [最小 API](https://learn.microsoft.com/zh-cn/aspnet/core/fundamentals/minimal-apis/overview) 。

入门： [ASP.NET 核心教程](https://learn.microsoft.com/zh-cn/aspnet/core/tutorials)

### 桌面应用程序

使用 C# 生成 Windows 桌面应用，以及在 Windows 和 macOS 上运行的跨平台桌面应用：

  * **[.NET MAUI](https://learn.microsoft.com/zh-cn/dotnet/maui/)** 通过单个代码库创建在 Windows、macOS、Android 和 iOS 上运行的跨平台桌面应用。
  * **[Windows Presentation Foundation（WPF）](https://learn.microsoft.com/zh-cn/dotnet/desktop/wpf/)** 使用高级图形和数据绑定生成丰富的仅限 Windows 的桌面应用。
  * **[Windows 窗体](https://learn.microsoft.com/zh-cn/dotnet/desktop/winforms/)** 提供了使用视觉设计器创建仅限 Windows 的桌面应用的简单方法。

入门： [.NET MAUI 教程](https://learn.microsoft.com/zh-cn/dotnet/maui/get-started/first-app)。

### 移动应用程序

使用 [.NET MAUI](https://learn.microsoft.com/zh-cn/dotnet/maui/) 生成适用于 iOS 和 Android 的本机移动应用。 .NET MAUI 允许跨移动和桌面平台共享代码，同时仍访问相机、传感器、GPS 等的本机设备 API。

入门： [生成第一个 .NET MAUI 应用](https://learn.microsoft.com/zh-cn/dotnet/maui/get-started/first-app)。

### 云和微服务

C# 非常适合用于生成云原生应用程序和微服务：

  * **[Azure SDK for .NET](https://learn.microsoft.com/zh-cn/dotnet/azure/sdk/azure-sdk-for-dotnet)** 提供用于处理 Azure 服务的库，例如存储、消息传送和数据库。
  * **[工作者服务](https://learn.microsoft.com/zh-cn/dotnet/core/extensions/workers)** 让你构建可在云端或本地运行的长时间运行的后台服务。
  * **[Aspire](<https://aspire.dev>)** 简化了生成、运行、部署、调试和部署分布式应用的过程。

入门： [Azure 和 .NET 入门](https://learn.microsoft.com/zh-cn/dotnet/azure/)。

### 游戏

C# 是游戏开发最受欢迎的语言之一：

  * **[Unity](<https://docs.unity3d.com/Manual/index.html>)** \- 2D 和 3D 游戏最常用的游戏引擎，使用 C# 作为其脚本语言。
  * **[MonoGame](<https://docs.monogame.net/?page=main>)** \- 用于创建跨平台游戏的开源框架。
  * **[CryEngine](<https://docs.cryengine.com/display/CEPROG/C%23+Programming>)** \- 支持 C# 进行游戏脚本编写。

还可以使用这些引擎使用 [Visual Studio 进行游戏开发](<https://visualstudio.microsoft.com/vs/features/game-development/?utm_medium=microsoft&utm_source=learn.microsoft.com&utm_campaign=inline+link>) 。

### 物联网 (IoT)

使用 [IoT 库](https://learn.microsoft.com/zh-cn/dotnet/iot/)控制设备和读取传感器数据。 可以在 [Raspberry Pi](https://learn.microsoft.com/zh-cn/dotnet/iot/quickstarts/sensehat) 和其他单板计算机等设备上运行 C# 应用，以生成 IoT 解决方案。

入门： [IoT 教程](https://learn.microsoft.com/zh-cn/dotnet/iot/tutorials/blink-led)

### 后续步骤

了解可以生成的内容后，请选择下一步：

  * **学习语言** ：从 [初学者 C# 教程开始学习 C#](https://learn.microsoft.com/zh-cn/dotnet/csharp/tour-of-csharp/tutorials/) 基础知识。
  * **浏览 C#** ：阅读 [C# 教程](https://learn.microsoft.com/zh-cn/dotnet/csharp/tour-of-csharp/overview) ，大致了解关键语言功能。
  * **深入了解基础知识：请访问**[C# 基础知识](https://learn.microsoft.com/zh-cn/dotnet/csharp/fundamentals/program-structure/) 部分，深入了解类型系统、面向对象的编程等。
  * **来自另一种语言？** 请参阅 [Java](https://learn.microsoft.com/zh-cn/dotnet/csharp/tour-of-csharp/tips-for-java-developers)、 [JavaScript/TypeScript](https://learn.microsoft.com/zh-cn/dotnet/csharp/tour-of-csharp/tips-for-javascript-developers) 或 [Python](https://learn.microsoft.com/zh-cn/dotnet/csharp/tour-of-csharp/tips-for-python-developers) 开发人员的路线图。

---

## 教程：探索 C# 语言
本教程介绍 C# 。 编写第一个 C# 程序，并查看编译和运行代码的结果。 它包含以“Hello World”程序开头的一系列课程。 这些课程介绍了 C# 语言的基础知识。

小窍门

**编程新手？** 从此处开始 - 本教程假定没有以前的经验。 **来自另一种语言？** 你可能更喜欢浏览代码示例，然后跳转到[C#中的数字](https://learn.microsoft.com/zh-cn/dotnet/csharp/tour-of-csharp/tutorials/numbers-in-csharp)或[分支和循环](https://learn.microsoft.com/zh-cn/dotnet/csharp/tour-of-csharp/tutorials/branches-and-loops)。

在本教程中，你将：

  * 使用 C# 开发环境启动 GitHub Codespace。
  * 创建第一个 C# 应用。
  * 创建和使用变量来存储文本数据。
  * 对文本数据使用运行时 API。

### 先决条件

必须具有以下选项之一：

  * 使用 [GitHub Codespaces](<https://github.com/codespaces>) 需要一个 GitHub 帐户。 如果还没有帐户，可以在 [GitHub.com](<https://github.com>) 创建免费帐户。
  * 安装了以下工具的计算机： 
    * [.NET 10 SDK](<https://dotnet.microsoft.com/download/dotnet/10.0>)。
    * [Visual Studio Code](<https://code.visualstudio.com/download>)。
    * [C# DevKit](<https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csdevkit>)。

### 打开 Codespaces

若要使用教程环境启动 GitHub Codespace，请打开 [教程 codespace](<https://github.com/dotnet/tutorial-codespace>) 存储库的浏览器窗口。 选择绿色 _“代码_ ”按钮和 _“代码空间_ ”选项卡。然后选择该 `+` 符号以使用此环境创建新的 Codespace。

### 运行第一个程序

  1. 在代码空间加载时，在名为 _hello-world.cs_ 的 _教程_ 文件夹中创建新文件。

  2. 打开新文件。

  3. 键入或将以下代码复制到 _hello-world.cs_ ：
         
         Console.WriteLine("Hello, World!");
         

  4. 在集成终端窗口中，将 _教程_ 文件夹设为当前文件夹，并运行程序：
         
         cd tutorials
         dotnet hello-world.cs
         

运行了第一个 C# 程序。 这是一个简单的程序，用于打印消息“Hello World！”它使用 [Console.WriteLine](https://learn.microsoft.com/zh-cn/dotnet/api/system.console.writeline) 该方法打印该消息。 `Console` 是表示控制台窗口的类型。 `WriteLine` 是 `Console` 类型中的一种方法，该方法将文本行打印到文本控制台。

让我们继续前进，探索更多。 本课程的其余部分将探讨如何使用类型 `string` ，该类型表示 C# 中的文本。 与类型 `Console` 一样，该 `string` 类型具有方法。 这些 `string` 方法适用于文本。

### 声明和使用变量

你的第一个程序在屏幕上打印 `string` “Hello World！” 。

小窍门

在探索 C#（或任何编程语言）的过程中，可能会在编写代码时犯错。 **编译器** 会找到这些错误并将其报告给你。 当输出包含错误消息时，请仔细查看示例代码和文件中的代码 `.cs` 以查看要修复的内容。 该练习有助于学习 C# 代码的结构。 你还可以要求科皮洛特找出差异或发现错误。

你的第一个程序仅限于打印一条消息。 可以使用 _变量_ 编写更有用的程序。 _变量_ 是可用于运行具有不同值的相同代码的符号。 我们来试一试！

  1. 从以下代码开始：
         
         string aFriend = "Bill";
         Console.WriteLine(aFriend);
         

第一行声明变量， `aFriend`并为其赋值“Bill”。 第二行打印名称。

  2. 可以将不同的值分配给声明的任何变量。 你可以将这个名称改成你一个朋友的名字。 在添加的代码后面添加这两行。 请确保保留变量及其初始赋值声明 `aFriend` 。

重要

请勿删除 `aFriend`的声明。

  3. 在上述代码的末尾添加以下代码：
         
         aFriend = "Maira";
         Console.WriteLine(aFriend);
         

请注意，同一行代码根据变量中 `aFriend` 存储的值打印两条不同的消息。 你可能会注意到最后两条消息中缺少“Hello”一词。 现在我们来解决此问题。

  4. 修改打印消息的代码行如下：
         
         Console.WriteLine("Hello " + aFriend);
         

  5. 再次运行应用，方法是使用 `dotnet hello-world.cs` 以查看结果。

你一直在使用`+`将字符串从**变量** 和**常量** 字符串构建出来。 有更好的方法。 可以在`{`和`}`字符之间放置一个变量，以指示 C# 将该文本替换为变量的值。 此过程称为 [字符串内插](https://learn.microsoft.com/zh-cn/dotnet/csharp/language-reference/tokens/interpolated)。

  6. 如果在字符串的左引号前添加一个 `$` ，则可以在大括号之间的字符串中包含变量，例如 `aFriend`。 试一试：
         
         Console.WriteLine($"Hello {aFriend}");
         

  7. 再次运行应用，方法是使用 `dotnet hello-world.cs` 以查看结果。 消息应为“Hello Maira”，而不是“Hello {aFriend}”。

### 使用字符串

上次编辑是你第一次了解如何使用字符串。 让我们来了解一下。

你可以在大括号之间使用多个变量，而不仅限于单个变量。

  1. 尝试应用底部的以下代码：
         
         string firstFriend = "Maria";
         string secondFriend = "Sage";
         Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");
         

字符串不仅仅是字母集合。 可以使用 `Length` 查找字符串的长度。 `Length` 是字符串 **的属性** ，它返回该字符串中的字符数。

  2. 在应用底部添加以下代码：
         
         Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
         Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");
         

小窍门

现在是自己探索的好时机。 你已了解到 `Console.WriteLine()` 会将文本输出到屏幕。 你了解了如何声明变量并连接字符串。 尝试在代码中进行实验。 编辑器具有一个名为 _IntelliSense_ 的功能，可以为您提供可执行操作的建议。 在`.`中的`d`之后键入一个`firstFriend`。 可以看到可用于的属性和方法的建议列表。

一直在使用方法 __[Console.WriteLine](https://learn.microsoft.com/zh-cn/dotnet/api/system.console.writeline) 打印消息。 _方法_ 是执行某些动作的代码块。 它有一个名称，因此你可以访问它。

小窍门

**了解更多信息：** 深入了解 [字符串](https://learn.microsoft.com/zh-cn/dotnet/csharp/programming-guide/strings/) ，或阅读 C# 基础知识部分中 [的方法和程序结构](https://learn.microsoft.com/zh-cn/dotnet/csharp/fundamentals/program-structure/) 。

### 从字符串中删除空格

假设您的字符串中有您不想显示的前导或尾随空格。 你想要 **去除** 字符串两端的空格。 该 [Trim](https://learn.microsoft.com/zh-cn/dotnet/api/system.string.trim) 方法和相关的 [TrimStart](https://learn.microsoft.com/zh-cn/dotnet/api/system.string.trimstart) 方法及 [TrimEnd](https://learn.microsoft.com/zh-cn/dotnet/api/system.string.trimend) 方法一起执行此任务。 使用这些方法可删除前导空格和尾随空格。

  1. 请尝试以下代码：
         
         string greeting = "      Hello World!       ";
         Console.WriteLine($"[{greeting}]");
         
         string trimmedGreeting = greeting.TrimStart();
         Console.WriteLine($"[{trimmedGreeting}]");
         
         trimmedGreeting = greeting.TrimEnd();
         Console.WriteLine($"[{trimmedGreeting}]");
         
         trimmedGreeting = greeting.Trim();
         Console.WriteLine($"[{trimmedGreeting}]");
         

方括号`[`和`]`有助于你直观地理解`Trim`、`TrimStart`和`TrimEnd`方法的作用。 括号显示空格开始和结束的位置。

此示例强化了使用字符串的几个重要概念。 处理字符串的方法返回新的字符串对象，而不是在原地进行修改。 可以看到，每次调用任何 `Trim` 方法都会返回一个新字符串，但不会更改原始消息。

### 在字符串中搜索和替换文本

可以使用其他方法处理字符串。 例如，可以在编辑器或字处理器中使用搜索和替换命令。 该方法 [Replace](https://learn.microsoft.com/zh-cn/dotnet/api/system.string.replace) 在字符串中执行类似操作。 它搜索子字符串并将其替换为不同的文本。 该方法 [Replace](https://learn.microsoft.com/zh-cn/dotnet/api/system.string.replace) 采用两 **个参数** 。 这些参数是括号之间的字符串。 第一个字符串是要搜索的文本。 第二个字符串是用于替换的文本。 试试吧。

  1. 添加此代码。 当你在 `.Re` 变量后面开始键入 `sayHello` 时，键入它以查看提示：
         
         string sayHello = "Hello World!";
         Console.WriteLine(sayHello);
         sayHello = sayHello.Replace("Hello", "Greetings");
         Console.WriteLine(sayHello);
         

另外两个有用的方法使字符串全部大写或全部小写。 请尝试以下代码。

  2. 在你开始键入 ****时，键入它以查看`To` IntelliSense 如何提供提示：
         
         Console.WriteLine(sayHello.ToUpper());
         Console.WriteLine(sayHello.ToLower());
         

_搜索和替换_ 作的另一部分是查找字符串中的文本。 可以使用该方法 [Contains](https://learn.microsoft.com/zh-cn/dotnet/api/system.string.contains) 进行搜索。 它会告诉你一个字符串是否包含某个子字符串。

  3. 请尝试以下代码来浏览 [Contains](https://learn.microsoft.com/zh-cn/dotnet/api/system.string.contains)：
         
         string songLyrics = "You say goodbye, and I say hello";
         Console.WriteLine(songLyrics.Contains("goodbye"));
         Console.WriteLine(songLyrics.Contains("greetings"));
         

该方法 [Contains](https://learn.microsoft.com/zh-cn/dotnet/api/system.string.contains) 返回一个 _布尔_ 值，该值指示是否找到要搜索的字符串。 布尔值存储 __或`true`两种值。 当显示为文本输出时，它们将分别大写： `True` 和 `False`。 后续的课程会讲解更多关于 _布尔_ 值的内容。

### 挑战

两种类似的方法，[StartsWith](https://learn.microsoft.com/zh-cn/dotnet/api/system.string.startswith) 和 [EndsWith](https://learn.microsoft.com/zh-cn/dotnet/api/system.string.endswith)，也用于在字符串中搜索子字符串。 这些方法在字符串的开头或末尾查找子字符串。 尝试修改上一个示例以使用 [StartsWith](https://learn.microsoft.com/zh-cn/dotnet/api/system.string.startswith) ， [EndsWith](https://learn.microsoft.com/zh-cn/dotnet/api/system.string.endswith) 而不是 [Contains](https://learn.microsoft.com/zh-cn/dotnet/api/system.string.contains)。 搜索字符串开头是否有“You”或“goodbye”。 在字符串末尾搜索“hello”或“goodbye”。

注释

在测试字符串末尾的文本时，请注意标点符号。 如果字符串以句点结尾，必须检查是否有以句点结尾的字符串。

你应该对于以"You"开始并以"hello"结尾的情况使用`true`，而对于以“再见”开始或结尾的情况使用`false`。

你是否想出了类似于以下代码的内容（展开以查看答案）：
    
    
    string songLyrics = "You say goodbye, and I say hello";
    Console.WriteLine(songLyrics.StartsWith("You"));
    Console.WriteLine(songLyrics.StartsWith("goodbye"));
    
    Console.WriteLine(songLyrics.EndsWith("hello"));
    Console.WriteLine(songLyrics.EndsWith("goodbye"));
    

若要阅读更多关于`string` 类型的信息，请参阅：

  * [有关字符串的 C# 编程指南文章](https://learn.microsoft.com/zh-cn/dotnet/csharp/programming-guide/strings/)。
  * [关于处理字符串的操作提示](https://learn.microsoft.com/zh-cn/dotnet/csharp/how-to/#working-with-strings)。

### 清理资源

GitHub 会在 30 天不活动后自动删除 Codespace。 如果打算探索本系列中的更多教程，您可以保留 Codespace 配置。 如果已准备好访问 [.NET 站点](<https://dotnet.microsoft.com/download/dotnet>) 来下载 .NET SDK，则可以删除 Codespace。 若要删除 Codespace，请打开浏览器窗口并导航到 [Codespaces](<https://github.com/codespaces>)。 应该会在窗口中看到代码空间的列表。 在学习教程代码空间的条目中选择三个点（`...`），然后选择“delete”。

### 后续步骤

继续学习本系列教程中的下一篇教程，或探索 C# 基础知识中的相关主题：

[探索 C# 中的数字](https://learn.microsoft.com/zh-cn/dotnet/csharp/tour-of-csharp/tutorials/numbers-in-csharp)

  * [字符串](https://learn.microsoft.com/zh-cn/dotnet/csharp/programming-guide/strings/) \- 详细了解 `string` 本教程中使用的类型。
  * [方法和程序结构](https://learn.microsoft.com/zh-cn/dotnet/csharp/fundamentals/program-structure/) \- 了解如何组织 C# 程序。
  * [基于文件的应用](https://learn.microsoft.com/zh-cn/dotnet/csharp/fundamentals/tutorials/file-based-programs) \- 了解 `dotnet run` 用于运行代码的命令。

---

## Java 开发者学习 C# 的路线图
如果要开始新工作或加入使用 C# 的团队，本文可帮助你快速提高工作效率。 它突出显示了 Java 中熟悉的内容以及 C# 中的新增功能。

C# 和 Java 有许多相似之处。 学习 C# 时，可以应用许多已经掌握的 Java 编程知识：

  1. 类似的语法：Java 和 C# 都属于 C 语言系列 。 这种相似性意味着你已经可以阅读并理解 C#。 虽然存在一些差异，但大部分语法与 Java 和 C 相同。大括号和分号的用法类似。`if`、`else`、`switch` 等控制语句相同。 循环语句 `for`、`while` 和 `do`...`while` 相同。 在两种语言中，`class` 和 `interface` 的关键字相同。 `public` 到 `private` 的访问修饰符是相同的。 即使是许多内置类型也使用相同的关键字： `int`， `string`和 `double`。
  2. 面向对象的范例：Java 和 C# 都是面向对象的语言 。 多形性、抽象和封装的概念在这两种语言中都适用。 两种语言都添加了新构造，但核心功能仍然相关。
  3. 强类型化：Java 和 C# 都是强类型化语言 。 可以显式或隐式声明变量的数据类型。 编译器会强制执行类型安全性。 在运行代码之前，编译器会捕获代码中与类型相关的错误。
  4. 跨平台：Java 和 C# 都是跨平台语言 。 你可以在喜欢的平台上运行开发工具。 应用程序可以在多个平台上运行。 开发平台不需要与目标平台匹配。
  5. 异常处理：Java 和 C# 都通过引发异常来指示错误 。 两者都使用`try` \- `catch` \- `finally` 块来处理异常。 异常类具有类似的名称和继承层次结构。 一个区别是，C# 没有“已检查的异常”的概念。 在理论上，任何函数都可能引发任何异常。
  6. 标准库：.NET 运行时和 Java 标准库 (JSL) 支持常见任务 。 两者都有适用于其他开源包的广泛生态系统。 在 C# 中，包管理器是[NuGet](<https://www.nuget.org>)。 它类似于 Maven。
  7. 垃圾回收：这两种语言都通过垃圾回收来应用自动内存管理功能 。 运行时从不再被引用的对象中回收内存。 一个区别在于，C# 支持创建值类型，就像`struct` 类型一样。

### 语法一目了然

以下示例并排显示了一些常见模式。 这些比较并不详尽，但它们可让你快速了解语法差异。

**变量声明和类型推理：**
    
    
    // Java
    var name = "Hello";
    final int count = 5;
    
    
    
    // C#
    var name = "Hello";
    const int count = 5;
    

**字符串内插：**
    
    
    // Java
    var message = "Hello, " + name + "! Count: " + count;
    
    
    
    // C#
    var message = $"Hello, {name}! Count: {count}";
    

了解详细信息： [字符串内插](https://learn.microsoft.com/zh-cn/dotnet/csharp/language-reference/tokens/interpolated)

**Lambda 表达式：**
    
    
    // Java
    list.stream().filter(x -> x > 5).collect(Collectors.toList());
    
    
    
    // C#
    var result = list.Where(x => x > 5).ToList();
    

了解详细信息： [LINQ 概述](https://learn.microsoft.com/zh-cn/dotnet/csharp/linq/)

**空值处理：**
    
    
    // Java
    String value = optional.orElse("default");
    
    
    
    // C#
    string value = input ?? "default";
    

了解详细信息：[可空引用类型](https://learn.microsoft.com/zh-cn/dotnet/csharp/fundamentals/null-safety/nullable-reference-types)

### 熟悉的事物

由于相似性，几乎可以立即在 C# 中高效工作。 在进阶过程中，了解 C# 中存在而 Java 中没有的功能和惯用法：

  1. [模式匹配 ](https://learn.microsoft.com/zh-cn/dotnet/csharp/fundamentals/functional/pattern-matching)：模式匹配可以根据复杂数据结构的形状提供简洁的条件语句和表达式。[ `is` 语句](https://learn.microsoft.com/zh-cn/dotnet/csharp/language-reference/operators/is)检查变量“是否”为某种模式。 基于模式的 [`switch` 表达式](https://learn.microsoft.com/zh-cn/dotnet/csharp/language-reference/operators/switch-expression)提供了丰富的语法来检查变量并根据其特征做出决策。
  2. [字符串插值 ](https://learn.microsoft.com/zh-cn/dotnet/csharp/language-reference/tokens/interpolated)和[原始字符串字面量 ](https://learn.microsoft.com/zh-cn/dotnet/csharp/language-reference/builtin-types/reference-types#string-literals)：字符串插值使你能够在字符串中插入已评估的表达式，而不是使用位置标识符。 原始字符串字面量可用于最小化文本中的转义序列。
  3. [ _**可以为 null 的类型和不可为 null 的类型**_](https://learn.microsoft.com/zh-cn/dotnet/csharp/fundamentals/null-safety/nullable-reference-types)：C# 支持 _可以为 null 的值类型_ 和 _可以为 null 的引用类型_ ，方法是在类型后附加 `?` 后缀。 对于可以为 null 的类型，如果在取消引用表达式之前不检查是否有 `null`，编译器会发出警告。 对于不可为 null 的类型，如果向该变量分配 `null` 值，编译器会发出警告。 不可为 null 的引用类型可最大程度减少引发 [System.NullReferenceException](https://learn.microsoft.com/zh-cn/dotnet/api/system.nullreferenceexception) 的编程错误。
  4. [ _**扩展**_](https://learn.microsoft.com/zh-cn/dotnet/csharp/programming-guide/classes-and-structs/extension-methods)：在 C# 中，可以创建 _扩展_ 类或接口的成员。 扩展为库中的类型或实现给定接口的所有类型提供新行为。
  5. [LINQ ](https://learn.microsoft.com/zh-cn/dotnet/csharp/linq/)：语言集成查询 (LINQ) 提供了一种通用语法来查询和转换数据，无论其存储方式如何。
  6. [本地函数 ](https://learn.microsoft.com/zh-cn/dotnet/csharp/programming-guide/classes-and-structs/local-functions)：在 C# 中，可以在方法或其他本地函数内嵌套函数。 本地函数提供另一层封装。

小窍门

若要详细了解 C# 的类型系统（包括 `struct` 与 `class`、记录和接口），请访问“基础知识 [”部分中的类型系统](https://learn.microsoft.com/zh-cn/dotnet/csharp/fundamentals/types/) 概述。

C# 中还有一些 Java 中没有的功能。 特性比如使用顺序语法对异步操作进行[`async` 和 `await`](https://learn.microsoft.com/zh-cn/dotnet/csharp/asynchronous-programming/) 建模。 该 [`using`](https://learn.microsoft.com/zh-cn/dotnet/csharp/language-reference/statements/using) 语句自动释放非内存资源。

C# 和 Java 之间还有一些类似的功能存在细微但重要的差异：

  1. [属性 ](https://learn.microsoft.com/zh-cn/dotnet/csharp/programming-guide/classes-and-structs/properties)和[索引器 ](https://learn.microsoft.com/zh-cn/dotnet/csharp/programming-guide/indexers)：属性和索引器（将类视为数组或字典）都具有语言支持。 在 Java 中，它们是以`get` 和 `set` 开头的方法命名约定。
  2. [记录 ](https://learn.microsoft.com/zh-cn/dotnet/csharp/fundamentals/types/records)：在 C# 中，记录可以是`class`（引用）类型，也可以是 `struct`（值）类型。 C# 记录可以是不可变的，但并非必须是不可变的。
  3. [ _**元组**_](https://learn.microsoft.com/zh-cn/dotnet/csharp/language-reference/builtin-types/value-tuples)在 C# 和 Java 中具有不同的语法。
  4. [属性 ](https://learn.microsoft.com/zh-cn/dotnet/csharp/language-reference/attributes/general)类似于 Java 注释。

最后，有一些 Java 语言功能在 C# 中不可用：

  1. 已检查的异常 ：在 C# 中，理论上任何方法都可能引发任何异常。
  2. 已检查的数组协变 ：在 C# 中，数组不是安全协变的。 如果需要协变结构，则应使用泛型集合类和接口。

总的来说，有 Java 经验的开发者学习 C# 应该会很顺利。 C# 有足够的熟悉的成语，让你在学习新的成语时保持高效。

### 后续步骤

  * [C# 教程](https://learn.microsoft.com/zh-cn/dotnet/csharp/tour-of-csharp/overview)：大致了解所有 C# 功能。
  * [初学者教程](https://learn.microsoft.com/zh-cn/dotnet/csharp/tour-of-csharp/tutorials/)：使用交互式课程逐步学习 C# 。
  * [可以使用 C# 生成的内容](https://learn.microsoft.com/zh-cn/dotnet/csharp/tour-of-csharp/what-you-can-build)：探索可以使用 C# 创建的应用程序类型。
  * [C# 基础知识](https://learn.microsoft.com/zh-cn/dotnet/csharp/fundamentals/program-structure/)：深入了解类型系统、面向对象的编程等。

---

## JavaScript 和 TypeScript 开发者学习 C# 的路线图
如果你正在加入使用 C# 的团队，或学习它用于服务器端或全栈开发，本文可帮助你快速高效上手。 其中突出显示了 JavaScript 和 TypeScript 中熟悉的内容以及 C# 中的新增功能。

C#、TypeScript 和 JavaScript 都是 C 系列语言的成员。 语言之间的相似性可帮助你在 C# 中快速提高工作效率。

  1. _**类似的语法**_ ：JavaScript、TypeScript 和 C# 采用 C 系列语言。 这种相似性意味着你已经可以阅读并理解 C#。 存在一些差异，但大多数语法与 JavaScript 和 C 相同。大括号和分号很熟悉。 控件语句（如 `if`） `else`和 `switch` 相同。 循环语句`for``while`和`do...while`相同。 C# 和 TypeScript 中的关键字`class``interface`相同。 TypeScript 和 C# 中的访问修饰符，从 `public` 到 `private`，是相同的。
  2. _**令牌`=>`**_：所有语言都支持轻型函数定义。 在 C# 中，它们称为 [_lambda 表达式_](https://learn.microsoft.com/zh-cn/dotnet/csharp/language-reference/operators/lambda-expressions)。 在 JavaScript 中，它们通常称为 _箭头函数_ 。
  3. _**函数层次结构**_ ：这三种语言都支持 [本地函数](https://learn.microsoft.com/zh-cn/dotnet/csharp/programming-guide/classes-and-structs/local-functions)，这些函数是其他函数中定义的函数。
  4. _**Async/Await**_ ：所有三种语言共享相同的用于异步编程的`async`和`await`关键字。
  5. _**垃圾回收**_ ：这三种语言都依赖于垃圾回收器进行自动内存管理。
  6. _**事件模型**_ ：C# 的 [`event`](https://learn.microsoft.com/zh-cn/dotnet/csharp/events-overview) 语法类似于文档对象模型 （DOM） 事件的 JavaScript 模型。
  7. _**包管理器**_ ： [NuGet](<https://nuget.org>) 是 C# 最常见的包管理器，类似于 JavaScript 应用程序的 npm。 C# 库是通过 [程序集](https://learn.microsoft.com/zh-cn/dotnet/standard/assembly/)交付的。

### 语法一目了然

以下示例并排显示了一些常见模式。 这些比较并不详尽，但它们可让你快速了解语法差异。

**类型批注：**
    
    
    // TypeScript
    let name: string = "Hello";
    let count: number = 5;
    
    
    
    // C#
    string name = "Hello";
    int count = 5;
    

**Async/await：**
    
    
    // TypeScript
    async function fetchData(): Promise<string> {
        const response = await fetch(url);
        return await response.text();
    }
    
    
    
    // C#
    async Task<string> FetchDataAsync() {
        var response = await client.GetAsync(url);
        return await response.Content.ReadAsStringAsync();
    }
    

若要了解详细信息，请参阅 [异步编程](https://learn.microsoft.com/zh-cn/dotnet/csharp/asynchronous-programming/)。

**类：**
    
    
    // TypeScript
    class Point {
        constructor(public x: number, public y: number) {}
    }
    
    
    
    // C#
    record Point(int X, int Y);
    

若要了解详细信息，请参阅 [记录](https://learn.microsoft.com/zh-cn/dotnet/csharp/fundamentals/types/records)。

**模式匹配：**
    
    
    // TypeScript - manual type checking
    if (typeof value === "string") { /* ... */ }
    
    
    
    // C# - pattern matching
    if (value is string s) { /* use s */ }
    

若要了解详细信息，请参阅 [模式匹配](https://learn.microsoft.com/zh-cn/dotnet/csharp/fundamentals/functional/pattern-matching)。

### 运行时模型差异

尽管 C# 和 JavaScript 在语法上看起来类似，但它们运行方式也大相径庭：

  * JavaScript 在 V8 等运行时上运行，并使用事件循环来处理异步工作。
  * C# 在.NET运行时（CLR）上运行，其中代码编译为中间语言（IL），然后使用 JIT 或 AOT 编译执行。

### C# 的新功能有哪些

了解 C# 时，遇到不属于 JavaScript 的概念。 如果使用 TypeScript，其中一些概念可能很熟悉：

  1. [ _**C# 类型系统**_](https://learn.microsoft.com/zh-cn/dotnet/csharp/fundamentals/types/)：C# 是强类型语言。 每个变量都有一个类型，并且该类型无法更改。 您定义`class`或`struct`类型。 可以定义 [`interface`](https://learn.microsoft.com/zh-cn/dotnet/csharp/fundamentals/types/interfaces) 定义来定义其他类型实现的行为。 TypeScript 包括其中许多概念，但由于 TypeScript 是基于 JavaScript 构建的，因此类型系统并不那么严格。
  2. [模式匹配 ](https://learn.microsoft.com/zh-cn/dotnet/csharp/fundamentals/functional/pattern-matching)：模式匹配可以根据复杂数据结构的形状提供简洁的条件语句和表达式。[表达式`is`](https://learn.microsoft.com/zh-cn/dotnet/csharp/language-reference/operators/is)检查变量是否符合某种模式。 基于模式的 [`switch` 表达式](https://learn.microsoft.com/zh-cn/dotnet/csharp/language-reference/operators/switch-expression)提供了丰富的语法来检查变量并根据其特征做出决策。
  3. [字符串插值 ](https://learn.microsoft.com/zh-cn/dotnet/csharp/language-reference/tokens/interpolated)和[原始字符串字面量 ](https://learn.microsoft.com/zh-cn/dotnet/csharp/language-reference/builtin-types/reference-types#string-literals)：字符串插值使你能够在字符串中插入已评估的表达式，而不是使用位置标识符。 原始字符串字面量可用于最小化文本中的转义序列。
  4. [ _**可为 null 和不可为 null 的类型**_](https://learn.microsoft.com/zh-cn/dotnet/csharp/fundamentals/null-safety/nullable-reference-types)：C# 通过将后缀追加 __到类型，支持 _可为 null 的值类型和可为 null_ 的`?`。 对于可以为 null 的类型，如果在取消引用表达式之前不检查是否有 `null`，编译器会发出警告。 对于不可为 null 的类型，如果向该变量分配 `null` 值，编译器会发出警告。 这些功能可以最大程度地避免应用程序引发 [System.NullReferenceException](https://learn.microsoft.com/zh-cn/dotnet/api/system.nullreferenceexception)。 在 TypeScript 使用 `?` 表示可选属性时，其语法可能会让人感到熟悉。
  5. [LINQ ](https://learn.microsoft.com/zh-cn/dotnet/csharp/linq/)：语言集成查询 (LINQ) 提供了一种通用语法来查询和转换数据，无论其存储方式如何。

小窍门

若要详细了解 C# 的类型系统（包括 `class` 与 `struct`、泛型和接口），请访问“基础知识”部分中 [的类型系统](https://learn.microsoft.com/zh-cn/dotnet/csharp/fundamentals/types/) 概述。

在了解详细信息时，其他差异变得明显，但其中许多差异在范围中较小。

JavaScript 和 TypeScript 中的一些熟悉的功能和习惯在 C# 中不可用：

  1. _**动态类型**_ ：C# 使用静态键入。 变量声明包括该类型，并且该类型无法更改。 C# 中有一种 [`dynamic`](https://learn.microsoft.com/zh-cn/dotnet/csharp/language-reference/builtin-types/reference-types#the-dynamic-type) 提供运行时绑定的类型。
  2. _**原型继承**_ ：C# 继承是类型声明的一部分。 C# `class` 声明声明任何基类。 在 JavaScript 中，通过设置 `__proto__` 属性来设置任何实例的基类型。
  3. _**解释语言**_ ：必须先编译 C# 代码，然后才能运行它。 JavaScript 代码可以直接在浏览器中运行。

此外，C# 中没有更多 TypeScript 功能：

  1. _**联合类型**_ ：从 C# 15 开始，C# 支持 [联合类型](https://learn.microsoft.com/zh-cn/dotnet/csharp/language-reference/builtin-types/union)。 联合体定义一个封闭的命名情况集合，一个值可以表示的，编译器确保对这些情况进行穷尽模式匹配。
  2. _**修饰器**_ ：C# 没有修饰器。 一些常见的修饰器，例如 `@sealed`，是在 C# 中被保留的关键字。 其他常见装饰器可能具有相应的 [属性](https://learn.microsoft.com/zh-cn/dotnet/csharp/language-reference/attributes/general)。 对于其他修饰器，你可以创建自己的属性。
  3. _**更宽容的语法**_ ：C# 编译器比 JavaScript 要求更严格地分析代码。

如果要生成 Web 应用程序，请考虑使用 [Blazor](https://learn.microsoft.com/zh-cn/aspnet/core/blazor/index) 生成应用程序。 Blazor 是为 C# 构建的全堆栈 Web 框架。 Blazor 组件可以作为 .NET 程序集或在客户端上使用 WebAssembly 运行。 Blazor 支持与喜欢的 JavaScript 或 TypeScript 库进行互作。

### 后续步骤

  * [C# 教程](https://learn.microsoft.com/zh-cn/dotnet/csharp/tour-of-csharp/overview)：大致了解所有 C# 功能。
  * [初学者教程](https://learn.microsoft.com/zh-cn/dotnet/csharp/tour-of-csharp/tutorials/)：使用交互式课程逐步学习 C# 。
  * [可以使用 C# 生成的内容](https://learn.microsoft.com/zh-cn/dotnet/csharp/tour-of-csharp/what-you-can-build)：探索可以使用 C# 创建的应用程序类型。
  * [C# 基础知识](https://learn.microsoft.com/zh-cn/dotnet/csharp/fundamentals/program-structure/)：深入了解类型系统、面向对象的编程等。

---

## Python 开发者学习 C# 的路线图
如果要从 Python 迁移到 C# 以获取新角色或项目，本文可帮助你快速提高工作效率。 它突出显示了 Python 中熟悉的内容以及 C# 中的不同内容。

C# 和 Python 具备类似的概念。 如果你已经了解 Python，这些熟悉的构造可以帮助你学习 C#。

  1. _**面向对象**_ ：Python 和 C# 都是面向对象的语言。 Python 中类的所有概念都适用于 C#，即使语法不同也适用。
  2. _**跨平台**_ ：Python 和 C# 都是跨平台语言。 使用这两种语言中的任意一种编写的应用都可以在许多平台上运行。
  3. _**垃圾回收**_ ：这两种语言都通过垃圾收集来应用自动内存管理功能。 运行时从不再被引用的对象中回收内存。
  4. _**强类型化**_ ：Python 和 C# 都是强类型化语言。 类型强制不会隐式发生。 后面会介绍一些差异，因为 C# 是静态类型，而 Python 是动态类型。
  5. _**Async / Await**_ ：Python 的 `async` 和 `await` 功能直接受到 C# 的 `async` 和 `await` 支持的启发。
  6. **模式匹配** ：Python 的 __表达式和模式匹配类似于 C# 的`match`[](https://learn.microsoft.com/zh-cn/dotnet/csharp/fundamentals/functional/pattern-matching) 表达式。`switch` 可以使用这些功能来检查复杂数据表达式，以确定它是否与模式匹配。
  7. _**语句关键字**_ ：Python 和 C# 有许多相同关键字，例如 `if`、`else`、`while`、`for` 等。 虽然并非所有语法都相同，但它们十分相似，如果你了解 Python，就可以阅读 C#。

### 语法一目了然

以下示例并排显示了一些常见模式。 这些比较并不详尽，但它们可让你快速了解语法差异。

**类型批注：**
    
    
    # Python
    name: str = "Hello"
    count: int = 5
    
    
    
    // C#
    string name = "Hello";
    int count = 5;
    

**列表过滤（推导式与 LINQ）：**
    
    
    # Python
    result = [x for x in items if x > 5]
    
    
    
    // C#
    var result = items.Where(x => x > 5).ToList();
    

了解详细信息： [LINQ 概述](https://learn.microsoft.com/zh-cn/dotnet/csharp/linq/)

**块范围（缩进与大括号）：**
    
    
    # Python
    if count > 0:
        print("positive")
    
    
    
    // C#
    if (count > 0)
    {
        Console.WriteLine("positive");
    }
    

**类定义：**
    
    
    # Python
    class Point:
        def __init__(self, x: int, y: int):
            self.x = x
            self.y = y
    
    
    
    // C#
    record Point(int X, int Y);
    

了解详细信息： [记录](https://learn.microsoft.com/zh-cn/dotnet/csharp/fundamentals/types/records)

### 主要差异

了解 C# 时，可发现以下重要概念，其中 C# 不同于 Python：

  1. [ _**缩进与符号**_](https://learn.microsoft.com/zh-cn/dotnet/csharp/tour-of-csharp/tutorials/branches-and-loops)：在 Python 中，换行和缩进是基本的语法元素。 在 C# 中，空格并不重要。 标记，例如 `;` 用于分隔语句，其他标记如 `{` 和 `}` 用于控制 `if` 和其他块语句的块范围。 但是，为了便于阅读，大多数编码样式（包括这些文档中使用的样式）都使用缩进来强化 `{` 和 `}`声明的块范围。
  2. [ _**静态类型语言**_](https://learn.microsoft.com/zh-cn/dotnet/csharp/fundamentals/types/)：在 C# 中，变量声明包括其类型。 将变量重新分配给不同类型的对象将生成编译器错误。 在 Python 中，在重新分配时，类型可能会发生更改。
  3. [ _**可以为 null 的类型**_](https://learn.microsoft.com/zh-cn/dotnet/csharp/fundamentals/null-safety/nullable-reference-types)：C# 变量 _可为空_ 或 _不可为空_ 。 不可为 null 的类型是不能为 null（或不包含任何值）的类型。 它始终需要引用有效的对象。 相比之下，可为空的类型可以引用有效对象或 null。
  4. [ _**LINQ**_](https://learn.microsoft.com/zh-cn/dotnet/csharp/linq/)：组成语言集成查询 (LINQ) 的查询表达式关键字与 Python 中的关键字不同。 但是，Python 库（如 `itertools`、`more-itertools` 和 `py-linq`）具备类似的功能。
  5. [ _**泛型**_](https://learn.microsoft.com/zh-cn/dotnet/csharp/fundamentals/types/generics)：C# 泛型使用 C# 静态类型语言对类型参数提供的参数进行断言。 泛型算法可能需要指定参数类型必须满足的约束。

小窍门

若要详细了解 C# 的类型系统（包括 `class` 与 `struct`、泛型和接口），请访问“基础知识”部分中 [的类型系统](https://learn.microsoft.com/zh-cn/dotnet/csharp/fundamentals/types/) 概述。

最后，Python 的某些功能在 C# 中不可用：

  1. _**结构化（鸭子）语言类型**_ ：在 C# 中，类型具有名称和声明。 除[元组](https://learn.microsoft.com/zh-cn/dotnet/csharp/language-reference/builtin-types/value-tuples)外，具有相同结构的类型不可互换。
  2. _**REPL**_ ：C# 不具备读取-求值-打印循环 (REPL)，无法快速构建解决方案原型。
  3. _**重要空格**_ ：需要正确使用大括号 `{` 和 `}` 来表示代码块范围。

如果你了解 Python，那么 C# 的学习过程会很顺利。 这些语言具有相似的概念和相似的习语。

### 后续步骤

  * [C# 教程](https://learn.microsoft.com/zh-cn/dotnet/csharp/tour-of-csharp/overview)：大致了解所有 C# 功能。
  * [初学者教程](https://learn.microsoft.com/zh-cn/dotnet/csharp/tour-of-csharp/tutorials/)：使用交互式课程逐步学习 C# 。
  * [可以使用 C# 生成的内容](https://learn.microsoft.com/zh-cn/dotnet/csharp/tour-of-csharp/what-you-can-build)：探索可以使用 C# 创建的应用程序类型。
  * [C# 基础知识](https://learn.microsoft.com/zh-cn/dotnet/csharp/fundamentals/program-structure/)：深入了解类型系统、面向对象的编程等。

---
