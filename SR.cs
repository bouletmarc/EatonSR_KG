using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class SR : Form
{
    private IContainer icontainer_0;
    private TextBox PCIDtextBox;
    private TextBox textBox_0;
    private Button button1;
    private Label label2;
    private Label lbl1;
    private Label label4;
    private TextBox textBox_1;
    private Label label1;

    public SR()
    {
        this.InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (this.PCIDtextBox.Text != "")
        {
            ulong num = Conversions.ToULong("&H" + this.PCIDtextBox.Text);
            string str = this.method_0(num, 0);
            this.textBox_0.Text = str;
            string str2 = this.method_1(num, 0xff);
            this.textBox_1.Text = str2;
        }
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing && (this.icontainer_0 != null))
        {
            this.icontainer_0.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        ComponentResourceManager manager = new ComponentResourceManager(typeof(SR));
        this.PCIDtextBox = new TextBox();
        this.textBox_0 = new TextBox();
        this.button1 = new Button();
        this.label2 = new Label();
        this.lbl1 = new Label();
        this.label4 = new Label();
        this.textBox_1 = new TextBox();
        this.label1 = new Label();
        base.SuspendLayout();
        this.PCIDtextBox.CharacterCasing = CharacterCasing.Upper;
        this.PCIDtextBox.Location = new Point(0x33, 0x23);
        this.PCIDtextBox.Name = "PCIDtextBox";
        this.PCIDtextBox.Size = new Size(150, 20);
        this.PCIDtextBox.TabIndex = 0;
        this.textBox_0.Location = new Point(0x33, 0x4b);
        this.textBox_0.Name = "tb1";
        this.textBox_0.ReadOnly = true;
        this.textBox_0.Size = new Size(150, 20);
        this.textBox_0.TabIndex = 1;
        this.textBox_0.TabStop = false;
        this.button1.Location = new Point(0x59, 0x91);
        this.button1.Name = "button1";
        this.button1.Size = new Size(0x4b, 0x17);
        this.button1.TabIndex = 2;
        this.button1.Text = "Generate";
        this.button1.UseVisualStyleBackColor = true;
        this.button1.Click += new EventHandler(this.button1_Click);
        this.label2.AutoSize = true;
        this.label2.Location = new Point(0x2c, 20);
        this.label2.Name = "label2";
        this.label2.Size = new Size(0x20, 13);
        this.label2.TabIndex = 5;
        this.label2.Text = "PCID";
        this.lbl1.AutoSize = true;
        this.lbl1.Location = new Point(0x2c, 60);
        this.lbl1.Name = "lbl1";
        this.lbl1.Size = new Size(90, 13);
        this.lbl1.TabIndex = 6;
        this.lbl1.Text = "Level 0 (Activate)";
        this.label4.AutoSize = true;
        this.label4.Location = new Point(0x2c, 100);
        this.label4.Name = "label4";
        this.label4.Size = new Size(0x62, 13);
        this.label4.TabIndex = 8;
        this.label4.Text = "Level 255 (Update)";
        this.textBox_1.Location = new Point(0x33, 0x73);
        this.textBox_1.Name = "tb2";
        this.textBox_1.ReadOnly = true;
        this.textBox_1.Size = new Size(150, 20);
        this.textBox_1.TabIndex = 7;
        this.textBox_1.TabStop = false;
        this.label1.AutoSize = true;
        this.label1.ForeColor = Color.Silver;
        this.label1.Location = new Point(140, 190);
        this.label1.Name = "label1";
        this.label1.Size = new Size(0x5d, 13);
        this.label1.TabIndex = 9;
        this.label1.Text = "Coded by C#4v32";
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(0xf4, 0xd4);
        base.Controls.Add(this.label1);
        base.Controls.Add(this.label4);
        base.Controls.Add(this.textBox_1);
        base.Controls.Add(this.lbl1);
        base.Controls.Add(this.label2);
        base.Controls.Add(this.button1);
        base.Controls.Add(this.textBox_0);
        base.Controls.Add(this.PCIDtextBox);
        base.FormBorderStyle = FormBorderStyle.FixedSingle;
        base.Icon = (Icon) manager.GetObject("$this.Icon");
        base.MaximizeBox = false;
        base.Name = "SR";
        base.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "Service Ranger 3.2";
        base.Load += new EventHandler(this.SR_Load);
        base.ResumeLayout(false);
        base.PerformLayout();
    }

    private string method_0(ulong ulong_0, ushort ushort_0)
    {
        decimal num2 = new decimal(0xf76 + (ushort_0 << 0x10));
        decimal num3 = new decimal(0x1a2b3c4d00000000UL);
        ulong num4 = Convert.ToUInt64(decimal.Add(num2, num3));
        return Conversion.Hex((ulong) ((ulong_0 ^ num4) + ((ulong) 0x708192a3b4c5L)));
    }

    private string method_1(ulong ulong_0, ushort ushort_0)
    {
        decimal num2 = new decimal(0x7ff + (ushort_0 << 0x10));
        decimal num3 = new decimal(0x1b2b4c5a00000000UL);
        ulong num4 = Convert.ToUInt64(decimal.Add(num2, num3));
        return Conversion.Hex((ulong) ((ulong_0 ^ num4) + ((ulong) 0x608493a7b4b5L)));
    }

    private void SR_Load(object sender, EventArgs e)
    {
    }
}

