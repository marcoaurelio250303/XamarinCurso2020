using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SenhorDosAneis.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Personagem : ContentPage
    {
        public  string NomeImagem { get; set; }
        public string Nome { get; set; }
        public string Conteudo { get; set; }
        public string Raca { get; set; }
        public string  Filho { get; set; }

        public Personagem()
        {
            InitializeComponent();
            ObterDados();
        }

        public Personagem(string nome)
        {
            NomeImagem = nome;
            InitializeComponent();
            ObterDados();
        }

        public  void ObterDados()
        {
            StringBuilder sb = new StringBuilder();

            switch (NomeImagem)
            {
                case "Aragourn":
                    {
                        Nome = "Aragourn II";
                        Filho = "Eldarion";
                        Raca = "Homens";
                        NomeImagem = "Aragorn.jpg";
                        sb.Append("Nome verdadeiro do guardião Passolargo. Descendente da linhagem de Elendil, é filho de Arathorn e herdeiro legítimo em condições de postular o trono de Gondor - cujo governo está nas mãos do regente Denethor, pai de Boromir. É um dos líderes da comitiva do anel.");
                        break;
                    }

                case "Arwen":
                    {
                        Nome = "Arwen Undómiel";
                        Filho = "Eldarion";
                        Raca = "Meio-elfo";
                        NomeImagem = "arwen.jpg";
                        sb.Append("Princesa élfica que se dispõe a abrir mão da imortalidade de seu povo pelo amor a Aragorn. Arwen é uma dos Meio-Elfos que viveram durante a Terceira Era.");
                        break;
                    }
                case "Barbarvore":
                    {
                        Nome = "Barbárvore";
                        Filho = "";
                        Raca = "Ent";
                        NomeImagem = "Barbarvore.jpg";
                        sb.Append("Traduzido do inglês-Treebeard, ou Fangorn em Sindarin, é um personagem fictício gigante de árvore no romance O Senhor dos Anéis, de J. R. R. Tolkien. Ele é um Ent e é dito por Gandalf como 'a coisa mais antiga que ainda anda sob o Sol nesta Terra - média'. Ele vive na antiga floresta de Fangorn, à qual ele deu seu nome");
                        break;
                    }
                case "Balrog":
                    {
                        Nome = "Os Balrogs";
                        Filho = "";
                        Raca = "Demon";
                        NomeImagem = "balrog.jpg";
                        sb.Append(" Maiar seduzidos por Melkor, ou Morgoth, no início de Arda, e que residiam em sua fortaleza no norte, Utumno");
                        break;
                    }
                case "Beregond":
                    {
                        Nome = "Beregond";
                        Filho = "Baranor";
                        Raca = "Homens";
                        NomeImagem = "beregrond.jpg";
                        sb.Append("Beregond, filho de Baranor,foi um soldado de Gondor e mais tarde capitão da Companhia Branca.");
                        break;
                    }
                case "Bilbo":
                    {
                        Nome = "Bilbo Bolseiro";
                        Filho = "";
                        Raca = "Hobbit";
                        NomeImagem = "bilbo.jpg";
                        sb.Append("Hobbit que viveu a grande aventura com os 13 anões relatada no livro 'O Hobbit', que antecede a trilogia de 'O Senhor dos Anéis'. Foi ele quem, através de um truque, apoderou-se do Um Anel, que estava em poder de Gollum, e cujos poderes especiais, como o de conferir a invisibilidade, salvou sua vida diversas vezes.");
                        break;
                    }
                case "Boromir":
                    {
                        Nome = "Boromir";
                        Filho = "Denethor II";
                        Raca = "Homens";
                        NomeImagem = "boromir.jpg";
                        sb.Append("Boromir, da raça dos homens, foi Capitão-General de Gondor e fez parte da 'Sociedade do Anel'. Era o filho mais velho de Denethor II, o último governante Regente de Gondor, e irmão de Faramir.");
                        break;
                    }
                case "Celeborn":
                    {
                        Nome = "Celeborn";
                        Filho = "";
                        Raca = "Elfo";
                        NomeImagem = "Celeborn.png";
                        sb.Append("Aparece em O Senhor dos Anéis como o elfo marido de Galadriel, Senhor de Galadhrim, e co-governante junto com sua esposa de Lothlórien. Era o pai de Celebrían, e, portanto, o avô de Arwen Undómiel e seus irmãos gêmeos e primogênitos, Elladan e Elrohir");
                        break;
                    }
                case "Denethor":
                    {
                        Nome = "Denethor II";
                        Filho = "Eldarion";
                        Raca = "Homens";
                        NomeImagem = "Denethor_II.png";
                        sb.Append("Traduzido do inglês-Denethor II, filho de Ecthelion II, é um personagem fictício do romance de J. R. R. Tolkien, O Senhor dos Anéis. Ele foi o 26º mordomo dominante de Gondor, cometendo suicídio na cidade sitiada de Minas Tirith durante a batalha dos campos de Pelennor");
                        break;
                    }
                case "Eomer":
                    {
                        Nome = "Éomer";
                        Filho = "";
                        Raca = "Homens";
                        NomeImagem = "Eomer.png";
                        sb.Append("Traduzido do inglês-Éomer é um personagem fictício da Terra-média de J. R. R. Tolkien. Ele aparece em O Senhor dos Anéis como um líder dos Cavaleiros de Rohan. O nome Éomer, que significa 'cavalo famoso' em anglo-saxão, ocorre em Beowulf, na linha de 1959, como o de um rei descendente de Offa da Mércia");
                        break;
                    }
                case "Elrond":
                    {
                        Nome = "Elrond";
                        Filho = "Eärendil";
                        Raca = "Meio-elfo";
                        NomeImagem = "Elrond_of_Rivendell.jpg";
                        sb.Append("Elrond é o governante de Rivendell e um dos principais protagonistas de O Senhor dos Anéis e O Hobbit." +
                            " Ele é um meio-elfo de Beleriand. Ele é filho de Eärendil Half-Elven e Elwing. Ele é um dos principais protagonistas de " +
                            "O Senhor dos Anéis: A Sociedade do Anel, um protagonista menor em O Senhor dos Anéis: " +
                            "As Duas Torres e um protagonista coadjuvante em O Senhor dos Anéis: O Retorno do Rei. " +
                            "Ele também é um protagonista coadjuvante em O Hobbit: Uma Jornada Inesperada e um protagonista menor " +
                            "em O Hobbit: A Batalha dos Cinco Exércitos.");
                        break;
                    }
                case "Elendil":
                    {
                        Nome = "Elendil";
                        Filho = "";
                        Raca = "";
                        NomeImagem = "Elendil.jpg";
                        sb.Append("Elendil foi um dos maiores guerreiros dos Homens que já viveram. Ele ")
                          .Append("liderou os exilados de Númenor que partiram para a Terra - média e")
                          .Append("sobreviveram ao seu afundamento, e lá fundou os reinos de Anor e")
                          .Append("Gondor.Foi ainda um dos comandantes das tropas da Última Aliança e,")
                          .Append("juntamente com Gil - Galad, venceu o próprio Sauron em combate, pondo um")
                          .Append("fim ao seu reinado de terror por centenas de anos");
                        break;
                    }
                case "Eldarion":
                    {
                        Nome = "Eldarion";
                        Filho = "Aragourn";
                        Raca = "Homens/Elfos";
                        NomeImagem = "Eldarion.jpg";
                        sb.Append("Filho de Aragorn e Arwen.A data do nascimento de Eldarion não é conhecida.Ele era o único filho e herdeiro de Aragorn, o Rei Elessar.Eldarion tinha várias irmãs cujos nomes não são conhecidos.");
                        break;
                    }
                case "Frodo":
                    {
                        Nome = "Frodo Bolseiro";
                        Filho = "";
                        Raca = "Hobbit";
                        NomeImagem = "frodo.jpg";
                        sb.Append("Frodo Bolseiro ou Frodo Underhill O herói da saga, o hobbit portador do Um Anel - aquele capaz de controlar todos os demais. Primo de Bilbo, de quem herda o anel e a missão de conduzi-lo à destruição, para evitar a vitória do reino das sombras e a volta de Sauron.");
                        break;
                    }
                case "Faramir":
                    {
                        Nome = "Faramir";
                        Filho = "";
                        Raca = "Homens";
                        NomeImagem = "faramir.jpg";
                        sb.Append(" Faramir é um personagem fictício que aparece em O Senhor dos Anéis. Ele é apresentado como o irmão mais novo de Boromir da Irmandade do Anel e o segundo filho de Denethor II, o mordomo do reino de Gondor");
                        break;
                    }
                case "Fredegar":
                    {
                        Nome = "Fredegar Bolger";
                        Filho = "Odovacar Bolger";
                        Raca = "Hobbits";
                        NomeImagem = "fredegar.png";
                        sb.Append("Fatty era descendente de Hildibrand Took (T.A. 2849 - T.A. 2934), um dos muitos filhos do Velho Levou. [2] Ele era filho de Odovacar Bolger e Rosamunda Took. Fatty nasceu em T.A. 2980 e sua família era de Budgeford em Bridgefields do Eastfarthing. Ele também tinha uma irmã mais nova, Estella Bolger (b. T.A. 2985), que eventualmente se casaria com Meriadoc Brandybuck.");
                        break;
                    }
                case "Galadriel":
                    {
                        Nome = "Galadriel";
                        Filho = "Elrond";
                        Raca = "Elfos";
                        NomeImagem = "galadriel.jpeg";
                        sb.Append("Senhora de Lóthlorien, dotada de grande beleza, sabedoria e poderes mágicos. Também é guardiã de um anel, Nenya, o Anel de Diamante, um dos três destinados aos reis-elfos. Mulher de Celeborn. Galadriel é uma personagem criada por J.R.R. Tolkien, em seu legendárium da Terra Média. Ela aparece em O Senhor dos Anéis, O Silmarillion e Contos Inacabados");
                        break;
                    }
                case "Gandalf":
                    {
                        Nome = "Gandalf o Cinzento";
                        Filho = "";
                        Raca = "Maia";
                        NomeImagem = "Gandalf.jpg";
                        sb.Append("por vezes Gandalf, o Cinzento ou Gandalf, o Branco é um personagem fictício das obras do autor, professor e filólogo britânico J. R. R. Tolkien. "); ;
                        break;
                    }
                case "Gamling":
                    {
                        Nome = "Gamling";
                        Filho = "";
                        Raca = "Homens";
                        NomeImagem = "Gamling9.jpg";
                        sb.Append("Um velho durante a Guerra do Anel, Gamling ainda era uma presença dominante na época da Batalha de Hornburg. Durante a batalha Gamling foi o primeiro a perceber que Orcs tinha penetrado o Deep através de seu bueiro, e ele mesmo liderou o contra-ataque.")
                          .Append("Gamling parece ter sido criado nos vales ocidentais de Rohan; ele entendeu a língua de Dunland que ainda era falado nessas regiões. [2]")
                          .Append(" Quando a Muralha deeping foi tomada, Gamling foi um daqueles varridos de volta para as estreitas.Quando a batalha acabou Gamling, Éomer, Gimli e outros saíram das cavernas. [3");
                        break;
                    }
                case "Gimli":
                    {
                        Nome = "Gimli";
                        Filho = "Glóin ";
                        Raca = "Anões";
                        NomeImagem = "Gimli.jpg";
                        sb.Append("Anão, filho de Glóin (um dos 13 anões que viveram a grande aventura com Bilbo Bolseiro). Forte e valente, usa o seu machado com grande perícia nas batalhas contra os orcs. Mas ainda tem para resolver uma velha pendência de seu povo contra os elfos.");
                        break;
                    }
                case "Glorfindel":
                    {
                        Nome = "Glorfindel";
                        Filho = "";
                        Raca = "Hobbit";
                        NomeImagem = "glorfindel.jpg";
                        sb.Append("Glorfindel era alto e ereto; o cabelo de um dourado brilhante, o rosto belo e jovem, temerário e cheio de alegria; os olhos eram brilhantes e agudos, a voz parecia música; em sua fronte se alojava a sabedoria; na mão, a força.")	
                          .Append("Glorfindel é um dos altos elfos da primeira era e uma vez foi o Senhor da Casa da Flor Dourada, em Gondolin.Na Primeira Era ele enfrentou um Balrog em Cirith Thoronath, mas caiu no abismo e morreu ali.Manwë o restaurou e permitiu que Glorfindel retornasse a sua forma física, ");
                        break;
                    }
                case "Gollum / Sméagol":
                    {
                        Nome = "Gollum";
                        Filho = "Eldarion";
                        Raca = "Meio-elfo";
                        NomeImagem = "golun.png";
                        sb.Append("Nome pelo qual é conhecido aquele que já se chamou Sméagol. Criatura sombria, vivia numa ilha de pedra, num lago frio sob as minas dos orcs e se tornara dono do Um Anel, até que o hobbit Bilbo o enganou, apossando-se da jóia");
                        break;
                    }
                case "Grima":
                    {
                        Nome = "Gríma";
                        Filho = "";
                        Raca = " Men of Rohan";
                        NomeImagem = "grima.png";
                        sb.Append("Traduzido do inglês-Gríma, chamado Língua de Cobra, é um personagem fictício de O Senhor dos Anéis, de J. R. R. Tolkien. Ele aparece no segundo e terceiro volumes da obra, As Duas Torres e O Retorno do Rei, e seu papel é expandido em Contos Inacabados");
                        break;
                    }
                case "Harry":
                    {
                        Nome = "Harry Goatleaf";
                        Filho = "";
                        Raca = "Homens";
                        NomeImagem = "Harry_Goatleaf.jpg";
                        sb.Append("Harry Goatleaf era um homem de Bree e membro da Família Goatleaf. Ele trabalhava como guardião do portão oeste na grande cerca que cercava a cidade de Bree.")
                          .Append("Como tal, ele foi o primeiro dos Homens(Big Folk) encontrado por Frodo e seus companheiros em suas viagens durante a Guerra do Anel - ele os cumprimentou rispidamente em sua chegada à cidade.Mais tarde, ele estava presente no Pônei Prancing fazendo ações suspeitas, como mais tarde foi descoberto que ele estava sob o poder do Nazgûl. [1]")
                          .Append("Alguns meses após a partida dos hobbits, Harry, juntamente com Bill Ferny,juntou - se a um bando de bandidos do sul, causando problemas que deixaram cinco dos bree - landers mortos. [2] Depois disso, ele deixou Bree com outros rufiões, presumivelmente para se juntar aos Homens de Sharkey no Shire.");
                        break;
                    }
                case "Laracna":
                    {
                        Nome = "Laracna, a Grande";
                        Filho = "";
                        Raca = "Demon";
                        NomeImagem = "laracna.jpg";
                        sb.Append("Traduzido do inglês-Shelob é um demônio fictício na forma de uma aranha gigante de O Senhor dos Anéis, de J. R. R. Tolkien. Seu covil fica em Cirith Ungol, levando a Mordor. Gollum deliberadamente leva Frodo Bolseiro para lá na esperança de recuperar o Um Anel quando Shelob ataca Frodo.");
                        break;
                    }
                case "Legolas":
                    {
                        Nome = "Legolas";
                        Filho = "Thranduil";
                        Raca = "Elfo Sindar";
                        NomeImagem = "legolas.jpg";
                        sb.Append("Elfo dos povos do norte, usa com grande pontaria o seu inseparável arco, com o qual dispara flechas certeiras contra os orcs e outros inimigos de Gondor.");
                        break;
                    }
                case "Pippin":
                    {
                        Nome = "Peregrin Took";
                        Filho = "Faramir Took";
                        Raca = "Hobbit";
                        NomeImagem = "Pippinprintscreen.jpg";
                        sb.Append("Traduzido do inglês-Peregrin Took, vulgarmente conhecido simplesmente como Pippin. Ele está intimamente ligado ao amigo e primo, Merry Brandybuck, e os dois estão juntos durante a maior parte da história");
                        break;
                    }
                case "Meriadoc":
                    {
                        Nome = "Meriadoc Brandebuque";
                        Filho = "";
                        Raca = "Hobbit";
                        NomeImagem = "merry.png";
                        sb.Append("Traduzido do inglês-Meriadoc Brandybuck, geralmente chamado de Merry, é um personagem fictício do legendarium da Terra Média de J.R. Tolkien, apresentado em seu trabalho mais famoso, O Senhor dos Anéis. Merry é descrito como um dos amigos mais próximos de Frodo Bolseiro, o principal protagonista");
                        break;
                    }

                case "Nazgul":
                    {
                        Nome = "Os Nazgûl";
                        Filho = "";
                        Raca = "Homens";
                        NomeImagem = "nasguls.jpg";
                        sb.Append("Eram nove homens que sucumbiram ao poder de Sauron e quase atingiram a imortalidade como fantasmas, funcionários ligados ao poder do Um Anel");
                        break;
                    }
                case "Samwise":
                    {
                        Nome = "Samwise Gamgee";
                        Filho = "Hamfast";
                        Raca = "Hobbit";
                        NomeImagem = "Samwise_the_Brave.jpg";
                        sb.Append("Hobbit que é o mais fiel servidor de Frodo e cujo empenho será essencial ao cumprimento da missão do mestre.");
                        break;
                    }
                case "Sauron":
                    {
                        Nome = "Sauron";
                        Filho = "";
                        Raca = "Maia";
                        NomeImagem = "sauron.png";
                        sb.Append("é um personagem do universo fictício da Terra-média criado por J.R.R. Tolkien, antagonista da trilogia: O Senhor dos Anéis. Sauron também aparece como o Necromante no Hobbit e como tenente de Morgoth na obra Silmarillion");
                        break;
                    }
                case "Saruman":
                    {
                        Nome = "Saruman, o Branco";
                        Filho = "";
                        Raca = "Maia";
                        NomeImagem = "suraman.jpegg";
                        sb.Append("Velho mago, mestre da ordem de Gandalf e seu conselheiro, cai sob a influência maligna de Sauron e torna-se líder do reino das sombras.");
                        break;
                    }
                case "Reibruxo":
                    {
                        Nome = "Rei bruxo de Angmar";
                        Filho = "";
                        Raca = "";
                        NomeImagem = "ReiBruxodeAgmar.jpg";
                        sb.Append("");
                        break;
                    }
                case "Radagast":
                    {
                        Nome = "Radagast";
                        Filho = "";
                        Raca = "Maia";
                        NomeImagem = "Radagast_the_Brown.jpg";
                        sb.Append("Radagast, o Castanho, ou Aiwendil, é um personagem fictício das obras do professor e filólogo britânico J. R. R. Tolkien. Ele é um dos Istari, também conhecidos como 'Magos', que foram enviados pelos espíritos Valar para ajudar os Elfos e os Homens da Terra Média em sua luta contra o Senhor das Trevas, Sauron");
                        break;
                    }
                case "Velho_Salgueiro":
                    {
                        Nome = "Velho Salgueiro-homem";
                        Filho = "";
                        Raca = "";
                        NomeImagem = "Velhosalqueiro.png";
                        sb.Append("De acordo com Tom Bombadil, há muito tempo atrás no começo dos tempos na Terra-média, " +
                            "muito antes do Despertar dos Elfos, as árvores eram os únicos habitantes das vastas áreas do mundo. " +
                            "Pelo fato de os Elfos terem despertado no extremo Oriente, houve ainda um tempo considerável antes de" +
                            " quaisquer outros seres se espalharem pelas vastas matas virgens do oeste da Terra-média. Um punhado de árvores " +
                            "sobreviveram desde essa ápoca até os dias atuais, que se enfureceram pela invasão dos Elfos e Homens e seu domínio " +
                            "sobre a terra; árvores que amargamente se lembram de um tempo muito distante quando elas eram como Senhores das vastas regiões do mundo." +
                            " Tom Bombadil relata que dentre as árvores corrompidas da Velha Floresta, 'nenhuma era mais perigosa do que o Grande Salgueiro; " +
                            "seu coração havia apodrecido, porém sua força era ainda jovem; e ele era esperto, e um mestre dos ventos, e sua canção e pensamento " +
                            "corriam pelas florestas em ambos os lados do rio; seu espírito cinza sedento sugava poder da terra e se espalhava como raízes pelo chão, " +
                            "e invisíveis galhos-dedos no ar, até ter sob seu domínio quase todas as árvores da Floresta até as Colinas Tumulares.");
                        break;
                    }
                case "Tom_Bombadil":
                    {
                        Nome = "Tom Bombadil";
                        Filho = "";
                        Raca = "";
                        NomeImagem = "Tom_Bombadil_2.jpg";
                        sb.Append("Tom Bombadil é um personagem fictício coadjuvante criado por J. R. R. Tolkien na fantasia épica O Senhor dos Anéis, publicado entre 1954 e 1955. No primeiro volume do livro, The Fellowship of the Ring, Frodo Bolseiro e companhia encontram Bombadil na Floresta Velha");
                        break;
                    }
                case "Theoden":
                    {
                        Nome = "Théoden";
                        Filho = "Théodred";
                        Raca = "Homens";
                        NomeImagem = "theoden_1.jpg";
                        sb.Append("Traduzido do inglês-Théoden é um personagem fictício do romance de fantasia de J. R. R. Tolkien, O Senhor dos Anéis. O rei e o senhor da marca de Rohan, ele aparece como um importante personagem coadjuvante em As duas torres e O retorno do rei");
                        break;
                    }

                default:
                    break;
            }
            Conteudo = sb.ToString();
            conteudoPersonagem.Text = Conteudo;
            nomePersonagem.Text = Nome;
            raca.Text = Raca;
            filho.Text = Filho;
            imagemPersonagem.Source = NomeImagem;
        }
    }
}