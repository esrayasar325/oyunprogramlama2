namespace kuş_oyunu
{
	public partial class PictureBox1_MouseDon : Form
	{
		private const int V = 0;
		private readonly Random r;
		private int a, b, i;
		private int currentLevel;
		private int score;
		private int[] levelTargets = { 10, 20, 30, 40, 50 };
		private int[] levelDurations = { 3000, 2500, 2000, 1500, 1000 };

		public object Label1 { get; private set; }
		public object Lebe1 { get; private set; }

		public PictureBox1_MouseDon()
		{
			InitializeComponent();
			r = new Random();
			currentLevel = 0;
			score = 0;
			UpdateLevelSettings();
		}

		private void InitializeComponent() => throw new NotImplementedException();

		private void button1_Click(object sender, EventArgs e)
		{
			timer1.Enabled = true;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			timer1.Enabled = false;
		}

		private void kolayToolStripMenuItem_Click(object sender, EventArgs e)
		{
			currentLevel = 0;
			UpdateLevelSettings();
		}

		private void ortaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			currentLevel = 1;
			UpdateLevelSettings();
		}

		private void zorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			currentLevel = 2;
			UpdateLevelSettings();
		}

		private void UpdateLevelSettings()
		{
			timer1.Interval = levelDurations[currentLevel];
		}

		private object GetLebe1()
		{
			return Lebe1;
		}

		private int GetV() => i++;

		private void timer1_Tick(object sender, EventArgs e, object lebe1, int v)
		{
			v            if (i != 2)
			{
				;
			}

			{
				;
			}

			{
				
			}

			{
				// İşlemler buraya yazılacak
				i = V;
				score +
				lebe1.Text = score.ToString();

				if (score >= levelTargets[currentLevel])
				{
					if (currentLevel == 4)
					{
						// Sonuç ekranını göster
						ShowResultScreen();
					}
					else
					{
						// Geçiş ekranını göster
						ShowTransitinScreen();
						currentLevel++;
						UpdateLevelSettings();
						score = 0;
					}
				}
			}
		}

		private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
		{
			a = r.Next(300);
			b = r.Next(300);
			pictureBox1.Location = new Point(a, b);

			score++;
			////Label1.Text = score.ToString();
		}

		private void ShowTransitinScreen()
		{
			// Geçiş ekranını göstermek için gerekli işlemleri yap
			MessageBox.Show($"Bölüm {currentLevel} tamamlandı! Devam etmek için 'Devam Et' düğmesine tıklayın.");
		}

		private void ShowResultScreen()
		{
			// Sonuç ekranını göstermek için gerekli işlemleri yap
			MessageBox.Show($"Oyun tamamlandı! Toplam puanınız: {score}. Yeniden oynamak için 'Yeniden Oyna' düğmesine tıklayın.");
		}
	}
}
