<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPinjam
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBoxKelas = New System.Windows.Forms.TextBox()
        Me.TextBoxNamaAgt = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBoxPenerbit = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBoxJmlhBuku = New System.Windows.Forms.TextBox()
        Me.TextBoxPenulis = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBoxNamaBuku = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxPetugas = New System.Windows.Forms.TextBox()
        Me.TextBoxTgl = New System.Windows.Forms.TextBox()
        Me.TextBoxJumlah = New System.Windows.Forms.TextBox()
        Me.TextBoxNIS = New System.Windows.Forms.TextBox()
        Me.TextBoxKodeBuku = New System.Windows.Forms.TextBox()
        Me.TextBoxKodePinjam = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonBatal = New System.Windows.Forms.Button()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ButtonBatal)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.TextBoxKelas)
        Me.GroupBox4.Controls.Add(Me.TextBoxNamaAgt)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.TextBoxPenerbit)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.TextBoxJmlhBuku)
        Me.GroupBox4.Controls.Add(Me.TextBoxPenulis)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.TextBoxNamaBuku)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.TextBoxPetugas)
        Me.GroupBox4.Controls.Add(Me.TextBoxTgl)
        Me.GroupBox4.Controls.Add(Me.TextBoxJumlah)
        Me.GroupBox4.Controls.Add(Me.TextBoxNIS)
        Me.GroupBox4.Controls.Add(Me.TextBoxKodeBuku)
        Me.GroupBox4.Controls.Add(Me.TextBoxKodePinjam)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(10, 113)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(770, 183)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Input Peminjaman"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(291, 79)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(36, 16)
        Me.Label14.TabIndex = 166
        Me.Label14.Text = "Kelas"
        '
        'TextBoxKelas
        '
        Me.TextBoxKelas.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxKelas.Location = New System.Drawing.Point(356, 76)
        Me.TextBoxKelas.Multiline = True
        Me.TextBoxKelas.Name = "TextBoxKelas"
        Me.TextBoxKelas.Size = New System.Drawing.Size(51, 19)
        Me.TextBoxKelas.TabIndex = 165
        '
        'TextBoxNamaAgt
        '
        Me.TextBoxNamaAgt.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNamaAgt.Location = New System.Drawing.Point(356, 51)
        Me.TextBoxNamaAgt.Multiline = True
        Me.TextBoxNamaAgt.Name = "TextBoxNamaAgt"
        Me.TextBoxNamaAgt.Size = New System.Drawing.Size(146, 19)
        Me.TextBoxNamaAgt.TabIndex = 164
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(289, 54)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(38, 16)
        Me.Label13.TabIndex = 163
        Me.Label13.Text = "Nama"
        '
        'TextBoxPenerbit
        '
        Me.TextBoxPenerbit.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPenerbit.Location = New System.Drawing.Point(105, 126)
        Me.TextBoxPenerbit.Multiline = True
        Me.TextBoxPenerbit.Name = "TextBoxPenerbit"
        Me.TextBoxPenerbit.Size = New System.Drawing.Size(154, 19)
        Me.TextBoxPenerbit.TabIndex = 162
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(10, 129)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 16)
        Me.Label7.TabIndex = 161
        Me.Label7.Text = "Penerbit"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(10, 151)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 16)
        Me.Label12.TabIndex = 160
        Me.Label12.Text = "Jumlah Buku"
        '
        'TextBoxJmlhBuku
        '
        Me.TextBoxJmlhBuku.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxJmlhBuku.Location = New System.Drawing.Point(105, 151)
        Me.TextBoxJmlhBuku.Multiline = True
        Me.TextBoxJmlhBuku.Name = "TextBoxJmlhBuku"
        Me.TextBoxJmlhBuku.Size = New System.Drawing.Size(67, 19)
        Me.TextBoxJmlhBuku.TabIndex = 159
        '
        'TextBoxPenulis
        '
        Me.TextBoxPenulis.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPenulis.Location = New System.Drawing.Point(105, 101)
        Me.TextBoxPenulis.Multiline = True
        Me.TextBoxPenulis.Name = "TextBoxPenulis"
        Me.TextBoxPenulis.Size = New System.Drawing.Size(154, 19)
        Me.TextBoxPenulis.TabIndex = 158
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(10, 106)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 16)
        Me.Label11.TabIndex = 157
        Me.Label11.Text = "Penulis"
        '
        'TextBoxNamaBuku
        '
        Me.TextBoxNamaBuku.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNamaBuku.Location = New System.Drawing.Point(105, 76)
        Me.TextBoxNamaBuku.Multiline = True
        Me.TextBoxNamaBuku.Name = "TextBoxNamaBuku"
        Me.TextBoxNamaBuku.Size = New System.Drawing.Size(154, 19)
        Me.TextBoxNamaBuku.TabIndex = 156
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(10, 79)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 16)
        Me.Label8.TabIndex = 155
        Me.Label8.Text = "Nama Buku"
        '
        'TextBoxPetugas
        '
        Me.TextBoxPetugas.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPetugas.Location = New System.Drawing.Point(633, 76)
        Me.TextBoxPetugas.Multiline = True
        Me.TextBoxPetugas.Name = "TextBoxPetugas"
        Me.TextBoxPetugas.Size = New System.Drawing.Size(131, 19)
        Me.TextBoxPetugas.TabIndex = 154
        '
        'TextBoxTgl
        '
        Me.TextBoxTgl.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTgl.Location = New System.Drawing.Point(633, 51)
        Me.TextBoxTgl.Multiline = True
        Me.TextBoxTgl.Name = "TextBoxTgl"
        Me.TextBoxTgl.Size = New System.Drawing.Size(113, 19)
        Me.TextBoxTgl.TabIndex = 152
        '
        'TextBoxJumlah
        '
        Me.TextBoxJumlah.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxJumlah.Location = New System.Drawing.Point(633, 26)
        Me.TextBoxJumlah.Multiline = True
        Me.TextBoxJumlah.Name = "TextBoxJumlah"
        Me.TextBoxJumlah.Size = New System.Drawing.Size(51, 19)
        Me.TextBoxJumlah.TabIndex = 151
        '
        'TextBoxNIS
        '
        Me.TextBoxNIS.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNIS.Location = New System.Drawing.Point(356, 23)
        Me.TextBoxNIS.Multiline = True
        Me.TextBoxNIS.Name = "TextBoxNIS"
        Me.TextBoxNIS.Size = New System.Drawing.Size(67, 19)
        Me.TextBoxNIS.TabIndex = 150
        '
        'TextBoxKodeBuku
        '
        Me.TextBoxKodeBuku.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxKodeBuku.Location = New System.Drawing.Point(105, 51)
        Me.TextBoxKodeBuku.Multiline = True
        Me.TextBoxKodeBuku.Name = "TextBoxKodeBuku"
        Me.TextBoxKodeBuku.Size = New System.Drawing.Size(67, 19)
        Me.TextBoxKodeBuku.TabIndex = 149
        '
        'TextBoxKodePinjam
        '
        Me.TextBoxKodePinjam.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxKodePinjam.Location = New System.Drawing.Point(105, 26)
        Me.TextBoxKodePinjam.Multiline = True
        Me.TextBoxKodePinjam.Name = "TextBoxKodePinjam"
        Me.TextBoxKodePinjam.Size = New System.Drawing.Size(67, 19)
        Me.TextBoxKodePinjam.TabIndex = 148
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(523, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 16)
        Me.Label10.TabIndex = 147
        Me.Label10.Text = "Jumlah Pinjam"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(523, 79)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 16)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Petugas"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.PROGRAM_PERPUSTAKAAN.My.Resources.Resources.save3
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(593, 101)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 75)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "SIMPAN"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(523, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 16)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Tanggal Pinjam"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Kode Pinjam"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Kode Buku"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(289, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "NIS"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.PROGRAM_PERPUSTAKAAN.My.Resources.Resources.BACK
        Me.PictureBox2.Location = New System.Drawing.Point(12, 19)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(48, 47)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PROGRAM_PERPUSTAKAAN.My.Resources.Resources.pinjam
        Me.PictureBox1.Location = New System.Drawing.Point(105, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(79, 77)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(6, 38)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(764, 124)
        Me.DataGridView2.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(190, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(236, 22)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "YAYASAN KEMBAR KARYA 1"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DataGridView2)
        Me.GroupBox3.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 134)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(776, 152)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Data Peminjaman"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(190, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(313, 22)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "PEMINJAMAN BUKU PERPUSTAKAAN"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(10, 296)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(776, 150)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data Peminjaman"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(764, 123)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(-2, -6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(805, 113)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'ButtonBatal
        '
        Me.ButtonBatal.BackColor = System.Drawing.Color.Transparent
        Me.ButtonBatal.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBatal.Image = Global.PROGRAM_PERPUSTAKAAN.My.Resources.Resources.save3
        Me.ButtonBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonBatal.Location = New System.Drawing.Point(414, 101)
        Me.ButtonBatal.Name = "ButtonBatal"
        Me.ButtonBatal.Size = New System.Drawing.Size(138, 75)
        Me.ButtonBatal.TabIndex = 167
        Me.ButtonBatal.Text = "BATAL"
        Me.ButtonBatal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonBatal.UseVisualStyleBackColor = False
        '
        'FormPinjam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormPinjam"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormPinjam"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBoxPetugas As TextBox
    Friend WithEvents TextBoxTgl As TextBox
    Friend WithEvents TextBoxJumlah As TextBox
    Friend WithEvents TextBoxNIS As TextBox
    Friend WithEvents TextBoxKodeBuku As TextBox
    Friend WithEvents TextBoxKodePinjam As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBoxKelas As TextBox
    Friend WithEvents TextBoxNamaAgt As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBoxPenerbit As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBoxJmlhBuku As TextBox
    Friend WithEvents TextBoxPenulis As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBoxNamaBuku As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ButtonBatal As Button
End Class
