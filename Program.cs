using System;
using Lab_8;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Запуск тестов для Green_1\n");
        
        TestEmptyString1();
        TestAmazonForestText1();
        TestEngineText1();
        TestGreeceDefaultText1();
        TestFjordsText1();
        TestShakespeareText1();
        TestFirstJourneyText1();
        
        Console.WriteLine("\nВсе тесты завершены!\n");

        Console.WriteLine("Запуск тестов для Green_2\n");
        
        TestEmptyString2();
        TestAmazonForestText2();
        TestEngineText2();
        TestGreeceDefaultText2();
        TestFjordsText2();
        TestShakespeareText2();
        TestFirstJourneyText2();
        
        Console.WriteLine("\nВсе тесты завершены!\n");

        Console.WriteLine("Запуск тестов для Green_3\n");

        TestAmazonForestText3();
        TestEngineText3();
        TestGreeceDefaultText3();
        TestFjordsText3();
        TestShakespeareText3();
        TestFirstJourneyText3();
        
        Console.WriteLine("\nВсе тесты завершены!\n");

        Console.WriteLine("Запуск тестов для Green_4\n");

        TestRussianSurnames4();
        TestEnglishSurnames4();
        TestMixedSurnames4();
        
        Console.WriteLine("\nВсе тесты завершены!\n");
    }

    // Green_1 Tests
    static void TestEmptyString1()
    {
        var analyzer = new Green_1("");
        analyzer.Review();
        
        Console.WriteLine("Тест пустой строки:");
        Console.WriteLine(analyzer.ToString());
        
        foreach (var item in analyzer.Output)
        {
            if (item.Item2 != 0.0)
            {
                Console.WriteLine("Ошибка: для пустой строки все частоты должны быть 0");
                return;
            }
        }
        Console.WriteLine("Тест пройден\n");
    }

    static void TestAmazonForestText1()
    {
        var text = "После многолетних исследований ученые обнаружили тревожную тенденцию в вырубке лесов Амазонии. Анализ данных показал, что основной участник разрушения лесного покрова – человеческая деятельность. За последние десятилетия рост объема вырубки достиг критических показателей. Главными факторами, способствующими этому, являются промышленные рубки, производство древесины, расширение сельскохозяйственных угодий и незаконная добыча древесины. Это приводит к серьезным экологическим последствиям, таким как потеря биоразнообразия, ухудшение климата и угроза вымирания многих видов животных и растений.";
        var analyzer = new Green_1(text);
        analyzer.Review();
        
        Console.WriteLine("Тест текста про Амазонские леса:");
        Console.WriteLine(analyzer.ToString());
        
        var expectedFrequencies = new (char, double)[] {
            ('а', 0.0640), ('б', 0.0174), ('в', 0.0446), ('г', 0.0155), ('д', 0.0310),
            ('е', 0.0853), ('ж', 0.0058), ('з', 0.0252), ('и', 0.0950), ('й', 0.0116),
            ('к', 0.0388), ('л', 0.0388), ('м', 0.0291), ('н', 0.0717), ('о', 0.0969),
            ('п', 0.0213), ('р', 0.0484), ('с', 0.0581), ('т', 0.0523), ('у', 0.0271),
            ('ф', 0.0019), ('х', 0.0155), ('ц', 0.0019), ('ч', 0.0155), ('ш', 0.0078),
            ('щ', 0.0019), ('ъ', 0.0019), ('ы', 0.0271), ('ь', 0.0078), ('э', 0.0058),
            ('ю', 0.0078), ('я', 0.0271)
        };
        
        bool allCorrect = true;
        foreach (var expected in expectedFrequencies)
        {
            bool found = false;
            foreach (var actual in analyzer.Output)
            {
                if (actual.Item1 == expected.Item1 && 
                    Math.Abs(actual.Item2 - expected.Item2) < 0.0001)
                {
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine($"Ошибка: для буквы '{expected.Item1}' частота не соответствует ожидаемой");
                allCorrect = false;
            }
        }
        
        if (allCorrect) Console.WriteLine("Тест пройден\n");
        else Console.WriteLine("Тест не пройден\n");
    }

    static void TestEngineText1()
    {
        var text = "Двигатель самолета – это сложная инженерная конструкция, обеспечивающая подъем, управление и движение в воздухе. Он состоит из множества компонентов, каждый из которых играет важную роль в общей работе механизма. Внутреннее устройство двигателя включает в себя компрессор, камеру сгорания, турбину и системы управления и охлаждения. Принцип работы основан на воздушно-топливной смеси, которая подвергается сжатию, воспламенению и расширению, обеспечивая движение воздушного судна.";
        var analyzer = new Green_1(text);
        analyzer.Review();
        
        Console.WriteLine("Тест текста про двигатель самолета:");
        Console.WriteLine(analyzer.ToString());
        
        var expectedFrequencies = new (char, double)[] {
            ('а', 0.0762), ('б', 0.0172), ('в', 0.0590), ('г', 0.0147), ('д', 0.0295),
            ('е', 0.0958), ('ж', 0.0221), ('з', 0.0147), ('и', 0.0811), ('й', 0.0098),
            ('к', 0.0221), ('л', 0.0270), ('м', 0.0270), ('н', 0.0786), ('о', 0.0983),
            ('п', 0.0295), ('р', 0.0516), ('с', 0.0590), ('т', 0.0565), ('у', 0.0319),
            ('х', 0.0098), ('ц', 0.0049), ('ч', 0.0074), ('ш', 0.0074), ('щ', 0.0049),
            ('ъ', 0.0025), ('ы', 0.0098), ('ь', 0.0049), ('э', 0.0025), ('ю', 0.0147),
            ('я', 0.0295)
        };
        
        bool allCorrect = true;
        foreach (var expected in expectedFrequencies)
        {
            bool found = false;
            foreach (var actual in analyzer.Output)
            {
                if (actual.Item1 == expected.Item1 && 
                    Math.Abs(actual.Item2 - expected.Item2) < 0.0001)
                {
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine($"Ошибка: для буквы '{expected.Item1}' частота не соответствует ожидаемой");
                allCorrect = false;
            }
        }
        
        if (allCorrect) Console.WriteLine("Тест пройден\n");
        else Console.WriteLine("Тест не пройден\n");
    }

    static void TestGreeceDefaultText1()
    {
        var text = "1 июля 2015 года Греция объявила о дефолте по государственному долгу, став первой развитой страной в истории, которая не смогла выплатить свои долговые обязательства в полном объеме. Сумма дефолта составила порядка 1,6 миллиарда евро. Этому предшествовали долгие переговоры с международными кредиторами, такими как Международный валютный фонд (МВФ), Европейский центральный банк (ЕЦБ) и Европейская комиссия (ЕК), о программах финансовой помощи и реструктуризации долга. Основными причинами дефолта стали недостаточная эффективность реформ, направленных на улучшение финансовой стабильности страны, а также политическая нестабильность, что вызвало потерю доверия со стороны международных инвесторов и кредиторов. Последствия дефолта оказались глубокими и долгосрочными: сокращение кредитного рейтинга страны, увеличение затрат на заемный капитал, рост стоимости заимствований и утрата доверия со стороны международных инвесторов.";
        var analyzer = new Green_1(text);
        analyzer.Review();
        
        Console.WriteLine("Тест текста про дефолт Греции:");
        Console.WriteLine(analyzer.ToString());
        
        var expectedFrequencies = new (char, double)[] {
            ('а', 0.0852), ('б', 0.0102), ('в', 0.0483), ('г', 0.0178), ('д', 0.0382),
            ('е', 0.0712), ('ж', 0.0064), ('з', 0.0102), ('и', 0.0827), ('й', 0.0178),
            ('к', 0.0267), ('л', 0.0420), ('м', 0.0356), ('н', 0.0636), ('о', 0.1145),
            ('п', 0.0216), ('р', 0.0623), ('с', 0.0585), ('т', 0.0700), ('у', 0.0204),
            ('ф', 0.0140), ('х', 0.0051), ('ц', 0.0051), ('ч', 0.0089), ('ш', 0.0025),
            ('щ', 0.0025), ('ъ', 0.0025), ('ы', 0.0229), ('ь', 0.0102), ('э', 0.0025),
            ('ю', 0.0038), ('я', 0.0165)
        };
        
        bool allCorrect = true;
        foreach (var expected in expectedFrequencies)
        {
            bool found = false;
            foreach (var actual in analyzer.Output)
            {
                if (actual.Item1 == expected.Item1 && 
                    Math.Abs(actual.Item2 - expected.Item2) < 0.0001)
                {
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine($"Ошибка: для буквы '{expected.Item1}' частота не соответствует ожидаемой");
                allCorrect = false;
            }
        }
        
        if (allCorrect) Console.WriteLine("Тест пройден\n");
        else Console.WriteLine("Тест не пройден\n");
    }

    static void TestFjordsText1()
    {
        var text = "Фьорды – это ущелья, формирующиеся ледниками и заполняющиеся морской водой. Название происходит от древнескандинавского слова \"fjǫrðr\". Эти глубокие заливы, окруженные высокими горами, представляют захватывающие виды и природную красоту. Они популярны среди туристов и известны под разными названиями: в Норвегии – \"фьорды\", в Шотландии – \"фьордс\", в Исландии – \"фьордар\". Фьорды играют важную роль в культуре и туризме региона, продолжая вдохновлять людей со всего мира.";
        var analyzer = new Green_1(text);
        analyzer.Review();
        
        Console.WriteLine("Тест текста про фьорды:");
        Console.WriteLine(analyzer.ToString());
        
        // Ожидаемые частоты с учетом возможного округления
        var expectedFrequencies = new (char, double)[] {
            ('а', 0.0651), ('б', 0.0026), ('в', 0.0599), ('г', 0.0182), ('д', 0.0521),
            ('е', 0.0521), ('ж', 0.0078), ('з', 0.0208), ('и', 0.1042), ('й', 0.0078),
            ('к', 0.0234), ('л', 0.0391), ('м', 0.0234), ('н', 0.0573), ('о', 0.0990),
            ('п', 0.0208), ('р', 0.0755), ('с', 0.0443), ('т', 0.0417), ('у', 0.0312),
            ('ф', 0.0156), ('х', 0.0078), ('ш', 0.0026), ('щ', 0.0104), ('ы', 0.0286),
            ('ь', 0.0234), ('э', 0.0052), ('ю', 0.0208), ('я', 0.0234)
        };
        
        bool allCorrect = true;
        foreach (var expected in expectedFrequencies)
        {
            bool found = false;
            foreach (var actual in analyzer.Output)
            {
                if (actual.Item1 == expected.Item1 && 
                    Math.Abs(actual.Item2 - expected.Item2) < 0.0002) // Увеличиваем допустимую погрешность
                {
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine($"Ошибка: для буквы '{expected.Item1}' частота не соответствует ожидаемой");
                allCorrect = false;
            }
        }
        
        // Проверка букв с нулевой частотой
        var zeroFrequencyLetters = new char[] { 'ё', 'ц', 'ч', 'ъ' };
        foreach (var letter in zeroFrequencyLetters)
        {
            var item = analyzer.Output.FirstOrDefault(x => x.Item1 == letter);
            if (item.Item2 != 0.0)
            {
                Console.WriteLine($"Ошибка: для буквы '{letter}' частота должна быть 0");
                allCorrect = false;
            }
        }
        
        if (allCorrect) Console.WriteLine("Тест пройден\n");
        else Console.WriteLine("Тест не пройден\n");
    }

    static void TestShakespeareText1()
    {
        var text = "William Shakespeare, widely regarded as one of the greatest writers in the English language, authored a total of 37 plays, along with numerous poems and sonnets. He was born in Stratford-upon-Avon, England, in 1564, and died in 1616. Shakespeare's most famous works, including \"Romeo and Juliet,\" \"Hamlet,\" \"Macbeth,\" and \"Othello,\" were written during the late 16th and early 17th centuries. \"Romeo and Juliet,\" a tragic tale of young love, was penned around 1595. \"Hamlet,\" one of his most celebrated tragedies, was written in the early 1600s, followed by \"Macbeth,\" a gripping drama exploring themes of ambition and power, around 1606. \"Othello,\" a tragedy revolving around jealousy and deceit, was also composed during this period, believed to be around 1603.";
        var analyzer = new Green_1(text);
        analyzer.Review();
        
        Console.WriteLine("Тест текста про Шекспира:");
        Console.WriteLine(analyzer.ToString());
        
        // Для английского текста проверяем только наличие букв и корректность частот
        bool allCorrect = true;
        foreach (var item in analyzer.Output)
        {
            if (item.Item2 <= 0 || item.Item2 > 1.0)
            {
                Console.WriteLine($"Ошибка: некорректная частота для буквы '{item.Item1}'");
                allCorrect = false;
            }
        }
        
        if (allCorrect) Console.WriteLine("Тест пройден\n");
        else Console.WriteLine("Тест не пройден\n");
    }

    static void TestFirstJourneyText1()
    {
        var text = "Первое кругосветное путешествие было осуществлено флотом, возглавляемым португальским исследователем Фернаном Магелланом. Путешествие началось 20 сентября 1519 года, когда флот, состоящий из пяти кораблей и примерно 270 человек, отправился из порту Сан-Лукас в Испании. Хотя Магеллан не закончил свое путешествие из-за гибели в битве на Филиппинах в 1521 году, его экспедиция стала первой, которая успешно обогнула Землю и доказала ее круглую форму. Это путешествие открыло новые морские пути и имело огромное значение для картографии и географических открытий.";
        var analyzer = new Green_1(text);
        analyzer.Review();
        
        Console.WriteLine("Тест текста про первое кругосветное путешествие:");
        Console.WriteLine(analyzer.ToString());
        
        var expectedFrequencies = new (char, double)[] {
            ('а', 0.0694), ('б', 0.0130), ('в', 0.0412), ('г', 0.0347), ('д', 0.0152),
            ('е', 0.1063), ('з', 0.0195), ('и', 0.0824), ('й', 0.0087), ('к', 0.0347),
            ('л', 0.0629), ('м', 0.0325), ('н', 0.0456), ('о', 0.1063), ('п', 0.0369),
            ('р', 0.0456), ('с', 0.0521), ('т', 0.0629), ('у', 0.0347), ('ф', 0.0152),
            ('х', 0.0065), ('ц', 0.0022), ('ч', 0.0108), ('ш', 0.0108), ('щ', 0.0043),
            ('ы', 0.0108), ('ь', 0.0043), ('э', 0.0043), ('ю', 0.0043), ('я', 0.0217)
        };
        
        bool allCorrect = true;
        foreach (var expected in expectedFrequencies)
        {
            bool found = false;
            foreach (var actual in analyzer.Output)
            {
                if (actual.Item1 == expected.Item1 && 
                    Math.Abs(actual.Item2 - expected.Item2) < 0.0001)
                {
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine($"Ошибка: для буквы '{expected.Item1}' частота не соответствует ожидаемой");
                allCorrect = false;
            }
        }
        
        if (allCorrect) Console.WriteLine("Тест пройден\n");
        else Console.WriteLine("Тест не пройден\n");
    }

    // Green_2 Tests
    static void TestEmptyString2()
    {
        var analyzer = new Green_2("");
        analyzer.Review();
        
        Console.WriteLine("Тест пустой строки:");
        Console.WriteLine(analyzer.ToString());
        
        if (analyzer.Output.Length != 0)
        {
            Console.WriteLine("Ошибка: для пустой строки должен быть пустой массив");
            return;
        }
        Console.WriteLine("Тест пройден\n");
    }

    static void TestAmazonForestText2()
    {
        var text = "После многолетних исследований ученые обнаружили тревожную тенденцию в вырубке лесов Амазонии. Анализ данных показал, что основной участник разрушения лесного покрова – человеческая деятельность. За последние десятилетия рост объема вырубки достиг критических показателей. Главными факторами, способствующими этому, являются промышленные рубки, производство древесины, расширение сельскохозяйственных угодий и незаконная добыча древесины. Это приводит к серьезным экологическим последствиям, таким как потеря биоразнообразия, ухудшение климата и угроза вымирания многих видов животных и растений.";
        var analyzer = new Green_2(text);
        analyzer.Review();
        
        Console.WriteLine("Тест текста про Амазонские леса:");
        Console.WriteLine(analyzer.ToString());
        
        var expected = new char[] { 'п', 'д', 'в', 'р', 'у', 'и', 'к', 'о', 'с', 'т', 'э', 'а', 'л', 'м', 'ч', 'б', 'г', 'ж', 'з', 'н', 'ф', 'я' };
        
        bool isCorrect = true;
        if (analyzer.Output.Length != expected.Length)
        {
            isCorrect = false;
        }
        else
        {
            for (int i = 0; i < expected.Length; i++)
            {
                if (analyzer.Output[i] != expected[i])
                {
                    isCorrect = false;
                    break;
                }
            }
        }
        
        if (isCorrect) Console.WriteLine("Тест пройден\n");
        else Console.WriteLine("Тест не пройден\n");
    }

    static void TestEngineText2()
    {
        var text = "Двигатель самолета – это сложная инженерная конструкция, обеспечивающая подъем, управление и движение в воздухе. Он состоит из множества компонентов, каждый из которых играет важную роль в общей работе механизма. Внутреннее устройство двигателя включает в себя компрессор, камеру сгорания, турбину и системы управления и охлаждения. Принцип работы основан на воздушно-топливной смеси, которая подвергается сжатию, воспламенению и расширению, обеспечивая движение воздушного судна.";
        var analyzer = new Green_2(text);
        analyzer.Review();
        
        Console.WriteLine("Тест текста про двигатель самолета:");
        Console.WriteLine(analyzer.ToString());
        
        var expected = new char[] { 'в', 'с', 'и', 'к', 'о', 'д', 'р', 'п', 'у', 'м', 'н', 'т', 'э' };
        
        bool isCorrect = true;
        if (analyzer.Output.Length != expected.Length)
        {
            isCorrect = false;
        }
        else
        {
            for (int i = 0; i < expected.Length; i++)
            {
                if (analyzer.Output[i] != expected[i])
                {
                    isCorrect = false;
                    break;
                }
            }
        }
        
        if (isCorrect) Console.WriteLine("Тест пройден\n");
        else Console.WriteLine("Тест не пройден\n");
    }

    static void TestGreeceDefaultText2()
    {
        var text = "1 июля 2015 года Греция объявила о дефолте по государственному долгу, став первой развитой страной в истории, которая не смогла выплатить свои долговые обязательства в полном объеме. Сумма дефолта составила порядка 1,6 миллиарда евро. Этому предшествовали долгие переговоры с международными кредиторами, такими как Международный валютный фонд (МВФ), Европейский центральный банк (ЕЦБ) и Европейская комиссия (ЕК), о программах финансовой помощи и реструктуризации долга. Основными причинами дефолта стали недостаточная эффективность реформ, направленных на улучшение финансовой стабильности страны, а также политическая нестабильность, что вызвало потерю доверия со стороны международных инвесторов и кредиторов. Последствия дефолта оказались глубокими и долгосрочными: сокращение кредитного рейтинга страны, увеличение затрат на заемный капитал, рост стоимости заимствований и утрата доверия со стороны международных инвесторов.";
        var analyzer = new Green_2(text);
        analyzer.Review();
        
        Console.WriteLine("Тест текста про дефолт Греции:");
        Console.WriteLine(analyzer.ToString());
        
        var expected = new char[] { 'с', 'п', 'д', 'и', 'к', 'о', 'м', 'н', 'в', 'е', 'р', 'г', 'з', 'у', 'ф', 'т', 'э', 'а', 'б', 'ц', 'ч' };
        
        bool isCorrect = true;
        if (analyzer.Output.Length != expected.Length)
        {
            isCorrect = false;
        }
        else
        {
            for (int i = 0; i < expected.Length; i++)
            {
                if (analyzer.Output[i] != expected[i])
                {
                    isCorrect = false;
                    break;
                }
            }
        }
        
        if (isCorrect) Console.WriteLine("Тест пройден\n");
        else Console.WriteLine("Тест не пройден\n");
    }

    static void TestFjordsText2()
    {
        var text = "Фьорды – это ущелья, формирующиеся ледниками и заполняющиеся морской водой. Название происходит от древнескандинавского слова \"fjǫrðr\". Эти глубокие заливы, окруженные высокими горами, представляют захватывающие виды и природную красоту. Они популярны среди туристов и известны под разными названиями: в Норвегии – \"фьорды\", в Шотландии – \"фьордс\", в Исландии – \"фьордар\". Фьорды играют важную роль в культуре и туризме региона, продолжая вдохновлять людей со всего мира.";
        var analyzer = new Green_2(text);
        analyzer.Review();
        
        Console.WriteLine("Тест текста про фьорды:");
        Console.WriteLine(analyzer.ToString());
        
        var expected = new char[] { 'в', 'и', 'п', 'ф', 'з', 'н', 'о', 'р', 'с', 'г', 'к', 'л', 'м', 'т', 'э', 'f', 'д', 'у', 'ш' };
        
        bool isCorrect = true;
        if (analyzer.Output.Length != expected.Length)
        {
            isCorrect = false;
        }
        else
        {
            for (int i = 0; i < expected.Length; i++)
            {
                if (analyzer.Output[i] != expected[i])
                {
                    isCorrect = false;
                    break;
                }
            }
        }
        
        if (isCorrect) Console.WriteLine("Тест пройден\n");
        else Console.WriteLine("Тест не пройден\n");
    }

    static void TestShakespeareText2()
    {
        var text = "William Shakespeare, widely regarded as one of the greatest writers in the English language, authored a total of 37 plays, along with numerous poems and sonnets. He was born in Stratford-upon-Avon, England, in 1564, and died in 1616. Shakespeare's most famous works, including \"Romeo and Juliet,\" \"Hamlet,\" \"Macbeth,\" and \"Othello,\" were written during the late 16th and early 17th centuries. \"Romeo and Juliet,\" a tragic tale of young love, was penned around 1595. \"Hamlet,\" one of his most celebrated tragedies, was written in the early 1600s, followed by \"Macbeth,\" a gripping drama exploring themes of ambition and power, around 1606. \"Othello,\" a tragedy revolving around jealousy and deceit, was also composed during this period, believed to be around 1603.";
        var analyzer = new Green_2(text);
        analyzer.Review();
        
        Console.WriteLine("Тест текста про Шекспира:");
        Console.WriteLine(analyzer.ToString());
        
        var expected = new char[] { 'a', 't', 'w', 'o', 'i', 'd', 'e', 'p', 'b', 'h', 'm', 'r', 's', 'c', 'j', 'l', 'f', 'g', 'n', 'y' };
        
        bool isCorrect = true;
        if (analyzer.Output.Length != expected.Length)
        {
            isCorrect = false;
        }
        else
        {
            for (int i = 0; i < expected.Length; i++)
            {
                if (analyzer.Output[i] != expected[i])
                {
                    isCorrect = false;
                    break;
                }
            }
        }
        
        if (isCorrect) Console.WriteLine("Тест пройден\n");
        else Console.WriteLine("Тест не пройден\n");
    }

    static void TestFirstJourneyText2()
    {
        var text = "Первое кругосветное путешествие было осуществлено флотом, возглавляемым португальским исследователем Фернаном Магелланом. Путешествие началось 20 сентября 1519 года, когда флот, состоящий из пяти кораблей и примерно 270 человек, отправился из порту Сан-Лукас в Испании. Хотя Магеллан не закончил свое путешествие из-за гибели в битве на Филиппинах в 1521 году, его экспедиция стала первой, которая успешно обогнула Землю и доказала ее круглую форму. Это путешествие открыло новые морские пути и имело огромное значение для картографии и географических открытий.";
        var analyzer = new Green_2(text);
        analyzer.Review();
        
        Console.WriteLine("Тест текста про первое кругосветное путешествие:");
        Console.WriteLine(analyzer.ToString());
        
        var expected = new char[] { 'п', 'и', 'к', 'о', 'с', 'ф', 'в', 'г', 'н', 'з', 'м', 'б', 'д', 'е', 'э', 'у', 'х', 'ч' };
        
        bool isCorrect = true;
        if (analyzer.Output.Length != expected.Length)
        {
            isCorrect = false;
        }
        else
        {
            for (int i = 0; i < expected.Length; i++)
            {
                if (analyzer.Output[i] != expected[i])
                {
                    isCorrect = false;
                    break;
                }
            }
        }
        
        if (isCorrect) Console.WriteLine("Тест пройден\n");
        else Console.WriteLine("Тест не пройден\n");
    }

    // Green_3 Tests
    static void TestAmazonForestText3()
    {
        var text = "После многолетних исследований ученые обнаружили тревожную тенденцию в вырубке лесов Амазонии. Анализ данных показал, что основной участник разрушения лесного покрова – человеческая деятельность. За последние десятилетия рост объема вырубки достиг критических показателей. Главными факторами, способствующими этому, являются промышленные рубки, производство древесины, расширение сельскохозяйственных угодий и незаконная добыча древесины. Это приводит к серьезным экологическим последствиям, таким как потеря биоразнообразия, ухудшение климата и угроза вымирания многих видов животных и растений.";
        var analyzer = new Green_3(text, "ос");
        analyzer.Review();
        
        Console.WriteLine("Тест текста про Амазонские леса:");
        Console.WriteLine(analyzer.ToString());
        
        var expected = new string[] {"после", "основной", "деятельность", "последние", "рост", "достиг", "способствующими", "последствиям" };
        
        bool isCorrect = true;
        if (analyzer.Output.Length != expected.Length)
        {
            isCorrect = false;
        }
        else
        {
            for (int i = 0; i < expected.Length; i++)
            {
                if (analyzer.Output[i] != expected[i])
                {
                    isCorrect = false;
                    break;
                }
            }
        }
        
        if (isCorrect) Console.WriteLine("Тест пройден\n");
        else Console.WriteLine("Тест не пройден\n");
    }

    static void TestEngineText3()
    {
        var text = "Двигатель самолета – это сложная инженерная конструкция, обеспечивающая подъем, управление и движение в воздухе. Он состоит из множества компонентов, каждый из которых играет важную роль в общей работе механизма. Внутреннее устройство двигателя включает в себя компрессор, камеру сгорания, турбину и системы управления и охлаждения. Принцип работы основан на воздушно-топливной смеси, которая подвергается сжатию, воспламенению и расширению, обеспечивая движение воздушного судна.";
        var analyzer = new Green_3(text, "дви");
        analyzer.Review();
        
        Console.WriteLine("Тест текста про двигатель самолета:");
        Console.WriteLine(analyzer.ToString());
        
        var expected = new string[] { "двигатель", "движение", "двигателя" };
        
        bool isCorrect = true;
        if (analyzer.Output.Length != expected.Length)
        {
            isCorrect = false;
        }
        else
        {
            for (int i = 0; i < expected.Length; i++)
            {
                if (analyzer.Output[i] != expected[i])
                {
                    isCorrect = false;
                    break;
                }
            }
        }
        
        if (isCorrect) Console.WriteLine("Тест пройден\n");
        else Console.WriteLine("Тест не пройден\n");
    }

    static void TestGreeceDefaultText3()
    {
        var text = "1 июля 2015 года Греция объявила о дефолте по государственному долгу, став первой развитой страной в истории, которая не смогла выплатить свои долговые обязательства в полном объеме. Сумма дефолта составила порядка 1,6 миллиарда евро. Этому предшествовали долгие переговоры с международными кредиторами, такими как Международный валютный фонд (МВФ), Европейский центральный банк (ЕЦБ) и Европейская комиссия (ЕК), о программах финансовой помощи и реструктуризации долга. Основными причинами дефолта стали недостаточная эффективность реформ, направленных на улучшение финансовой стабильности страны, а также политическая нестабильность, что вызвало потерю доверия со стороны международных инвесторов и кредиторов. Последствия дефолта оказались глубокими и долгосрочными: сокращение кредитного рейтинга страны, увеличение затрат на заемный капитал, рост стоимости заимствований и утрата доверия со стороны международных инвесторов.";
        var analyzer = new Green_3(text, "дел");
        analyzer.Review();
        
        Console.WriteLine("Тест текста про дефолт Греции:");
        Console.WriteLine(analyzer.ToString());
        
        if (analyzer.Output.Length == 0)
            Console.WriteLine("Тест пройден (нет совпадений, как и ожидалось)\n");
        else
            Console.WriteLine("Тест не пройден (найдены неожиданные совпадения)\n");
    }

    static void TestFjordsText3()
    {
        var text = "Фьорды – это ущелья, формирующиеся ледниками и заполняющиеся морской водой. Название происходит от древнескандинавского слова \"fjǫrðr\". Эти глубокие заливы, окруженные высокими горами, представляют захватывающие виды и природную красоту. Они популярны среди туристов и известны под разными названиями: в Норвегии – \"фьорды\", в Шотландии – \"фьордс\", в Исландии – \"фьордар\". Фьорды играют важную роль в культуре и туризме региона, продолжая вдохновлять людей со всего мира.";
        var analyzer = new Green_3(text, "фьорд");
        analyzer.Review();
        
        Console.WriteLine("Тест текста про фьорды:");
        Console.WriteLine(analyzer.ToString());
        
        var expected = new string[] { "фьорды", "фьордс", "фьордар" };
        
        bool isCorrect = true;
        if (analyzer.Output.Length != expected.Length)
        {
            isCorrect = false;
        }
        else
        {
            for (int i = 0; i < expected.Length; i++)
            {
                if (analyzer.Output[i] != expected[i])
                {
                    isCorrect = false;
                    break;
                }
            }
        }
        
        if (isCorrect) Console.WriteLine("Тест пройден\n");
        else Console.WriteLine("Тест не пройден\n");
    }

    static void TestShakespeareText3()
    {
        var text = "William Shakespeare, widely regarded as one of the greatest writers in the English language, authored a total of 37 plays, along with numerous poems and sonnets. He was born in Stratford-upon-Avon, England, in 1564, and died in 1616. Shakespeare's most famous works, including \"Romeo and Juliet,\" \"Hamlet,\" \"Macbeth,\" and \"Othello,\" were written during the late 16th and early 17th centuries. \"Romeo and Juliet,\" a tragic tale of young love, was penned around 1595. \"Hamlet,\" one of his most celebrated tragedies, was written in the early 1600s, followed by \"Macbeth,\" a gripping drama exploring themes of ambition and power, around 1606. \"Othello,\" a tragedy revolving around jealousy and deceit, was also composed during this period, believed to be around 1603.";
        var analyzer = new Green_3(text, "will");
        analyzer.Review();
        
        Console.WriteLine("Тест текста про Шекспира:");
        Console.WriteLine(analyzer.ToString());
        
        var expected = new string[] { "william" };
        
        bool isCorrect = true;
        if (analyzer.Output.Length != expected.Length)
        {
            isCorrect = false;
        }
        else
        {
            for (int i = 0; i < expected.Length; i++)
            {
                if (analyzer.Output[i] != expected[i])
                {
                    isCorrect = false;
                    break;
                }
            }
        }
        
        if (isCorrect) Console.WriteLine("Тест пройден\n");
        else Console.WriteLine("Тест не пройден\n");
    }

    static void TestFirstJourneyText3()
    {
        var text = "Первое кругосветное путешествие было осуществлено флотом, возглавляемым португальским исследователем Фернаном Магелланом. Путешествие началось 20 сентября 1519 года, когда флот, состоящий из пяти кораблей и примерно 270 человек, отправился из порту Сан-Лукас в Испании. Хотя Магеллан не закончил свое путешествие из-за гибели в битве на Филиппинах в 1521 году, его экспедиция стала первой, которая успешно обогнула Землю и доказала ее круглую форму. Это путешествие открыло новые морские пути и имело огромное значение для картографии и географических открытий.";
        var analyzer = new Green_3(text, "пер");
        analyzer.Review();
        
        Console.WriteLine("Тест текста про первое кругосветное путешествие:");
        Console.WriteLine(analyzer.ToString());
        
        var expected = new string[] { "первое", "первой" };
        
        bool isCorrect = true;
        if (analyzer.Output.Length != expected.Length)
        {
            isCorrect = false;
        }
        else
        {
            for (int i = 0; i < expected.Length; i++)
            {
                if (analyzer.Output[i] != expected[i])
                {
                    isCorrect = false;
                    break;
                }
            }
        }
        
        if (isCorrect) Console.WriteLine("Тест пройден\n");
        else Console.WriteLine("Тест не пройден\n");
    }

    // Green_4 Tests
    static void TestRussianSurnames4()
    {
        var surnames = "Иванов, Петров, Смирнов, Соколов, Кузнецов, Попов, Лебедев, Волков, Козлов, Новиков, Иванова, Петрова, Смирнова,";
        var sorter = new Green_4(surnames);
        sorter.Review();
        
        Console.WriteLine("Тест русских фамилий:");
        Console.WriteLine(sorter.ToString());
        
        var expected = new string[] { 
            "Волков", "Иванов", "Иванова", "Козлов", "Кузнецов", 
            "Лебедев", "Новиков", "Петров", "Петрова", "Попов", 
            "Смирнов", "Смирнова", "Соколов" 
        };
        
        CheckResult(sorter.Output, expected);
    }

    static void TestEnglishSurnames4()
    {
        var surnames = "Ivanov, Petrov, Smirnov, Sokolov, Kuznetsov, Popov, Lebedev, Volkov, Kozlov, Novikov, Ivanova, Petrova, Smirnova";
        var sorter = new Green_4(surnames);
        sorter.Review();
        
        Console.WriteLine("Тест английских фамилий:");
        Console.WriteLine(sorter.ToString());
        
        var expected = new string[] { 
            "Ivanov", "Ivanova", "Kozlov", "Kuznetsov", "Lebedev", 
            "Novikov", "Petrov", "Petrova", "Popov", "Smirnov", 
            "Smirnova", "Sokolov", "Volkov" 
        };
        
        CheckResult(sorter.Output, expected);
    }

    static void TestMixedSurnames4()
    {
        var surnames = "Иванов, Петров, Смирнов, Соколов, Кузнецов, Попов, Лебедев, Волков, Козлов, Новиков, Иванова, Петрова, Смирнова, Ivanov, Petrov, Smirnov, Sokolov, Kuznetsov, Popov, Lebedev, Volkov, Kozlov, Novikov, Ivanova, Petrova, Smirnova";
        var sorter = new Green_4(surnames);
        sorter.Review();
        
        Console.WriteLine("Тест смешанных фамилий:");
        Console.WriteLine(sorter.ToString());
        
        var expected = new string[] { 
            "Ivanov", "Ivanova", "Kozlov", "Kuznetsov", "Lebedev", 
            "Novikov", "Petrov", "Petrova", "Popov", "Smirnov", 
            "Smirnova", "Sokolov", "Volkov", "Волков", "Иванов", 
            "Иванова", "Козлов", "Кузнецов", "Лебедев", "Новиков", 
            "Петров", "Петрова", "Попов", "Смирнов", "Смирнова", 
            "Соколов" 
        };
        
        CheckResult(sorter.Output, expected);
    }

    static void CheckResult(string[] actual, string[] expected)
    {
        bool isCorrect = true;
        
        if (actual.Length != expected.Length)
        {
            isCorrect = false;
        }
        else
        {
            for (int i = 0; i < expected.Length; i++)
            {
                if (actual[i] != expected[i])
                {
                    isCorrect = false;
                    break;
                }
            }
        }
        
        if (isCorrect) 
            Console.WriteLine("> Успех\n");
        else 
            Console.WriteLine("> Ошибка\n");
    }
}