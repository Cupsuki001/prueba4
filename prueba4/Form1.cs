namespace prueba4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int num = 0;
        public double ttp = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            TXBttdesc.Enabled = false;
            TXBsub.Enabled = false;
            TXBsubfact.Enabled = false;
            TXBsub.Enabled = false;
            TXBfact.Enabled = false;
            TXBimpuesto.Enabled = false;
            TXBcord.Enabled = false;
            TXBdola.Enabled = false;
            CMBtipo.Enabled = false;
            TXBtipopago.Enabled = false;
            TXBvuelt.Enabled = false;
            TXBdinero.Enabled = false;
            TXBdesc.Enabled = false;

            if (dataGridView1.Rows.Count == 0)
            {
                BTNborrar.Enabled = false;
            }
            else
            {
                BTNborrar.Enabled = true;
            }
        }

        private void TXBadi_Click(object sender, EventArgs e)
        {
            try
            {
                double pre, cant, tt;

                // Verificar si los campos están vacíos
                if (string.IsNullOrEmpty(MSKcodigo.Text) || string.IsNullOrEmpty(TXBnomb.Text) ||
                    string.IsNullOrEmpty(TXBprecio.Text) || string.IsNullOrEmpty(MSKcant.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.");
                    return;
                }

                // Convertir los valores de los campos
                pre = Convert.ToDouble(TXBprecio.Text);
                cant = Convert.ToDouble(MSKcant.Text);

                tt = pre * cant;
                TXBsub.Text = tt.ToString();

                int num = dataGridView1.Rows.Add();
                dataGridView1.Rows[num].Cells[0].Value = MSKcodigo.Text;
                dataGridView1.Rows[num].Cells[1].Value = TXBnomb.Text;
                dataGridView1.Rows[num].Cells[2].Value = TXBprecio.Text;
                dataGridView1.Rows[num].Cells[3].Value = MSKcant.Text;
                dataGridView1.Rows[num].Cells[4].Value = TXBsub.Text;

                // Calcular totales
                double sum = 0, imp = 0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    sum += Convert.ToDouble(row.Cells["Column4"].Value);
                    imp = (sum * 1.15) - sum;
                    ttp = imp + sum;
                }

                TXBsubfact.Text = sum.ToString();
                TXBfact.Text = ttp.ToString();
                TXBimpuesto.Text = imp.ToString();

                // Limpiar campos después de agregar la fila
                MSKcodigo.Text = "";
                TXBnomb.Text = "";
                TXBprecio.Text = "";
                MSKcant.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("No puede estar en blanco");

            }
        }

        private void BTNborrar_Click(object sender, EventArgs e)
        {
            if (num != -1)
            {
                dataGridView1.Rows.RemoveAt(num);
            }
        }

        private void BTNpagar_Click(object sender, EventArgs e)
        {
            double c, d = 0, tt, con = 0, mix, por, ttpro = 0;

            // Reemplaza ObtenerTotalAPagar con la lógica que corresponda
            if (CHKdesc.Checked == true)
            {
                if (treeView1.SelectedNode == null)
                {
                    MessageBox.Show("Ingrese un metodo de pago");
                }
                else
                {
                    if (treeView1.SelectedNode.Text.Equals("Credito"))
                    {
                        por = ttp * 0.05;
                        tt = ttp - por;
                        TXBdinero.Text = tt.ToString();
                        TXBvuelt.Text = por.ToString();
                        TXBdesc.Text = por.ToString();
                        TXBtipopago.Text = "Credito";
                    }
                    else
                    {
                        if (CMBtipo.SelectedItem == null)
                        {
                            MessageBox.Show("Seleccione un tipo de pago.");
                            return;
                        }
                        if (CMBtipo.SelectedItem.ToString() == "Cordoba")
                        {
                            TXBdola.Enabled = false;
                            TXBcord.Enabled = true;
                            c = Convert.ToDouble(TXBcord.Text);

                            if (c < 1000)
                            {
                                if (!double.TryParse(TXBcord.Text, out c) || c < ttp)
                                {
                                    MessageBox.Show("La cantidad en córdobas no es válida o es menor al total a pagar.");
                                    TXBcord.Focus();
                                    return;
                                }
                                else
                                {
                                    tt = c - ttp;
                                    d = 0;
                                    TXBttdesc.Text = "0";
                                    TXBdinero.Text = c.ToString();
                                    TXBvuelt.Text = tt.ToString();
                                    TXBtipopago.Text = "Efectivo";
                                }
                            }
                            else 
                            {
                                if (!double.TryParse(TXBcord.Text, out c) || c < ttp)
                                {
                                    MessageBox.Show("La cantidad en córdobas no es válida o es menor al total a pagar.");
                                    TXBcord.Focus();
                                    return;
                                }
                                else
                                {
                                    por = ttp * 0.05;
                                    ttpro = ttp - por;
                                    tt = c - ttpro;
                                    d = 0;
                                    TXBttdesc.Text = ttpro.ToString();
                                    TXBdinero.Text = c.ToString();
                                    TXBvuelt.Text = tt.ToString();
                                    TXBdesc.Text = por.ToString();
                                    TXBtipopago.Text = "Efectivo";
                                }
                            }

                        }
                        else if (CMBtipo.SelectedItem.ToString() == "Dolares")
                        {
                            TXBcord.Enabled = false;
                            TXBdola.Enabled = true;
                            d = Convert.ToDouble(TXBdola.Text);
                            con = d * 36.81;

                            if (con < 1000) 
                            {
                                if (!double.TryParse(TXBdola.Text, out d) || con < ttp)
                                {
                                    MessageBox.Show("La cantidad en dolares no es válida o es menor al total a pagar.");
                                    TXBdola.Focus();
                                    return;
                                }
                                else
                                {
                                    tt = con - ttp;
                                    TXBttdesc.Text = "0";
                                    TXBdinero.Text = d.ToString();
                                    TXBvuelt.Text = tt.ToString();
                                    TXBtipopago.Text = "Efectivo";
                                }
                            }
                            else 
                            {
                                if (!double.TryParse(TXBdola.Text, out d) || con < ttp)
                                {
                                    MessageBox.Show("La cantidad en dolares no es válida o es menor al total a pagar.");
                                    TXBdola.Focus();
                                    return;
                                }
                                else
                                {
                                    por = ttp * 0.05;
                                    ttpro = ttp - por;
                                    tt = con - ttpro;
                                    TXBttdesc.Text = ttpro.ToString();
                                    TXBdinero.Text = con.ToString();
                                    TXBvuelt.Text = tt.ToString();
                                    TXBdesc.Text = por.ToString();
                                    TXBtipopago.Text = "Efectivo";


                                }
                            }
                        }
                        else
                        {
                            c = Convert.ToDouble(TXBcord.Text);
                            d = Convert.ToDouble(TXBdola.Text);
                            TXBcord.Enabled = true;
                            TXBdola.Enabled = true;
                            con = d * 36.81;
                            mix = con + c;

                            if (mix < 1000) 
                            {
                                if (!double.TryParse(TXBdola.Text, out d) || !double.TryParse(TXBcord.Text, out c) || mix < ttp)
                                {
                                    MessageBox.Show("La cantidad en córdobas no es válida o es menor al total a pagar.");
                                }
                                else
                                {
                                    tt = mix - ttp;
                                    TXBdesc.Text = "0";
                                    TXBdinero.Text = mix.ToString();
                                    TXBvuelt.Text = tt.ToString();
                                    TXBtipopago.Text = "Efectivo";
                                }
                            }
                            else 
                            {
                                if (!double.TryParse(TXBdola.Text, out d) || !double.TryParse(TXBcord.Text, out c) || mix < ttp)
                                {
                                    MessageBox.Show("La cantidad en córdobas no es válida o es menor al total a pagar.");
                                }
                                else
                                {
                                    por = ttp * 0.05;
                                    ttpro = ttp - por;
                                    tt = mix - ttpro;
                                    TXBttdesc.Text = ttpro.ToString();
                                    TXBdinero.Text = mix.ToString();
                                    TXBvuelt.Text = tt.ToString();
                                    TXBdesc.Text = por.ToString();
                                    TXBtipopago.Text = "Efectivo";
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                if (treeView1.SelectedNode == null)
                {
                    MessageBox.Show("Ingrese un metodo de pago");
                }
                else
                {
                    if (treeView1.SelectedNode.Text.Equals("Credito"))
                    {
                        tt = ttp - ttp;
                        TXBdinero.Text = ttp.ToString();
                        TXBvuelt.Text = "0";
                        TXBtipopago.Text = "Credito";
                    }
                    else
                    {
                        if (CMBtipo.SelectedItem == null)
                        {
                            MessageBox.Show("Seleccione un tipo de pago.");
                            return;
                        }
                        if (CMBtipo.SelectedItem.ToString() == "Cordoba")
                        {
                            TXBdola.Enabled = false;
                            TXBcord.Enabled = true;

                            if (!double.TryParse(TXBcord.Text, out c) || c < ttp)
                            {
                                MessageBox.Show("La cantidad en córdobas no es válida o es menor al total a pagar.");
                                TXBcord.Focus();
                                return;
                            }
                            else
                            {
                                tt = c - ttp;
                                d = 0;
                                TXBdinero.Text = c.ToString();
                                TXBvuelt.Text = tt.ToString();
                                TXBtipopago.Text = "Efectivo";
                            }
                        }
                        else if (CMBtipo.SelectedItem.ToString() == "Dolares")
                        {
                            TXBcord.Enabled = false;
                            TXBdola.Enabled = true;
                            d = Convert.ToDouble(TXBdola.Text);
                            con = d * 36.81;

                            if (!double.TryParse(TXBdola.Text, out d) || con < ttp)
                            {
                                MessageBox.Show("La cantidad en dolares no es válida o es menor al total a pagar.");
                                TXBdola.Focus();
                                return;
                            }
                            else
                            {
                                tt = con - ttp;
                                TXBdinero.Text = d.ToString();
                                TXBvuelt.Text = tt.ToString();
                                TXBtipopago.Text = "Efectivo";
                            }
                        }
                        else
                        {
                            c = Convert.ToDouble(TXBcord.Text);
                            d = Convert.ToDouble(TXBdola.Text);
                            TXBcord.Enabled = true;
                            TXBdola.Enabled = true;
                            con = d * 36.81;
                            mix = con + c;

                            if (!double.TryParse(TXBdola.Text, out d) || !double.TryParse(TXBcord.Text, out c) || mix < ttp)
                            {
                                MessageBox.Show("La cantidad en córdobas no es válida o es menor al total a pagar.");
                            }
                            else
                            {
                                tt = mix - ttp;
                                TXBdinero.Text = mix.ToString();
                                TXBvuelt.Text = tt.ToString();
                                TXBtipopago.Text = "Efectivo";
                            }
                        }
                    }
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            MSKcant.Text = "";
            MSKcodigo.Text = "";
            TXBprecio.Text = "";
            TXBnomb.Text = "";
            TXBimpuesto.Text = "";
            TXBdola.Text = "";
            TXBcord.Text = "";
            TXBfact.Text = "";
            TXBsub.Text = "";
            TXBsubfact.Text = "";
            TXBtipopago.Text = "";
            TXBvuelt.Text = "";
            TXBdinero.Text = "";
            CMBtipo.Text = "";
            TXBdesc.Text = "";
            CHKdesc.Checked = false;
            TXBttdesc.Text = "";
            LBLning.Text = "NINGUNO";
            dataGridView1.Rows.Clear();

        }

        private void CMBtipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CMBtipo.SelectedItem.ToString() == "Cordoba")
            {
                TXBdola.Enabled = false;
                TXBcord.Enabled = true;
                TXBdola.Text = "";
            }
            else if (CMBtipo.SelectedItem.ToString() == "Dolares")
            {
                TXBcord.Enabled = false;
                TXBdola.Enabled = true;
                TXBcord.Text = "";
            }
            else
            {
                TXBcord.Enabled = true;
                TXBdola.Enabled = true;
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.Text.Equals("Efectivo"))
            {
                CMBtipo.Enabled = true;
                LBLning.Text = "Efectivo";
            }
            else
            {
                TXBcord.Enabled = false;
                TXBdola.Enabled = false;
                CMBtipo.Enabled = false;
                LBLning.Text = "Credito";
            }
        }

        private void TXBnomb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TXBcord_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {

                e.Handled = true;

            }
        }

        private void TXBdola_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {

                e.Handled = true;

            }
        }

        private void TXBprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {

                e.Handled = true;

            }
        }
    }
}
