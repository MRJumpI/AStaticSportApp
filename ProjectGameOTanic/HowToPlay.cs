using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectGameOTanic
{
    public partial class HowToPlay : Form
    {
        public string basketballR = " Playing basketball involves two teams, each consisting of five players, aiming to score points by shooting a ball through the opponent's hoop. The game begins with a jump ball at center court. Players pass, dribble, and shoot to advance the ball, with the primary objective of making successful shots into the opponent's basket. The team on offense must navigate the court, utilizing strategies such as pick-and-rolls and fast breaks to create scoring opportunities. On defense, teams aim to prevent their opponents from scoring by blocking shots, stealing the ball, and rebounding missed shots. A standard basketball court is divided into two main sections, each with a hoop positioned 10 feet above the floor. The game is played in quarters, each lasting 12 minutes, and teams switch sides at halftime. Personal fouls, violations, and turnovers result in free throws or turnovers, impacting the flow of the game. Overall, successful basketball play requires a combination of teamwork, skillful ball-handling, accurate shooting, and strategic decision-making.";
        public string vollyballR = "Volleyball is a team sport played by two teams of six players each. The objective is to score points by sending the ball over the net and into the opponent's court in a way that it can't be returned. The game starts with a serve, and teams have three consecutive touches to return the ball. Common techniques include spiking, blocking, and digging. Points are scored on every rally, regardless of which team served. A match usually consists of best-of-five sets, with the first team to reach 25 points (with a two-point advantage) winning a set. If needed, a fifth set is played to 15 points. Volleyball requires teamwork, communication, and quick reflexes, making it an engaging and fast-paced sport.   ";
        public string swimingR = "Swimming is a water sport where individuals propel themselves through water using various strokes. Common strokes include freestyle, breaststroke, backstroke, and butterfly. Competitions may involve individual or relay events, with distances ranging from short sprints to longer races. Swimmers aim to cover the specified distance in the shortest time possible. Starts and turns play a crucial role in competitive swimming. Swimming not only offers a full-body workout but also enhances cardiovascular fitness and endurance. It is vital for swimmers to master techniques, streamline their movements, and maintain efficient breathing. Safety measures, such as lifeguards and proper pool supervision, are essential, especially in open water or larger aquatic environments. Swimming is not only a competitive sport but also a popular recreational activity known for its health benefits.";
        public string soccerR = "To play soccer, you need two teams with 11 players each. The objective is to score goals by kicking a ball into the opponent's net. The game consists of two halves, typically lasting 45 minutes each. Players use their feet, head, or any part of their body except their hands (except for goalkeepers) to control and pass the ball. The team with the most goals at the end of the match wins. Soccer involves skills like dribbling, passing, and shooting, as well as teamwork and strategic positioning. Adhering to rules, such as avoiding fouls and offsides, is crucial. The sport fosters physical fitness, teamwork, and strategic thinking, making it one of the world's most beloved games.";
        public string tenisR = "Tennis is a racquet sport played between two players (singles) or two teams of two players each (doubles). The game is centered around a rectangular court divided by a net. Players take turns serving and receiving the ball, aiming to score points by making the ball land within the opponent's court boundaries. The scoring system includes terms like \"love,\" \"15,\" \"30,\" and \"40.\" A player or team must win four points to secure a game, and a set is won by the first side to reach six games, with a margin of at least two games. Tennis emphasizes skillful shot placement, powerful serves, and quick footwork. Matches can be decided in three sets or five sets for men's Grand Slam events. The sport requires endurance, precision, and strategic thinking. ";
        public string cricketR = "Cricket is a bat-and-ball game played between two teams, typically with 11 players each. The game unfolds on an oval-shaped field with a rectangular 22-yard-long pitch in the center. One team bats while the other bowls and fields, with the aim to score runs or dismiss the opposing team. The batting team tries to protect wickets while scoring runs through various shots, and the bowling team seeks to take wickets and limit the runs scored. Cricket formats vary, but a common one is a match consisting of two innings per team. Each inning involves both teams taking turns to bat and bowl. The team with the most runs at the end of the match wins. Cricket demands a combination of batting, bowling, and fielding skills, and it is known for its strategic nuances and diverse formats, such as Test, One Day Internationals (ODIs), and Twenty20 (T20).";
        public string rugbyR = " Rugby is a contact team sport played between two teams, each consisting of 15 players. The objective is to score points by carrying, passing, or kicking the ball to the opponent's in-goal area or by kicking it through their goalposts. There are two main forms: rugby union and rugby league, each with its own set of rules. In rugby union, there are scrums, lineouts, and rucks, emphasizing continuous play. Rugby league has more structured plays and a limited tackle count. Players can pass the ball backward, but it cannot be thrown forward. Tackling is a fundamental aspect, and possession changes hands frequently. Matches consist of two halves, each lasting 40 minutes in rugby union and 80 minutes in rugby league. Rugby demands physical strength, teamwork, and strategic decision-making, making it a dynamic and challenging sport.";
        public string tabletenisR = "Table tennis, also known as ping pong, is a fast-paced indoor sport played between two or four players. The game involves hitting a lightweight ball back and forth across a rectangular table divided by a net. Players use small paddles, and points are scored when one player fails to return the ball within the rules. A match typically consists of best-of-five or best-of-seven games, with the first player or team to reach 11 points (or 21 points in some cases) winning each game. Table tennis requires quick reflexes, precise hand-eye coordination, and strategic play. Spin and speed are crucial elements, and players often employ various techniques such as topspin, backspin, and smashes. It is a popular recreational and competitive sport known for its fast-paced nature and accessibility. ";
        public string bassballR = "Baseball is a bat-and-ball sport played between two teams, each consisting of nine players. The game is divided into innings, with each team taking turns to bat and play defense. The team at bat aims to score runs by hitting a pitched ball and running around four bases arranged in a diamond shape on the field. The defending team seeks to prevent runs by pitching the ball strategically, fielding, and making outs. Key positions include pitcher, catcher, infielders, and outfielders. A baseball game typically consists of nine innings, and the team with the most runs at the end wins. Baseball requires a combination of hitting, pitching, fielding, and baserunning skills. Known for its strategic nuances and statistical elements, baseball is often referred to as America's pastime and has a rich history in various cultures worldwide. ";
        public string golfR = "Golf is a sport played on a course with 18 holes, though there are also 9-hole variations. The objective is to complete the course in as few strokes as possible. Players use a variety of clubs to hit a small ball into each hole, starting from the tee box. The course includes fairways, roughs, bunkers, and greens. The player with the lowest total number of strokes at the end of the round wins. Golf involves a combination of skills such as driving, chipping, and putting. Each hole has a predetermined par score, representing the ideal number of strokes to complete it. Golf emphasizes precision, strategy, and mental focus, and it is often enjoyed for its social and recreational aspects.";

        public HowToPlay()
        {
            InitializeComponent();
        }

        private void HowToPlay_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            int gameName = cmbGameSelect.SelectedIndex;
            lblGameRule.Text = "";

            switch (gameName)
            {
                /*
                 * Basketball
                    Soccer (Football)
                    Tennis
                    Golf
                    Volleyball
                    Cricket
                    Swimmin:
                    Baseball
                    Table Tennis
                    Rugby
                */
                case 1:
                    lblGameRule.Text = basketballR;
                    break;
                case 2:
                    lblGameRule.Text = soccerR;
                    break;
                case 3:
                    lblGameRule.Text = tenisR;
                    break;
                case 4:
                    lblGameRule.Text = golfR;
                    break;
                case 5:
                    lblGameRule.Text = vollyballR;
                    break;
                case 6:
                    lblGameRule.Text = cricketR;
                    break;
                case 7:
                    lblGameRule.Text = swimingR;
                    break;
                case 8:
                    lblGameRule.Text = basketballR;
                    break;
                case 9:
                    lblGameRule.Text = tabletenisR;
                    break;
                case 10:
                    lblGameRule.Text = rugbyR;
                    break;
                default:

                    break;
            }
        }
    }
}
