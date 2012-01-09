using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatientSimulator
{
    // implementation based on http://www.mathworks.com/matlabcentral/fileexchange/10858
    public class ECG  
    {
        public double P_WAV(double x, double a_pwav, double d_pwav, double t_pwav, double li)
        {
            double L = li;
            double A = a_pwav;
            double X = x + t_pwav;
            double B = (2 * L) / d_pwav;
            double N = 100;
            double P1 = 1 / L;
            double P2 = 0;
            double harm1 = 0;
            double pwav1;


            for (int i = 1; i < N; i++)
            {
                harm1 = (((Math.Sin((Math.PI / (2 * B)) * (B - (2 * i)))) / (B - (2 * i)) + (Math.Sin((Math.PI / (2 * B)) * (B + (2 * i)))) / (B + (2 * i))) * (2 / Math.PI)) * Math.Cos((i * Math.PI * X) / L);
                P2 += harm1;

            }
            pwav1 = P1 + P2;
            return A * pwav1;
        }

        public double T_WAV(double x, double a_twav, double d_twav, double t_twav, double li)
        {
            double L = li;
            double A = a_twav;
            double X = x - t_twav - 0.045;
            double B = (2 * L) / d_twav;
            double N = 100;
            double T1 = 1 / L;
            double T2 = 0;
            double harm2 = 0;
            double twav1;


            for (int i = 1; i < N; i++)
            {
                harm2 = (((Math.Sin((Math.PI / (2 * B)) * (B - (2 * i)))) / (B - (2 * i)) + (Math.Sin((Math.PI / (2 * B)) * (B + (2 * i)))) / (B + (2 * i))) * (2 / Math.PI)) * Math.Cos((i * Math.PI * X) / L);

                T2 += harm2;
            }
            twav1 = T1 + T2;
            return A * twav1;

        }

        public double Q_WAV(double x, double a_qwav, double d_qwav, double t_qwav, double li)
        {
            double L = li;
            double X = x + t_qwav;
            double A = a_qwav;
            double B = (2 * L) / d_qwav;
            double N = 100;
            double Q1 = (A / (2 * B)) * (2 - B);
            double Q2 = 0;
            double harm5;
            double qwav;

            for (int i = 1; i < N; i++)
            {
                harm5 = (((2 * B * A) / (i * i * Math.PI * Math.PI)) * (1 - Math.Cos((i * Math.PI) / B))) * Math.Cos((i * Math.PI * X) / L);
                Q2 += harm5;
            }

            qwav = -1 * (Q1 + Q2);
            return qwav;
        }

        public double QRS_WAV(double x, double a_qrswav, double d_qrswav, double li)
        {
            double L = li;
            double A = a_qrswav;
            double B = (2 * L) / d_qrswav;
            double N = 100;
            double QRS1 = (A / (2 * B)) * (2 - B);
            double QRS2 = 0;
            double harm;
            double qrswav;

            for (int i = 1; i < N; i++)
            {
                harm = (((2 * B * A) / (i * i * Math.PI * Math.PI)) * (1 - Math.Cos((i * Math.PI) / B))) * Math.Cos((i * Math.PI * x) / L);
                QRS2 += harm;
            }
            qrswav = QRS1 + QRS2;
            return qrswav;
        }

        public double S_WAV(double x, double a_swav, double d_swav, double t_swav, double li)
        {
            double L = li;
            double X = x - t_swav;
            double A = a_swav;
            double B = (2 * L) / d_swav;
            double N = 100;
            double S1 = (A / (2 * B)) * (2 - B);
            double S2 = 0;
            double harm3;
            double swav;

            for (int i = 1; i < N; i++)
            {
                harm3 = (((2 * B * A) / (i * i * Math.PI * Math.PI)) * (1 - Math.Cos((i * Math.PI) / B))) * Math.Cos((i * Math.PI * X) / L);
                S2 = S2 + harm3;
            }
            swav = -1 * (S1 + S2);
            return swav;
        }

        public double U_WAV(double x, double a_uwav, double d_uwav, double t_uwav, double li)
        {
            double L = li;
            double A = a_uwav;
            double X = x - t_uwav;
            double B = (2 * L) / d_uwav;
            double N = 100;
            double U1 = 1 / L;
            double U2 = 0;
            double harm4;
            double uwav1;

            for (int i = 1; i < N; i++)
            {
                harm4 = (((Math.Sin((Math.PI / (2 * B)) * (B - (2 * i)))) / (B - (2 * i)) + (Math.Sin((Math.PI / (2 * B)) * (B + (2 * i)))) / (B + (2 * i))) * (2 / Math.PI)) * Math.Cos((i * Math.PI * X) / L);
                U2 += harm4;
            }
            uwav1 = U1 + U2;
            return A * uwav1;

        }
    }
}
