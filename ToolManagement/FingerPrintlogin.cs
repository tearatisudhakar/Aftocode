using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms;

using System.Threading;

namespace ToolManagement
{
    public class FingerPrintlogin
    {
        public FingerPrintlogin()
        {


        }

        public int ReeadIDresponse(out SerialPort param, int useid)
        {
            SerialPort objPort = new SerialPort();
            int response = 0;
            int nbrDataRead = 0;
            string[] ArrayComPortsNames = null;
            string portname = string.Empty;
            ArrayComPortsNames = SerialPort.GetPortNames();
            if (ArrayComPortsNames.Length > 0)
            {
                objPort.PortName = ArrayComPortsNames[0];
                if (objPort != null && objPort.IsOpen)
                    objPort.Close();

                objPort.Parity = Parity.None;
                objPort.StopBits = StopBits.One;
                objPort.DataBits = 8;
                objPort.Handshake = Handshake.None;
                objPort.RtsEnable = true;
                objPort.WriteTimeout = 2000;
                objPort.Open();
                Thread.Sleep(2000);
                objPort.WriteLine("e");

                string value = objPort.ReadLine().Replace("\r", string.Empty);
                nbrDataRead = Convert.ToInt32(value);

                if (nbrDataRead == 1)
                {
                    objPort.WriteLine(useid.ToString()+"#");
                    if (MessageBox.Show("Please place user index finger.", "finger print", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        nbrDataRead = Convert.ToInt32(objPort.ReadLine());
                        if (nbrDataRead == 2)
                        {
                            response = nbrDataRead;
                        }
                    }
                }
            }
            param = objPort;
            return nbrDataRead;

        }
        public int RFIDLogin()
        {
            SerialPort objPort = new SerialPort();
            // int response = 0;
            int rfid = 0;
            string[] ArrayComPortsNames = null;
            string portname = string.Empty;
            ArrayComPortsNames = SerialPort.GetPortNames();
            if (ArrayComPortsNames.Length > 0)
            {
                objPort.PortName = ArrayComPortsNames[0];
                if (objPort != null && objPort.IsOpen)
                    objPort.Close();

                objPort.Parity = Parity.None;
                objPort.StopBits = StopBits.One;
                objPort.DataBits = 8;
                objPort.Handshake = Handshake.None;
                objPort.RtsEnable = true;
                objPort.WriteTimeout = 2000;             
                objPort.Open();
                Thread.Sleep(2000);
                objPort.WriteLine("r");
              //  if (MessageBox.Show("Please place your card .", "RFID", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    string rfidresult = objPort.ReadLine();
                    rfid = Convert.ToInt32(objPort.ReadLine());
                }

            }

            return rfid;

        }
        public int SendLoginF(out SerialPort portobj)
        {
            SerialPort objPort = new SerialPort();
            int nbrDataRead = 0;
            string[] ArrayComPortsNames = null;
            string portname = string.Empty;
            ArrayComPortsNames = SerialPort.GetPortNames();
            if (ArrayComPortsNames.Length > 0)
            {
                objPort.PortName = ArrayComPortsNames[0];
                if (objPort != null && objPort.IsOpen)
                    objPort.Close();

                
                objPort.Open();
                objPort.WriteLine("f");

               if (MessageBox.Show("Please place index finger.", "finger print", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    string outputfromDevice=objPort.ReadLine();
                    string Outputfinal = outputfromDevice.Replace("\r\n", string.Empty);
                    nbrDataRead = Convert.ToInt32(Outputfinal);
                    
                }

               }

            portobj = objPort;
            return nbrDataRead;

        }
        public int ReeadIDresponse2(SerialPort objPort)
        {


            int nbrDataRead = 0;

            nbrDataRead = Convert.ToInt32(objPort.ReadLine());

            return nbrDataRead;


        }

    }
}
