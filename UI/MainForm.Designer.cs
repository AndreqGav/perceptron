
namespace UI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.source1 = new System.Windows.Forms.TextBox();
            this.select1 = new System.Windows.Forms.Button();
            this.train = new System.Windows.Forms.Button();
            this.downloadWeights = new System.Windows.Forms.Button();
            this.loadWeights = new System.Windows.Forms.Button();
            this.saveImage = new System.Windows.Forms.Button();
            this.check = new System.Windows.Forms.Button();
            this.elementName1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.elementName2 = new System.Windows.Forms.TextBox();
            this.select2 = new System.Windows.Forms.Button();
            this.source2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.loadImage = new System.Windows.Forms.Button();
            this.paintingControl = new UI.Controls.PaintingControl();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Источник выборки";
            // 
            // source1
            // 
            this.source1.Location = new System.Drawing.Point(318, 25);
            this.source1.Name = "source1";
            this.source1.Size = new System.Drawing.Size(131, 22);
            this.source1.TabIndex = 3;
            this.source1.Text = "D:\\Учеба магистратура\\2 курс 1 семестр\\Современные нейронные сети\\Лаба 1\\Perceptr" +
    "on\\Data\\1";
            // 
            // select1
            // 
            this.select1.AutoSize = true;
            this.select1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.select1.Location = new System.Drawing.Point(455, 20);
            this.select1.Name = "select1";
            this.select1.Size = new System.Drawing.Size(75, 26);
            this.select1.TabIndex = 5;
            this.select1.Text = "Выбрать";
            this.select1.UseVisualStyleBackColor = true;
            this.select1.Click += new System.EventHandler(this.select1_Click);
            // 
            // train
            // 
            this.train.AutoSize = true;
            this.train.Location = new System.Drawing.Point(179, 112);
            this.train.Name = "train";
            this.train.Size = new System.Drawing.Size(195, 26);
            this.train.TabIndex = 7;
            this.train.Text = "Запустить обучение";
            this.train.UseVisualStyleBackColor = true;
            this.train.Click += new System.EventHandler(this.train_Click);
            // 
            // downloadWeights
            // 
            this.downloadWeights.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadWeights.AutoSize = true;
            this.downloadWeights.Location = new System.Drawing.Point(377, 509);
            this.downloadWeights.Name = "downloadWeights";
            this.downloadWeights.Size = new System.Drawing.Size(195, 26);
            this.downloadWeights.TabIndex = 8;
            this.downloadWeights.Text = "Скачать";
            this.downloadWeights.UseVisualStyleBackColor = true;
            this.downloadWeights.Click += new System.EventHandler(this.downloadWeights_Click);
            // 
            // loadWeights
            // 
            this.loadWeights.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.loadWeights.AutoSize = true;
            this.loadWeights.Location = new System.Drawing.Point(377, 477);
            this.loadWeights.Name = "loadWeights";
            this.loadWeights.Size = new System.Drawing.Size(195, 26);
            this.loadWeights.TabIndex = 9;
            this.loadWeights.Text = "Загрузить";
            this.loadWeights.UseVisualStyleBackColor = true;
            this.loadWeights.Click += new System.EventHandler(this.loadWeights_Click);
            // 
            // saveImage
            // 
            this.saveImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveImage.AutoSize = true;
            this.saveImage.Location = new System.Drawing.Point(377, 229);
            this.saveImage.Name = "saveImage";
            this.saveImage.Size = new System.Drawing.Size(195, 26);
            this.saveImage.TabIndex = 10;
            this.saveImage.Text = "Сохранить рисунок";
            this.saveImage.UseVisualStyleBackColor = true;
            this.saveImage.Click += new System.EventHandler(this.saveImage_Click);
            // 
            // check
            // 
            this.check.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.check.AutoSize = true;
            this.check.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.check.Location = new System.Drawing.Point(377, 155);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(195, 50);
            this.check.TabIndex = 11;
            this.check.Text = "Проверить";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // elementName1
            // 
            this.elementName1.Location = new System.Drawing.Point(146, 25);
            this.elementName1.Name = "elementName1";
            this.elementName1.Size = new System.Drawing.Size(154, 22);
            this.elementName1.TabIndex = 12;
            this.elementName1.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Наименование";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Элемент 1-го типа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Элемент 2-го типа";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Наименование";
            // 
            // elementName2
            // 
            this.elementName2.Location = new System.Drawing.Point(146, 75);
            this.elementName2.Name = "elementName2";
            this.elementName2.Size = new System.Drawing.Size(154, 22);
            this.elementName2.TabIndex = 18;
            this.elementName2.Text = "8";
            // 
            // select2
            // 
            this.select2.AutoSize = true;
            this.select2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.select2.Location = new System.Drawing.Point(455, 73);
            this.select2.Name = "select2";
            this.select2.Size = new System.Drawing.Size(75, 26);
            this.select2.TabIndex = 17;
            this.select2.Text = "Выбрать";
            this.select2.UseVisualStyleBackColor = true;
            this.select2.Click += new System.EventHandler(this.select2_Click);
            // 
            // source2
            // 
            this.source2.Location = new System.Drawing.Point(318, 75);
            this.source2.Name = "source2";
            this.source2.Size = new System.Drawing.Size(131, 22);
            this.source2.TabIndex = 16;
            this.source2.Text = "D:\\Учеба магистратура\\2 курс 1 семестр\\Современные нейронные сети\\Лаба 1\\Perceptr" +
    "on\\Data\\8";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(315, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Источник выборки";
            // 
            // clear
            // 
            this.clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clear.AutoSize = true;
            this.clear.Location = new System.Drawing.Point(377, 261);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(195, 26);
            this.clear.TabIndex = 21;
            this.clear.Text = "Очистить";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(374, 458);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "Матрица весов";
            // 
            // loadImage
            // 
            this.loadImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loadImage.AutoSize = true;
            this.loadImage.Location = new System.Drawing.Point(377, 317);
            this.loadImage.Name = "loadImage";
            this.loadImage.Size = new System.Drawing.Size(195, 26);
            this.loadImage.TabIndex = 25;
            this.loadImage.Text = "Загрузить рисунок";
            this.loadImage.UseVisualStyleBackColor = true;
            this.loadImage.Click += new System.EventHandler(this.loadImage_Click);
            // 
            // paintingControl
            // 
            this.paintingControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paintingControl.Location = new System.Drawing.Point(12, 155);
            this.paintingControl.Name = "paintingControl";
            this.paintingControl.Size = new System.Drawing.Size(350, 383);
            this.paintingControl.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 553);
            this.Controls.Add(this.loadImage);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.elementName2);
            this.Controls.Add(this.select2);
            this.Controls.Add(this.source2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.elementName1);
            this.Controls.Add(this.check);
            this.Controls.Add(this.saveImage);
            this.Controls.Add(this.loadWeights);
            this.Controls.Add(this.downloadWeights);
            this.Controls.Add(this.train);
            this.Controls.Add(this.select1);
            this.Controls.Add(this.source1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.paintingControl);
            this.Name = "MainForm";
            this.Text = "Перцептрон";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Controls.PaintingControl paintingControl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox source1;
        private System.Windows.Forms.Button select1;
        private System.Windows.Forms.Button train;
        private System.Windows.Forms.Button downloadWeights;
        private System.Windows.Forms.Button loadWeights;
        private System.Windows.Forms.Button saveImage;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.TextBox elementName1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox elementName2;
        private System.Windows.Forms.Button select2;
        private System.Windows.Forms.TextBox source2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button loadImage;
    }
}