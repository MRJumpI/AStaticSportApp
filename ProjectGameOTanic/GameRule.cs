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
    public partial class GameRule : Form
    {
        public string basketballR = "<p><strong>1. The Objective:</strong>The primary objective is to score more points than the opposing team by shooting the ball through the opponent's basket.  </p>\r\n<p><strong>2. Teams:</strong> Each team consists of five players on the court at a time.</p>\r\n<p><strong>3. Scoring:</strong> Two or three points for field goals, one point for free throws, and three points for shots made beyond the three-point arc.</p>\r\n<p><strong>4. Game Duration:</strong> Four quarters, each lasting 12 minutes (NBA).</p>\r\n<p><strong>5. Possession:</strong> Teams alternate possession, starting with a jump ball. Non-scoring team gets possession after each score.</p>\r\n<p><strong>6. Shot Clock:</strong> A shot clock (e.g., 24 seconds in the NBA) requires teams to attempt a shot within a specified time.</p>\r\n<p><strong>7. Dribbling:</strong> Players must dribble while moving, and after stopping, they can only pivot on one foot.</p>\r\n<p><strong>8. Fouls:</strong> Physical contact hindering an opponent results in a foul. Accumulating fouls may lead to player disqualification.</p>\r\n<p><strong>9. Free Throws:</strong> Awarded for certain fouls; players shoot unopposed from the free-throw line.</p>\r\n<p><strong>10. Violations:</strong> Common violations include traveling, double dribble, and goaltending.</p>";
        public string vollyballR = "<p><strong>1. Court Dimensions:</strong> Volleyball courts have specific dimensions with attack lines, net heights, and playing areas.</p>\r\n<p><strong>2. Teams:</strong> Each volleyball team typically consists of six players on the court at a time.</p>\r\n<p><strong>3. Scoring System:</strong> Points are scored on every rally, with a match typically played as best out of five sets.</p>\r\n<p><strong>4. Serve Rotation:</strong> Players must rotate positions clockwise after winning the serve from the opposing team.</p>\r\n<p><strong>5. Substitutions:</strong> Teams can make player substitutions during stoppages in play, notifying the referee of any changes.</p>\r\n<p><strong>6. Passing:</strong> Players use forearm passes, overhead passes, and attacks to move the ball over the net to the opponent's side.</p>\r\n<p><strong>7. Net Violations:</strong> Touching the net or reaching over the net into the opponent's playing area is considered a violation.</p>\r\n<p><strong>8. Blocking:</strong> Players can use blocks to deflect the ball back into the opponent's side during an attack, but they must not touch the net.</p>\r\n<p><strong>9. Side Out:</strong> When the serving team fails to score a point, the receiving team gains the right to serve, known as a side out.</p>\r\n<p><strong>10. Libero:</strong> A designated libero player can replace any back-row player without prior notice and is specialized in defensive skills.</p> ";
        public string swimingR = "<p><strong>1. Pool Dimensions:</strong> Swimming competitions take place in pools with specified lengths and lanes.</p>\r\n<p><strong>2. Swimming Strokes:</strong> Competitive swimmers use various strokes, including freestyle, backstroke, breaststroke, and butterfly.</p>\r\n<p><strong>3. Individual Medley (IM):</strong> The IM combines all four strokes in a specific order (butterfly, backstroke, breaststroke, and freestyle).</p>\r\n<p><strong>4. Starts and Turns:</strong> Swimmers utilize starting blocks and execute turns at the pool walls for efficient race performance.</p>\r\n<p><strong>5. Lane Etiquette:</strong> Swimmers stay in their designated lanes, and each lane accommodates a specific number of competitors.</p>\r\n<p><strong>6. Relay Races:</strong> Teams of swimmers participate in relay races, with each member swimming a designated distance in a specific stroke.</p>\r\n<p><strong>7. Timing:</strong> Precise electronic timing systems record swimmer performances, often measured to the hundredth of a second.</p>\r\n<p><strong>8. Flip Turns:</strong> Swimmers perform flip turns at the pool wall to change direction efficiently and minimize time in races.</p>\r\n<p><strong>9. Disqualifications:</strong> Swimmers can be disqualified for infractions such as false starts, improper strokes, or not touching the wall during turns.</p>\r\n<p><strong>10. Open Water Swimming:</strong> In addition to pool competitions, swimmers participate in open water events in lakes, rivers, or oceans.</p> ";
        public string soccerR = "<p><strong>1. Field Dimensions:</strong> The soccer field should adhere to standard dimensions, including goalposts and penalty areas.</p>\r\n<p><strong>2. Team Size:</strong> Each soccer team consists of 11 players, including one goalkeeper.</p>\r\n<p><strong>3. Scoring:</strong> A goal is scored when the entire ball crosses the goal line between the goalposts and beneath the crossbar.</p>\r\n<p><strong>4. Game Duration:</strong> Soccer matches are typically divided into two halves, each lasting 45 minutes, with a halftime break.</p>\r\n<p><strong>5. Offside Rule:</strong> A player is offside if they are nearer to the opponent's goal line than both the ball and the second-to-last defender.</p>\r\n<p><strong>6. Throw-ins:</strong> When the ball goes out of play over the touchlines, it is restarted with a throw-in from the spot where it went out.</p>\r\n<p><strong>7. Corner Kicks:</strong> Awarded when the defending team plays the ball out of bounds over its goal line. The attacking team kicks the ball from the corner arc.</p>\r\n<p><strong>8. Fouls:</strong> Fouls result from illegal actions, and free kicks or penalty kicks are awarded depending on the severity and location of the offense.</p>\r\n<p><strong>9. Yellow and Red Cards:</strong> Referees use yellow cards to caution players and red cards to send them off for serious misconduct.</p>\r\n<p><strong>10. Goal Kick:</strong> Awarded to the defending team when the attacking team kicks the ball out over the goal line. The ball is kicked back into play from the goal area.</p> ";
        public string tenisR = " <p><strong>1. Court Dimensions:</strong> Tennis courts have specific dimensions with baseline, service boxes, and net placements.</p>\r\n<p><strong>2. Singles and Doubles:</strong> Tennis can be played as singles (one player per side) or doubles (two players per side).</p>\r\n<p><strong>3. Scoring System:</strong> The scoring system includes points, games, and sets. The first to win a certain number of sets wins the match.</p>\r\n<p><strong>4. Serve Rotation:</strong> Players take turns serving, with each game starting from the baseline and alternating service sides.</p>\r\n<p><strong>5. Faults and Double Faults:</strong> A player must serve within the service box, and failing to do so results in faults. Two consecutive faults lead to a double fault.</p>\r\n<p><strong>6. Points System:</strong> Points are scored as 15, 30, 40, and game. Deuce occurs at 40-40, and advantage-in and advantage-out are used to determine game point.</p>\r\n<p><strong>7. Tiebreak:</strong> In some sets, a tiebreak is used to decide the winner when the game score reaches a set-specific tiebreak score (e.g., first to seven points).</p>\r\n<p><strong>8. Ball in and Out:</strong> A point is won when the opponent fails to return the ball within the court boundaries.</p>\r\n<p><strong>9. Let:</strong> If the ball hits the net during a serve but lands in the service box, it is called a let, and the serve is retaken.</p>\r\n<p><strong>10. Changeovers and Sets:</strong> Players change ends after every odd game and switch sides after each set.</p>";
        public string cricketR = "<p><strong>1. Pitch and Field Dimensions:</strong> Cricket is played on a circular field with a rectangular 22-yard pitch at the center.</p>\r\n<p><strong>2. Teams:</strong> Each cricket team consists of eleven players, with one team batting while the other bowls and fields.</p>\r\n<p><strong>3. Innings:</strong> A cricket match consists of two innings, with each team having a turn to bat and bowl.</p>\r\n<p><strong>4. Batting:</strong> Batsmen score runs by hitting the ball and running between the two wickets or hitting boundaries (four or six runs).</p>\r\n<p><strong>5. Bowling:</strong> Bowlers aim to dismiss batsmen by delivering the ball within the prescribed legal action and targeting the stumps.</p>\r\n<p><strong>6. Wickets:</strong> Three stumps topped by two bails make up the wicket; bowlers aim to hit the stumps to dismiss a batsman.</p>\r\n<p><strong>7. Runs and Extras:</strong> Runs scored by batsmen and extras (like wides and no-balls) contribute to the team's total.</p>\r\n<p><strong>8. Fielding Positions:</strong> Players are strategically placed on the field for various bowling and batting situations.</p>\r\n<p><strong>9. Duckworth-Lewis Method:</strong> In rain-affected matches, the Duckworth-Lewis method adjusts target scores for the team batting second.</p>\r\n<p><strong>10. Umpires and Decision Review System (DRS):</strong> Umpires make on-field decisions, and teams can challenge these decisions using the DRS for reviews.</p> ";
        public string rugbyR = " <p><strong>1. Field Dimensions:</strong> Rugby is played on a rectangular field with specific dimensions, featuring goalposts at each end.</p>\r\n<p><strong>2. Teams:</strong> Each rugby team consists of 15 players divided into forwards and backs, engaging in both offensive and defensive roles.</p>\r\n<p><strong>3. Scoring:</strong> Points are scored by carrying or kicking the ball over the opponent's goal line or by kicking through the goalposts during play.</p>\r\n<p><strong>4. Try:</strong> The primary method of scoring, a try is awarded when a player grounds the ball in the opponent's in-goal area.</p>\r\n<p><strong>5. Conversion:</strong> After a try, the scoring team has the opportunity to kick the ball through the goalposts for additional points.</p>\r\n<p><strong>6. Lineout:</strong> Occurs when the ball goes out of bounds, and teams compete to lift a player to catch a throw-in and regain possession.</p>\r\n<p><strong>7. Scrum:</strong> A set piece where players bind together, competing for possession by pushing against the opposing team.</p>\r\n<p><strong>8. Ruck:</strong> Forms when the ball is on the ground, and players from both teams bind together, attempting to secure possession with their feet.</p>\r\n<p><strong>9. Maul:</strong> Similar to a ruck, but involving players on their feet, pushing and shoving to gain territory and possession.</p>\r\n<p><strong>10. Penalties and Free Kicks:</strong> Referees award penalties or free kicks for rule infringements, allowing the non-offending team to advance or kick for goal.</p>";
        public string tabletenisR = " <p><strong>1. Table Dimensions:</strong> Table tennis is played on a rectangular table divided by a net, with specific dimensions for length, width, and height.</p>\r\n<p><strong>2. Singles and Doubles:</strong> Matches can be played as singles (one player per side) or doubles (two players per side).</p>\r\n<p><strong>3. Scoring System:</strong> Points are scored on every rally, with games played to 11 or 21 points, depending on the competition.</p>\r\n<p><strong>4. Serve Rules:</strong> The ball must be tossed at least six inches before serving, and the serve must travel diagonally over the net.</p>\r\n<p><strong>5. Rallying:</strong> Players alternate hitting the ball over the net, and the ball must bounce on each side of the table once during a rally.</p>\r\n<p><strong>6. Let and Net:</strong> A let is called if the ball hits the net during a serve but lands in the correct service court. If the ball hits the net during a rally, the point is replayed.</p>\r\n<p><strong>7. Scoring System:</strong> Points are scored when the opponent fails to return the ball within the boundaries of the opponent's side of the table.</p>\r\n<p><strong>8. Deuce:</strong> When the score reaches 10-10, players continue to play until one player gains a two-point advantage to win the game.</p>\r\n<p><strong>9. Expedite System:</strong> In certain situations, a 10-minute rule is applied to expedite the game, ensuring a result within a reasonable time.</p>\r\n<p><strong>10. Penalties:</strong> Penalties may be given for various infractions, such as hitting the ball out of turn or obstructing the opponent's view.</p>";
        public string bassballR = "<p><strong>1. Field Layout:</strong> Baseball is played on a diamond-shaped field with bases placed at each corner.</p>\r\n<p><strong>2. Teams:</strong> Each baseball team has nine players on the field at a time, divided into offensive and defensive roles.</p>\r\n<p><strong>3. Innings:</strong> A baseball game consists of nine innings, with each team taking turns to bat and play defense.</p>\r\n<p><strong>4. Batting:</strong> The offensive team attempts to score runs by hitting the pitched ball and running around the bases in a counter-clockwise direction.</p>\r\n<p><strong>5. Pitching:</strong> The pitcher throws the ball to the batter from the pitcher's mound, aiming to strike out the batter or induce outs through hits.</p>\r\n<p><strong>6. Strikes, Balls, and Fouls:</strong> The count determines the outcome of each pitch, with strikes, balls, and fouls influencing the batter's fate.</p>\r\n<p><strong>7. Baserunning:</strong> Runners advance around the bases, aiming to reach home plate and score a run while avoiding being tagged out.</p>\r\n<p><strong>8. Fielding:</strong> The defensive team positions players strategically to field hits, catch fly balls, and throw out runners.</p>\r\n<p><strong>9. Extra Innings:</strong> In the case of a tied game after nine innings, extra innings are played until a winner is determined.</p>\r\n<p><strong>10. Umpires:</strong> Umpires officiate the game, making decisions on strikes, balls, and plays, ensuring fair play and adherence to the rules.</p> ";
        public string golfR= " <p><strong>1. Course Layout:</strong> Golf courses consist of 18 holes, each with teeing areas, fairways, hazards, and greens.</p>\r\n<p><strong>2. Teeing Off:</strong> Players start each hole from designated teeing areas, aiming to get the ball into the fairway with the fewest strokes.</p>\r\n<p><strong>3. Stroke Play and Match Play:</strong> Golf can be played in stroke play, where the total number of strokes is counted, or match play, where each hole is a separate competition.</p>\r\n<p><strong>4. Par:</strong> Each hole is assigned a par value, representing the expected number of strokes a skilled golfer should take to complete the hole.</p>\r\n<p><strong>5. Scoring:</strong> Scores are recorded in relation to par. A score under par is a birdie, while a score over par is a bogey.</p>\r\n<p><strong>6. Hazards:</strong> Hazards such as bunkers and water obstacles add complexity to the course, requiring strategic play.</p>\r\n<p><strong>7. Putting:</strong> Players use a putter on the green to complete the hole, aiming to sink the ball into the cup in the fewest strokes possible.</p>\r\n<p><strong>8. Etiquette:</strong> Golfers adhere to a code of etiquette, including maintaining pace of play, repairing divots, and respecting fellow players.</p>\r\n<p><strong>9. Handicaps:</strong> Handicaps are used to level the playing field in competitions, adjusting scores based on a player's skill level.</p>\r\n<p><strong>10. Honor System:</strong> Golf relies on the honor system, where players are responsible for accurately reporting their scores and adhering to the rules.</p>";
        public GameRule()
        {
            InitializeComponent();
        }

        private void GameRule_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSelect_Click(object sender, EventArgs e)
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
                    lblGameRule.Text= basketballR;
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
