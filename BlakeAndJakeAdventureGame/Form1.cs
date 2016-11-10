//Made by Blake Bos and Jakob Innis
//Nov 3
//Purpose : Adventure game
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace BlakeAndJakeAdventureGame
{
    public partial class Form1 : Form
    {
        int scene = 0;  // tracks what part of the game the user is at
        public Form1()
        {
            InitializeComponent();
            //seting certain labels to be invisible
            yellowButton.Visible = false;
            yellowLabel.Visible = false;
            Random randGen = new Random();
            greenLabel.Visible = false;
            greenBox.Visible = false;

        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Random randGen = new Random();
            if (e.KeyCode == Keys.M) // Keyboard button press for Red button
            {
                if (scene == 0)
                {
                    scene = 1;
                }
                else if (scene == 1)
                {
                    scene = 2;
                }
                else if (scene == 3)
                {
                    scene = 6;
                }
               else if (scene == 4)
                {
                    int chance = randGen.Next(1, 101);

                    if (chance < 50)
                    {
                        scene = 17;
                    }
                    else
                    {
                        scene = 8;
                    }
                }
                else if (scene == 13)
                {
                    scene = 6;
                }
                else if (scene == 2)
                {
                    scene = 4;
                }
                else if (scene == 9)
                {
                    scene = 11;
                }
                else if (scene == 11)
                {
                    scene = 9;
                }
                else if (scene == 16)
                {
                    scene = 6;
                }
                else if (scene == 6)
                {
                    scene = 14;
                }
                else if (scene == 5)
                {
                    scene = 10;
                }
                else if (scene == 11)
                {
                    scene = 15;
                }
              

            }
            else if (e.KeyCode == Keys.B)  //blue button press
            {

                if (scene == 0)
                {
                    Application.Exit();
                }
                else if (scene == 1)
                {
                    scene = 3;
                }
                else if (scene == 4)
                {
                    scene = 9;
                }
                else if (scene == 2)
                {
                    scene = 6;
                }
                else if (scene == 3)
                {
                    scene = 16;
                }
                else if (scene == 5)
                {
                    int chance = randGen.Next(1, 101);

                    if (chance < 70)
                    {
                        scene = 12;
                    }
                    else
                    {
                        scene = 13;
                    }
                }
                else if (scene == 6)
                {
                    scene = 15;
                }
                else if (scene == 16)
                {
                    scene = 7;
                }
                else if (scene == 9)
                    {
                    scene = 5;
                 }
                else if (scene == 11)
                {
                    scene = 18;
                }
            }
            if (e.KeyCode == Keys.Y) // Keyboard button press for yellow button
            {
                if (scene == 2)
                {
                    scene = 5;
                }

            }
            if (e.KeyCode == Keys.G) // Keyboard button press for green button
            {
                if (scene == 7)
                {
                    scene = 0;
                }
                else if (scene == 8)
                {
                    scene = 0;
                }
                else if (scene == 10)
                {
                    scene = 0;
                }
                else if (scene == 12)
                {
                    scene = 0;
                }
                else if (scene == 14)
                {
                    scene = 0;
                }
                else if (scene == 15)
                {
                    scene = 0;
                }
                else if (scene == 17)
                {
                    scene = 0;
                }
                else if (scene == 18)
                {
                    scene = 0;
                }
             
            }  

                switch (scene)
            {
                case 0:  //start scene 0
                    titleLabel.Text = "Hello, Welcome to Blake and Jake's Adventure Game , Would you like to start?";
                    redLabel.Text = "Yes!";
                    blueLabel.Text = "No? Why not :( ";
                    greenLabel.Visible = false;
                    greenBox.Visible = false;
                    backgroundBox.Image = Properties.Resources.scene_16;
                    break;
                case 1: //start scene 1
                    titleLabel.Text = "Your car breaks down in the middle of nowhere on a hot day. Would you like to walk into the forest or walk down the road looking for help?";
                    redLabel.Text = "Forest";
                    blueLabel.Text = "Road";
                    yellowButton.Visible = false;
                    yellowLabel.Visible = false;
                    greenLabel.Visible = false;
                    greenBox.Visible = false;
                    backgroundBox.Image = Properties.Resources.scene_16;
                    SoundPlayer player15 = new SoundPlayer(Properties.Resources.Car_wont_start_sound_effect);
                    player15.Play();
                    break;
                case 2://start scene 2
                    titleLabel.Text = "Once you enter the forest do you go left, right or straight?";
                    redLabel.Text = "Left";
                    blueLabel.Text = "Right";
                    yellowLabel.Text = "Straight";
                    yellowButton.Visible = true;
                    yellowLabel.Visible = true;
                    backgroundBox.Image = Properties.Resources.Scene_2;
                    SoundPlayer player10 = new SoundPlayer(Properties.Resources.leaves_rustling___sound_effect);
                    player10.Play();
                    break;
                case 3://start scene 3
                    titleLabel.Text = "You're getting pretty thirsty . Do you keep walking or go into the forest?";
                    redLabel.Text = "Forest";
                    blueLabel.Text = "Road";
                    yellowButton.Visible = false;
                    yellowLabel.Visible = false;
                    break;
                case 4://start scene 4
                    titleLabel.Text = "You come to two more paths. left or right? ";
                    redLabel.Text = "Left";
                    blueLabel.Text = "Right";
                    yellowButton.Visible = false;
                    yellowLabel.Visible = false;
                    backgroundBox.Image = Properties.Resources.Scene_4;
                    SoundPlayer player = new SoundPlayer(Properties.Resources.leaves_rustling___sound_effect);
                    player.Play();
                    break;
                case 5://start scene 5
                    titleLabel.Text = "you find a clean water creek and fill your water bottle. There is a horse in the water. Do you try to ride it or kill it for food?";
                    redLabel.Text = "Ride it";
                    blueLabel.Text = "Kill it";
                    yellowButton.Visible = false;
                    yellowLabel.Visible = false;
                    backgroundBox.Image = Properties.Resources.Scene_5;
                    SoundPlayer player9 = new SoundPlayer(Properties.Resources.Horse_neighing_sound_effect);
                    player9.Play();
                    break;
                case 6://start scene 6
                    titleLabel.Text = "You find a log cabin do you enter or knock ? ";
                    redLabel.Text = "Enter";
                    blueLabel.Text = "Knock";
                    yellowButton.Visible = false;
                    yellowLabel.Visible = false;
                    backgroundBox.Image = Properties.Resources.Scene_6;
                    break;
                case 7://start scene 7
                    titleLabel.Text = "You feel pain in your chest, you pass out and die from heat stroke.";
                    redLabel.Text = "you";
                    blueLabel.Text = "dead";
                    yellowButton.Visible = false;
                    yellowLabel.Visible = false;
                    greenLabel.Visible = true;
                    greenBox.Visible = true;
                    backgroundBox.Image = Properties.Resources.Death_Scenes_18__12__14__7;
                    SoundPlayer player2 = new SoundPlayer(Properties.Resources.Body_Falling_Sound_Effects__High_Quality_Free_Down);
                    player2.Play();
                    break;
                case 8://start scene 8
                    titleLabel.Text = "You find an abandon truck with a repair kit in it. You make your way back to your car and fix it ";
                    redLabel.Text = "You";
                    blueLabel.Text = "Win";
                    yellowButton.Visible = false;
                    yellowLabel.Visible = false;
                    greenLabel.Visible = true;
                    greenBox.Visible = true;
                    backgroundBox.Image = Properties.Resources.Scene_8;
                    SoundPlayer player7 = new SoundPlayer(Properties.Resources.Ratchet_Wrench_Sound_Effect);
                    player7.Play();
                    break;
                case 9://start scene 9
                    titleLabel.Text = "A sign says 'Town ahead' Follow the sign or continue through the forest?";
                    redLabel.Text = "Follow sign";
                    blueLabel.Text = "Forest";
                    yellowButton.Visible = false;
                    yellowLabel.Visible = false;
                    backgroundBox.Image = Properties.Resources.Scene_9;
                    SoundPlayer player11 = new SoundPlayer(Properties.Resources.leaves_rustling___sound_effect);
                    player11.Play();
                    break;
                case 10://start scene 10
                    titleLabel.Text = "You manage to get it calm and ride it back to the road and straight to the nearest town. You Win!";
                    redLabel.Text = "Winner";
                    blueLabel.Text = "You win !";
                    yellowButton.Visible = false;
                    yellowLabel.Visible = false;
                    greenLabel.Visible = true;
                    greenBox.Visible = true;
                    backgroundBox.Image = Properties.Resources.Scene_10;
                    break;
                case 11://start scene 11
                    titleLabel.Text = "You feel your getting nowhere, turn back or continue?";
                    redLabel.Text = "Turn Back";
                    blueLabel.Text = "Continue";
                    yellowButton.Visible = false;
                    yellowLabel.Visible = false;
                    backgroundBox.Image = Properties.Resources.Scene_11;
                    break;
                case 12://start scene 12
                    titleLabel.Text = "The horse kills you";
                    redLabel.Text = "BIG OLD";
                    blueLabel.Text = "LOSER";
                    yellowButton.Visible = false;
                    yellowLabel.Visible = false;
                    greenLabel.Visible = true;
                    greenBox.Visible = true;
                    backgroundBox.Image = Properties.Resources.Death_Scenes_18__12__14__7;
                    SoundPlayer player5 = new SoundPlayer(Properties.Resources.Horse_neighing_sound_effect);
                    player5.Play();
                    break;
                case 13://start scene 13
                    titleLabel.Text = "You live, eat the raw meat and continue through the forest";
                    redLabel.Text = "Press";
                    blueLabel.Text = "M to continue";
                    yellowButton.Visible = false;
                    yellowLabel.Visible = false;
                    backgroundBox.Image = Properties.Resources.Scene_13;
                    backgroundBox.Refresh();
                    SoundPlayer player6 = new SoundPlayer(Properties.Resources.Wet_Tearing_Meat__SOUND_EFFECT_);
                    player6.Play();
                    Thread.Sleep(2000);
                    player6.Stop();
                    break;
                case 14://start scene 14
                    titleLabel.Text = "You wake a man up from his sleep. He thinks you are an intruder and shoots you with his gun";
                    redLabel.Text = "YOU SUCK";
                    blueLabel.Text = "lol";
                    yellowButton.Visible = false;
                    yellowLabel.Visible = false;
                    greenLabel.Visible = true;
                    greenBox.Visible = true;
                    backgroundBox.Image = Properties.Resources.Death_Scenes_18__12__14__7;
                    SoundPlayer player4 = new SoundPlayer(Properties.Resources.Authentic_Shotgun_sound_effect_YouTube_1_x264);
                    player4.Play();
                    break;
                case 15://start scene 15
                    titleLabel.Text = "A man comes to the door and you tell him you're lost. He lets you use his phone and you call for a ride YOU WIN";
                    redLabel.Text = "Happy for";
                    blueLabel.Text = "you :D";
                    yellowButton.Visible = false;
                    yellowLabel.Visible = false;
                    greenLabel.Visible = true;
                    greenBox.Visible = true;
                    backgroundBox.Image = Properties.Resources.Scene_15;
                    SoundPlayer player8 = new SoundPlayer(Properties.Resources.Door_Knock);
                    player8.Play();
                    break;
                case 16://start scene 16
                    titleLabel.Text = "Are you sure? Its really hot outside and your getting thirtsy";
                    redLabel.Text = "No, Go into the forest";
                    blueLabel.Text = "Yes, Take the road";
                    yellowButton.Visible = false;
                    yellowLabel.Visible = false;
                    backgroundBox.Image = Properties.Resources.scene_16;
                    break;
                case 17://start scene 17
                    titleLabel.Text = "You fall down a steep hill and get impaled by a sharp stick. You bleed out.";
                    redLabel.Text = "Too many ";
                    blueLabel.Text = "ways to die";
                    yellowButton.Visible = false;
                    yellowLabel.Visible = false;
                    greenLabel.Visible = true;
                    greenBox.Visible = true;
                    backgroundBox.Image = Properties.Resources.Death_Scenes_18__12__14__7;
                    break;
                case 18://start scene 18
                    titleLabel.Text = "You die of dehydration";
                    redLabel.Text = "awww";
                    blueLabel.Text = ":(";
                    yellowButton.Visible = false;
                    yellowLabel.Visible = false;
                    greenLabel.Visible = true;
                    greenBox.Visible = true;
                    backgroundBox.Image = Properties.Resources.Death_Scenes_18__12__14__7;
                    SoundPlayer player3 = new SoundPlayer(Properties.Resources.Body_Falling_Sound_Effects__High_Quality_Free_Down);
                    player3.Play();
                    break;
                default:
                    break;
            }

        }

        }


    }

