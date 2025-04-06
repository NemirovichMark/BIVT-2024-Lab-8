using System;
using System.Linq;

namespace Lab_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test_4();
            // Test_3();
            // string input = "Фь!ды – это ущелья, ф!#рующиеся ледника# и заполняющиеся м!ской водой. Наз$ние происходит от древнескандинавского сло$ \"fjǫrðr\". Эти глубокие заливы, окруженные высоки# г!а#, представляют зах$ты$ющие виды и природную красоту. Они популярны среди туристов и известны под разны# наз$ния#: в Н!вегии – \"фь!ды\", в Шотландии – \"фь!дс\", в Исландии – \"фь!дар\". Фь!ды играют $жную роль в культуре и туризме региона, продолжая вдохновлять людей со всего #ра.";
            // string answer = "Фьорды – это ущелья, формирующиеся ледниками и заполняющиеся морской водой. Название происходит от древнескандинавского слова \"fjǫrðr\". Эти глубокие заливы, окруженные высокими горами, представляют захватывающие виды и природную красоту. Они популярны среди туристов и известны под разными названиями: в Норвегии – \"фьорды\", в Шотландии – \"фьордс\", в Исландии – \"фьордар\". Фьорды играют важную роль в культуре и туризме региона, продолжая вдохновлять людей со всего мира.";
            
            // string s1 = "Фьорды – это ущелья, формирующиеся ледниками и заполняющиеся морской водой. Название происходит от древнескандинавского слова \"fjǫrðr\". Эти глубокие заливы, окруженные высокими горами, представляют захватывающие виды и природную красоту. Они популярны среди туристов и известны под разными названиями: в Норвегии – \"фьорды\", в Шотландии – \"фьордс\", в Исландии – \"фьордар\". Фьорды играют важную роль в культуре и туризме региона, продолжая вдохновлять людей со всего мира.";
            // string s2 = "Фьорды – это ущелья, формирующиеся ледниками и заполняющиеся морской водой. Название происходит от древнескандинавского слова миfjǫrðrми. Эти глубокие заливы, окруженные высокими горами, представляют захватывающие виды и природную красоту. Они популярны среди туристов и известны под разными названиями: в Норвегии – мифьордыми, в Шотландии – мифьордсми, в Исландии – мифьордарми. Фьорды играют важную роль в культуре и туризме региона, продолжая вдохновлять людей со всего мира.";
            // Purple_3 p1 = new Purple_3(answer);
            // p1.Review();
            // foreach (var st in p1.Codes){
            //     System.Console.WriteLine(st);
            // }
            // Purple_4 s = new Purple_4(input, p1.Codes);
            // s.Review();
            // System.Console.WriteLine(s.Output);
            // System.Console.WriteLine(s.Output == answer);
            //Test_3();
            // Purple_1 p5 = new Purple_1("William Shakespeare, widely regarded as one of the greatest writers in the English language, authored a total of 37 plays, along with numerous poems and sonnets. He was born in Stratford-upon-Avon, England, in 1564, and died in 1616. Shakespeare's most famous works, including \"Romeo and Juliet,\" \"Hamlet,\" \"Macbeth,\" and \"Othello,\" were written during the late 16th and early 17th centuries. \"Romeo and Juliet,\" a tragic tale of young love, was penned around 1595. \"Hamlet,\" one of his most celebrated tragedies, was written in the early 1600s, followed by \"Macbeth,\" a gripping drama exploring themes of ambition and power, around 1606. \"Othello,\" a tragedy revolving around jealousy and deceit, was also composed during this period, believed to be around 1603.");
            // p5.Review();
            // string output5 = p5.Output;
            // string answer5 = "mailliW eraepsekahS, ylediw dedrager sa eno fo eht tsetaerg sretirw ni eht hsilgnE egaugnal, derohtua a latot fo 37 syalp, gnola htiw suoremun smeop dna stennos. eH saw nrob ni novA-nopu-droftartS, dnalgnE, ni 1564, dna deid ni 1616. s'eraepsekahS tsom suomaf skrow, gnidulcni \"oemoR dna teiluJ,\" \"telmaH,\" \"htebcaM,\" dna \"ollehtO,\" erew nettirw gnirud eht etal 16th dna ylrae 17th seirutnec. \"oemoR dna teiluJ,\" a cigart elat fo gnuoy evol, saw dennep dnuora 1595. \"telmaH,\" eno fo sih tsom detarbelec seidegart, saw nettirw ni eht ylrae 1600s, dewollof yb \"htebcaM,\" a gnippirg amard gnirolpxe semeht fo noitibma dna rewop, dnuora 1606. \"ollehtO,\" a ydegart gnivlover dnuora ysuolaej dna tieced, saw osla desopmoc gnirud siht doirep, deveileb ot eb dnuora 1603.";
            // //Console.WriteLine(output5);
            // //Console.WriteLine(answer5);
            
            // Console.WriteLine(output5 == answer5);
            //Test_2();
            // string input1 = "mailliW eraepsekahS, ylediw dedrager sa eno fo eht tsetaerg sretirw ni eht hsilgnE egaugnal, derohtua a latot fo 37 syalp, gnola htiw suoremun smeop dna stennos. eH saw nrob ni novA-nopu-droftartS, dnalgnE, ni 1564, dna deid ni 1616. s'eraepsekahS tsom suomaf skrow, gnidulcni \"oemoR dna teiluJ,\" \"telmaH,\" \"htebcaM,\" dna \"ollehtO,\" erew nettirw gnirud eht etal 16th dna ylrae 17th seirutnec. \"oemoR dna teiluJ,\" a cigart elat fo gnuoy evol, saw dennep dnuora 1595. \"telmaH,\" eno fo sih tsom detarbelec seidegart, saw nettirw ni eht ylrae 1600s, dewollof yb \"htebcaM,\" a gnippirg amard gnirolpxe semeht fo noitibma dna rewop, dnuora 1606. \"ollehtO,\" a ydegart gnivlover dnuora ysuolaej dna tieced, saw osla desopmoc gnirud siht doirep, deveileb ot eb dnuora 1603.";
            // //string answer = "Двигатель самолета – э$ сложная инж!ерная кон%рукция, обеспечивающая подъем, уп#вл!ие и движ!ие в воздухе. Он сос$ит из множе%ва компон!$в, каждый из ко$рых иг#ет важную роль в общей #боте меха\"зма. Внутр!нее у%рой%во двигателя включает в себя компрессор, камеру сго#\"я, турбину и си%емы уп#вл!ия и охлажд!ия. Принцип #боты основан на воздушно-$пливной смеси, ко$#я подвергается сжатию, восплам!!ию и #сшир!ию, обеспечивая движ!ие воздушного судна.";
            // string input2 = "mailliW eraepsekahS, ylediw dedrager sa eno fo eht tsetaerg sretirw ni eht hsilgnE egaugnal, derohtua a latot fo 37 syalp, gnola htiw suoremun smeop dna stennos. eH saw nrob ni novA-nopu-droftartS, dnalgnE, ni 1564, dna deid ni 1616. s'eraepsekahS tsom suomaf skrow, gnidulcni \"oemoR dna teiluJ,\" \"telmaH,\" \"htebcaM,\" dna \"ollehtO,\" erew nettirw gnirud eht etal 16ht dna ylrae 17ht seirutnec. \"oemoR dna teiluJ,\" a cigart elat fo gnuoy evol, saw dennep dnuora 1595. \"telmaH,\" eno fo sih tsom detarbelec seidegart, saw nettirw ni eht ylrae 1600s, dewollof yb \"htebcaM,\" a gnippirg amard gnirolpxe semeht fo noitibma dna rewop, dnuora 1606. \"ollehtO,\" a ydegart gnivlover dnuora ysuolaej dna tieced, saw osla desopmoc gnirud siht doirep, deveileb ot eb dnuora 1603.";
            // //17th
            // // System.Console.WriteLine($"{input1.Length} - {input2.Length}");
            // // System.Console.WriteLine(input1==input2);
            // Purple_1 s = new Purple_1(input1);
            // s.Review();
            // string output = s.ToString();
            // System.Console.WriteLine(output);
        }
    
        static void Test_4()
        {
            string answer1 = "После многолетних исследований ученые обнаружили тревожную тенденцию в вырубке лесов Амазонии. Анализ данных показал, что основной участник разрушения лесного покрова – человеческая деятельность. За последние десятилетия рост объема вырубки достиг критических показателей. Главными факторами, способствующими этому, являются промышленные рубки, производство древесины, расширение сельскохозяйственных угодий и незаконная добыча древесины. Это приводит к серьезным экологическим последствиям, таким как потеря биоразнообразия, ухудшение климата и угроза вымирания многих видов животных и растений.";
            Purple_3 p1 = new Purple_3(answer1);
            p1.Review();
            Purple_4 p1_1 = new Purple_4(p1.Output, p1.Codes);
            p1_1.Review();
            Console.WriteLine(p1_1.Output == answer1);

            string answer2 = "Двигатель самолета – это сложная инженерная конструкция, обеспечивающая подъем, управление и движение в воздухе. Он состоит из множества компонентов, каждый из которых играет важную роль в общей работе механизма. Внутреннее устройство двигателя включает в себя компрессор, камеру сгорания, турбину и системы управления и охлаждения. Принцип работы основан на воздушно-топливной смеси, которая подвергается сжатию, воспламенению и расширению, обеспечивая движение воздушного судна.";
            Purple_3 p2 = new Purple_3(answer2);
            p2.Review();
            Purple_4 p2_1 = new Purple_4(p2.Output, p2.Codes);
            p2_1.Review();
            Console.WriteLine(p2_1.Output == answer2);

            string answer3 = "1 июля 2015 года Греция объявила о дефолте по государственному долгу, став первой развитой страной в истории, которая не смогла выплатить свои долговые обязательства в полном объеме. Сумма дефолта составила порядка 1,6 миллиарда евро. Этому предшествовали долгие переговоры с международными кредиторами, такими как Международный валютный фонд (МВФ), Европейский центральный банк (ЕЦБ) и Европейская комиссия (ЕК), о программах финансовой помощи и реструктуризации долга. Основными причинами дефолта стали недостаточная эффективность реформ, направленных на улучшение финансовой стабильности страны, а также политическая нестабильность, что вызвало потерю доверия со стороны международных инвесторов и кредиторов. Последствия дефолта оказались глубокими и долгосрочными: сокращение кредитного рейтинга страны, увеличение затрат на заемный капитал, рост стоимости заимствований и утрата доверия со стороны международных инвесторов.";
            Purple_3 p3 = new Purple_3(answer3);
            p3.Review();
            Purple_4 p3_1 = new Purple_4(p3.Output, p3.Codes);
            p3_1.Review();
            Console.WriteLine(p3_1.Output == answer3);

            string answer4 = "Фьорды – это ущелья, формирующиеся ледниками и заполняющиеся морской водой. Название происходит от древнескандинавского слова \"fjǫrðr\". Эти глубокие заливы, окруженные высокими горами, представляют захватывающие виды и природную красоту. Они популярны среди туристов и известны под разными названиями: в Норвегии – \"фьорды\", в Шотландии – \"фьордс\", в Исландии – \"фьордар\". Фьорды играют важную роль в культуре и туризме региона, продолжая вдохновлять людей со всего мира.";
            Purple_3 p4 = new Purple_3(answer4);
            p4.Review();
            Purple_4 p4_1 = new Purple_4(p4.Output, p4.Codes);
            p4_1.Review();
            Console.WriteLine(p4_1.Output == answer4);

            //Console.WriteLine(p4_1.Output);
            //Console.WriteLine(answer4);

            string answer5 = "William Shakespeare, widely regarded as one of the greatest writers in the English language, authored a total of 37 plays, along with numerous poems and sonnets. He was born in Stratford-upon-Avon, England, in 1564, and died in 1616. Shakespeare's most famous works, including \"Romeo and Juliet,\" \"Hamlet,\" \"Macbeth,\" and \"Othello,\" were written during the late 16th and early 17th centuries. \"Romeo and Juliet,\" a tragic tale of young love, was penned around 1595. \"Hamlet,\" one of his most celebrated tragedies, was written in the early 1600s, followed by \"Macbeth,\" a gripping drama exploring themes of ambition and power, around 1606. \"Othello,\" a tragedy revolving around jealousy and deceit, was also composed during this period, believed to be around 1603.";

            Purple_3 p5 = new Purple_3(answer5);
            p5.Review();
            Purple_4 p5_1 = new Purple_4(p5.Output, p5.Codes);
            p5_1.Review();
            Console.WriteLine(p5_1.Output == answer5);

            string answer6 = "Первое кругосветное путешествие было осуществлено флотом, возглавляемым португальским исследователем Фернаном Магелланом. Путешествие началось 20 сентября 1519 года, когда флот, состоящий из пяти кораблей и примерно 270 человек, отправился из порту Сан-Лукас в Испании. Хотя Магеллан не закончил свое путешествие из-за гибели в битве на Филиппинах в 1521 году, его экспедиция стала первой, которая успешно обогнула Землю и доказала ее круглую форму. Это путешествие открыло новые морские пути и имело огромное значение для картографии и географических открытий.";

            Purple_3 p6 = new Purple_3(answer6);
            p6.Review();
            Purple_4 p6_1 = new Purple_4(p6.Output, p6.Codes);
            p6_1.Review();
            Console.WriteLine(p6_1.Output == answer6);


        }


        static void Test_3()
        {
            Purple_3 p1 = new Purple_3("После многолетних исследований ученые обнаружили тревожную тенденцию в вырубке лесов Амазонии. Анализ данных показал, что основной участник разрушения лесного покрова – человеческая деятельность. За последние десятилетия рост объема вырубки достиг критических показателей. Главными факторами, способствующими этому, являются промышленные рубки, производство древесины, расширение сельскохозяйственных угодий и незаконная добыча древесины. Это приводит к серьезным экологическим последствиям, таким как потеря биоразнообразия, ухудшение климата и угроза вымирания многих видов животных и растений.");
            p1.Review();
            string incoded1 = p1.Output;
            string answer1 = "Пос! много!т\"х исс!дова\"й уч#ые обнаружили тревожную т#д#цию в вырубке !сов Амазо\"и. Анализ дан$х показал, что основной уча%\"к разруше\"я !сного покрова – человеческая деятельно%ь. За пос!д\"е десяти!тия ро% объема вырубки до%иг критических показате!й. Глав$ми факторами, способ%вующими этому, являются промыш!н$е рубки, производ%во древеси$, расшире\"е сельскохозяй%в#$х угодий и незаконная добыча древеси$. Это приводит к серьез$м экологическим пос!д%виям, таким как потеря биоразнообразия, ухудше\"е климата и угроза вымира\"я многих видов живот$х и ра%е\"й.";
            Console.WriteLine(answer1 == incoded1);

            


            Purple_3 p2 = new Purple_3("Двигатель самолета – это сложная инженерная конструкция, обеспечивающая подъем, управление и движение в воздухе. Он состоит из множества компонентов, каждый из которых играет важную роль в общей работе механизма. Внутреннее устройство двигателя включает в себя компрессор, камеру сгорания, турбину и системы управления и охлаждения. Принцип работы основан на воздушно-топливной смеси, которая подвергается сжатию, воспламенению и расширению, обеспечивая движение воздушного судна.");
            p2.Review();
            string incoded2 = p2.Output;
            string answer2 = "Двигатель самолета – э$ сложная инж!ерная кон%рукция, обеспечивающая подъем, уп#вл!ие и движ!ие в воздухе. Он сос$ит из множе%ва компон!$в, каждый из ко$рых иг#ет важную роль в общей #боте меха\"зма. Внутр!нее у%рой%во двигателя включает в себя компрессор, камеру сго#\"я, турбину и си%емы уп#вл!ия и охлажд!ия. Принцип #боты основан на воздушно-$пливной смеси, ко$#я подвергается сжатию, восплам!!ию и #сшир!ию, обеспечивая движ!ие воздушного судна.";
            Console.WriteLine(answer2 == incoded2);

            Purple_3 p3 = new Purple_3("1 июля 2015 года Греция объявила о дефолте по государственному долгу, став первой развитой страной в истории, которая не смогла выплатить свои долговые обязательства в полном объеме. Сумма дефолта составила порядка 1,6 миллиарда евро. Этому предшествовали долгие переговоры с международными кредиторами, такими как Международный валютный фонд (МВФ), Европейский центральный банк (ЕЦБ) и Европейская комиссия (ЕК), о программах финансовой помощи и реструктуризации долга. Основными причинами дефолта стали недостаточная эффективность реформ, направленных на улучшение финансовой стабильности страны, а также политическая нестабильность, что вызвало потерю доверия со стороны международных инвесторов и кредиторов. Последствия дефолта оказались глубокими и долгосрочными: сокращение кредитного рейтинга страны, увеличение затрат на заемный капитал, рост стоимости заимствований и утрата доверия со стороны международных инвесторов.");
            p3.Review();
            string incoded3 = p3.Output;
            string answer3 = "1 июля 2015 года Греция объявила о дефолте по государ!венному долгу, !ав первой разви%й !раной в и!ории, ко%рая не смогла выплатить свои долговые обязатель!ва в полном объеме. Сумма дефол$ со!авила порядка 1,6 миллиарда ев\". Э%му предше!вовали долгие переговоры с междуна\"д#ми креди%рами, $кими как Междуна\"д#й валют#й фонд (МВФ), Ев\"пейский централь#й банк (ЕЦБ) и Ев\"пейская комиссия (ЕК), о п\"граммах финансовой помощи и ре!руктуризации долга. Основ#ми причинами дефол$ !али недо!а%чная эффективно!ь реформ, направлен#х на улучшение финансовой !абильно!и !ра#, а $кже политическая не!абильно!ь, ч% вызвало потерю доверия со !о\"# междуна\"д#х инве!о\"в и креди%\"в. Послед!вия дефол$ оказались глубокими и долгос\"ч#ми: сокращение кредитного рейтинга !ра#, увеличение затрат на заем#й капи$л, \"! !оимо!и заим!вований и утра$ доверия со !о\"# междуна\"д#х инве!о\"в.";
            Console.WriteLine(answer3 == incoded3);

            Purple_3 p4 = new Purple_3("Фьорды – это ущелья, формирующиеся ледниками и заполняющиеся морской водой. Название происходит от древнескандинавского слова \"fjǫrðr\". Эти глубокие заливы, окруженные высокими горами, представляют захватывающие виды и природную красоту. Они популярны среди туристов и известны под разными названиями: в Норвегии – \"фьорды\", в Шотландии – \"фьордс\", в Исландии – \"фьордар\". Фьорды играют важную роль в культуре и туризме региона, продолжая вдохновлять людей со всего мира.");
            p4.Review();
            string incoded4 = p4.Output;
            string answer4 = "Фь!ды – это ущелья, ф!#рующиеся ледника# и заполняющиеся м!ской водой. Наз$ние происходит от древнескандинавского сло$ \"fjǫrðr\". Эти глубокие заливы, окруженные высоки# г!а#, представляют зах$ты$ющие виды и природную красоту. Они популярны среди туристов и известны под разны# наз$ния#: в Н!вегии – \"фь!ды\", в Шотландии – \"фь!дс\", в Исландии – \"фь!дар\". Фь!ды играют $жную роль в культуре и туризме региона, продолжая вдохновлять людей со всего #ра.";
            Console.WriteLine(answer4 == incoded4);

            Purple_3 p5 = new Purple_3("William Shakespeare, widely regarded as one of the greatest writers in the English language, authored a total of 37 plays, along with numerous poems and sonnets. He was born in Stratford-upon-Avon, England, in 1564, and died in 1616. Shakespeare's most famous works, including \"Romeo and Juliet,\" \"Hamlet,\" \"Macbeth,\" and \"Othello,\" were written during the late 16th and early 17th centuries. \"Romeo and Juliet,\" a tragic tale of young love, was penned around 1595. \"Hamlet,\" one of his most celebrated tragedies, was written in the early 1600s, followed by \"Macbeth,\" a gripping drama exploring themes of ambition and power, around 1606. \"Othello,\" a tragedy revolving around jealousy and deceit, was also composed during this period, believed to be around 1603.");
            p5.Review();
            string incoded5 = p5.Output;
            string answer5 = "William Shakespeare, widely regard& as one of !e greatest writers $ !e E%lish la%uage, au!or& a total of 37 plays, alo% wi! numerous poems a# sonnets. He was born $ Stratford-upon-Avon, E%la#, $ 1564, a# di& $ 1616. Shakespeare's most famous works, $clud$g \"Romeo a# Juliet,\" \"Hamlet,\" \"Macbe!,\" a# \"O!ello,\" were written dur$g !e late 16! a# early 17! centuries. \"Romeo a# Juliet,\" a tragic tale of you% love, was penn& arou# 1595. \"Hamlet,\" one of his most celebrat& trag&ies, was written $ !e early 1600s, follow& by \"Macbe!,\" a gripp$g drama explor$g !emes of ambition a# power, arou# 1606. \"O!ello,\" a trag&y revolv$g arou# jealousy a# deceit, was also compos& dur$g !is period, believ& to be arou# 1603.";
            Console.WriteLine(answer5 == incoded5);

            Purple_3 p6 = new Purple_3("Первое кругосветное путешествие было осуществлено флотом, возглавляемым португальским исследователем Фернаном Магелланом. Путешествие началось 20 сентября 1519 года, когда флот, состоящий из пяти кораблей и примерно 270 человек, отправился из порту Сан-Лукас в Испании. Хотя Магеллан не закончил свое путешествие из-за гибели в битве на Филиппинах в 1521 году, его экспедиция стала первой, которая успешно обогнула Землю и доказала ее круглую форму. Это путешествие открыло новые морские пути и имело огромное значение для картографии и географических открытий.");
            p6.Review();
            string incoded6 = p6.Output;
            string answer6 = "Первое кругосвет!е путеше\"вие бы# осуще\"вле! ф#том, возглавляемым португальским исследователем Ферна!м Магелла!м. Путеше\"вие нача#сь 20 сентября 1519 года, когда ф#т, со\"оящий из пяти кораблей и пример! 270 че#век, $правился из порту Сан-Лукас в Испании. Х$я Магеллан не закончил свое путеше\"вие из-за гибели в битве на Филиппинах в 1521 году, его экспедиция \"ала первой, к$орая успеш! обогнула Землю и доказала ее круглую форму. Это путеше\"вие $кры# !вые морские пути и име# огром!е значение для картографии и географич%ких $крытий.";
            Console.WriteLine(answer6 == incoded6);
        }

        static void Test_2()
        {
            Purple_2 p1 = new Purple_2("После многолетних исследований ученые обнаружили тревожную тенденцию в вырубке лесов Амазонии. Анализ данных показал, что основной участник разрушения лесного покрова – человеческая деятельность. За последние десятилетия рост объема вырубки достиг критических показателей. Главными факторами, способствующими этому, являются промышленные рубки, производство древесины, расширение сельскохозяйственных угодий и незаконная добыча древесины. Это приводит к серьезным экологическим последствиям, таким как потеря биоразнообразия, ухудшение климата и угроза вымирания многих видов животных и растений.");
            p1.Review();
            string answer1 = "После  многолетних  исследований ученые обнаружили\r\nтревожную  тенденцию  в  вырубке  лесов  Амазонии.\r\nАнализ   данных  показал,  что  основной  участник\r\nразрушения    лесного   покрова   –   человеческая\r\nдеятельность. За последние десятилетия рост объема\r\nвырубки  достиг  критических показателей. Главными\r\nфакторами,    способствующими    этому,   являются\r\nпромышленные    рубки,   производство   древесины,\r\nрасширение     сельскохозяйственных    угодий    и\r\nнезаконная   добыча   древесины.  Это  приводит  к\r\nсерьезным  экологическим  последствиям,  таким как\r\nпотеря биоразнообразия, ухудшение климата и угроза\r\nвымирания   многих   видов  животных  и  растений.";
            string[] ans_out = new string[]{"После  многолетних  исследований ученые обнаружили\n", "тревожную  тенденцию  в  вырубке  лесов  Амазонии.\n"};
            // System.Console.WriteLine(p1.ToString());
            // System.Console.WriteLine();
            // System.Console.WriteLine(answer1);;
            answer1 = answer1.Replace("\r", "");
            foreach(var item in p1.Output)
            {
                Console.WriteLine(item);
            }
            // for(int i = 0; i < 2; i++){
            //     System.Console.WriteLine($"{p1.Output[i].Length} - {ans_out[i].Length}");
            //     System.Console.WriteLine(p1.Output[i]);
            //     System.Console.WriteLine(ans_out[i]);
            // }
            
            string output1 = p1.ToString();
            Console.WriteLine(output1.Length);
            System.Console.WriteLine(answer1.Length);
            System.Console.WriteLine(output1);
            Console.WriteLine(output1 == answer1);

            Purple_2 p2 = new Purple_2("Двигатель самолета – это сложная инженерная конструкция, обеспечивающая подъем, управление и движение в воздухе. Он состоит из множества компонентов, каждый из которых играет важную роль в общей работе механизма. Внутреннее устройство двигателя включает в себя компрессор, камеру сгорания, турбину и системы управления и охлаждения. Принцип работы основан на воздушно-топливной смеси, которая подвергается сжатию, воспламенению и расширению, обеспечивая движение воздушного судна.");
            p2.Review();
            string output2  = p2.ToString();
            string answer2 = "Двигатель   самолета   –  это  сложная  инженерная\r\nконструкция,  обеспечивающая  подъем, управление и\r\nдвижение   в  воздухе.  Он  состоит  из  множества\r\nкомпонентов,  каждый из которых играет важную роль\r\nв  общей  работе  механизма. Внутреннее устройство\r\nдвигателя   включает  в  себя  компрессор,  камеру\r\nсгорания,   турбину   и   системы   управления   и\r\nохлаждения.     Принцип    работы    основан    на\r\nвоздушно-топливной   смеси,  которая  подвергается\r\nсжатию,  воспламенению  и  расширению, обеспечивая\r\nдвижение             воздушного             судна.";
            answer2 = answer2.Replace("\r", "");
            Console.WriteLine(output2.Length);
            Console.WriteLine(output2 == answer2);
            //Console.WriteLine(output2);
            //Console.WriteLine();
            //Console.WriteLine(answer2);

            Purple_2 p3 = new Purple_2("1 июля 2015 года Греция объявила о дефолте по государственному долгу, став первой развитой страной в истории, которая не смогла выплатить свои долговые обязательства в полном объеме. Сумма дефолта составила порядка 1,6 миллиарда евро. Этому предшествовали долгие переговоры с международными кредиторами, такими как Международный валютный фонд (МВФ), Европейский центральный банк (ЕЦБ) и Европейская комиссия (ЕК), о программах финансовой помощи и реструктуризации долга. Основными причинами дефолта стали недостаточная эффективность реформ, направленных на улучшение финансовой стабильности страны, а также политическая нестабильность, что вызвало потерю доверия со стороны международных инвесторов и кредиторов. Последствия дефолта оказались глубокими и долгосрочными: сокращение кредитного рейтинга страны, увеличение затрат на заемный капитал, рост стоимости заимствований и утрата доверия со стороны международных инвесторов.");
            p3.Review();
            string output3 = p3.ToString();
            string answer3 = "1  июля  2015  года  Греция  объявила о дефолте по\r\nгосударственному   долгу,   став  первой  развитой\r\nстраной  в  истории,  которая  не смогла выплатить\r\nсвои долговые обязательства в полном объеме. Сумма\r\nдефолта  составила  порядка  1,6  миллиарда  евро.\r\nЭтому    предшествовали    долгие   переговоры   с\r\nмеждународными     кредиторами,     такими     как\r\nМеждународный  валютный  фонд  (МВФ),  Европейский\r\nцентральный  банк  (ЕЦБ)  и  Европейская  комиссия\r\n(ЕК),    о    программах   финансовой   помощи   и\r\nреструктуризации    долга.   Основными   причинами\r\nдефолта  стали недостаточная эффективность реформ,\r\nнаправленных  на улучшение финансовой стабильности\r\nстраны,  а  также политическая нестабильность, что\r\nвызвало  потерю  доверия  со стороны международных\r\nинвесторов   и   кредиторов.  Последствия  дефолта\r\nоказались  глубокими  и  долгосрочными: сокращение\r\nкредитного  рейтинга  страны, увеличение затрат на\r\nзаемный  капитал,  рост  стоимости заимствований и\r\nутрата    доверия    со    стороны   международных\r\nинвесторов.";
            answer3 = answer3.Replace("\r", "");
            Console.WriteLine(output3.Length);
            Console.WriteLine(output3 == answer3);

            Purple_2 p4 = new Purple_2("Фьорды – это ущелья, формирующиеся ледниками и заполняющиеся морской водой. Название происходит от древнескандинавского слова \"fjǫrðr\". Эти глубокие заливы, окруженные высокими горами, представляют захватывающие виды и природную красоту. Они популярны среди туристов и известны под разными названиями: в Норвегии – \"фьорды\", в Шотландии – \"фьордс\", в Исландии – \"фьордар\". Фьорды играют важную роль в культуре и туризме региона, продолжая вдохновлять людей со всего мира.");
            p4.Review();
            string output4 = p4.ToString();
            string answer4 = "Фьорды  –  это  ущелья,  формирующиеся ледниками и\r\nзаполняющиеся  морской  водой. Название происходит\r\nот   древнескандинавского   слова   \"fjǫrðr\".  Эти\r\nглубокие   заливы,   окруженные  высокими  горами,\r\nпредставляют   захватывающие   виды   и  природную\r\nкрасоту.  Они  популярны среди туристов и известны\r\nпод  разными  названиями: в Норвегии – \"фьорды\", в\r\nШотландии  –  \"фьордс\",  в  Исландии  – \"фьордар\".\r\nФьорды  играют  важную  роль  в культуре и туризме\r\nрегиона,  продолжая  вдохновлять  людей  со  всего\r\nмира.";
            answer4 = answer4.Replace("\r", "");
            Console.WriteLine(output4.Length);
            Console.WriteLine(output4 == answer4);

            Purple_2 p5 = new Purple_2("William Shakespeare, widely regarded as one of the greatest writers in the English language, authored a total of 37 plays, along with numerous poems and sonnets. He was born in Stratford-upon-Avon, England, in 1564, and died in 1616. Shakespeare's most famous works, including \"Romeo and Juliet,\" \"Hamlet,\" \"Macbeth,\" and \"Othello,\" were written during the late 16th and early 17th centuries. \"Romeo and Juliet,\" a tragic tale of young love, was penned around 1595. \"Hamlet,\" one of his most celebrated tragedies, was written in the early 1600s, followed by \"Macbeth,\" a gripping drama exploring themes of ambition and power, around 1606. \"Othello,\" a tragedy revolving around jealousy and deceit, was also composed during this period, believed to be around 1603.");
            p5.Review();
            string output5 = p5.ToString();
            string answer5 = "William Shakespeare, widely regarded as one of the\r\ngreatest writers in the English language, authored\r\na total of 37 plays, along with numerous poems and\r\nsonnets.   He  was  born  in  Stratford-upon-Avon,\r\nEngland,  in 1564, and died in 1616. Shakespeare's\r\nmost  famous  works, including \"Romeo and Juliet,\"\r\n\"Hamlet,\"  \"Macbeth,\"  and \"Othello,\" were written\r\nduring  the  late  16th  and early 17th centuries.\r\n\"Romeo  and  Juliet,\" a tragic tale of young love,\r\nwas  penned around 1595. \"Hamlet,\" one of his most\r\ncelebrated  tragedies,  was  written  in the early\r\n1600s,  followed  by  \"Macbeth,\"  a gripping drama\r\nexploring  themes  of  ambition  and power, around\r\n1606.   \"Othello,\"   a  tragedy  revolving  around\r\njealousy and deceit, was also composed during this\r\nperiod,    believed    to    be    around    1603.";
            answer5 = answer5.Replace("\r", "");
            Console.WriteLine(output5.Length);
            Console.WriteLine(output5 == answer5);

            Purple_2 p6 = new Purple_2("Первое кругосветное путешествие было осуществлено флотом, возглавляемым португальским исследователем Фернаном Магелланом. Путешествие началось 20 сентября 1519 года, когда флот, состоящий из пяти кораблей и примерно 270 человек, отправился из порту Сан-Лукас в Испании. Хотя Магеллан не закончил свое путешествие из-за гибели в битве на Филиппинах в 1521 году, его экспедиция стала первой, которая успешно обогнула Землю и доказала ее круглую форму. Это путешествие открыло новые морские пути и имело огромное значение для картографии и географических открытий.");
            p6.Review();
            string output6 = p6.ToString();
            string answer6 = "Первое  кругосветное путешествие было осуществлено\r\nфлотом, возглавляемым португальским исследователем\r\nФернаном   Магелланом.   Путешествие  началось  20\r\nсентября  1519 года, когда флот, состоящий из пяти\r\nкораблей  и  примерно  270  человек, отправился из\r\nпорту   Сан-Лукас  в  Испании.  Хотя  Магеллан  не\r\nзакончил  свое путешествие из-за гибели в битве на\r\nФилиппинах  в  1521  году,  его  экспедиция  стала\r\nпервой,  которая успешно обогнула Землю и доказала\r\nее  круглую  форму.  Это путешествие открыло новые\r\nморские   пути   и  имело  огромное  значение  для\r\nкартографии     и     географических     открытий.";
            answer6 = answer6.Replace("\r", "");
            Console.WriteLine(output6.Length);
            Console.WriteLine(output6 == answer6);
        }

    }
    
}

