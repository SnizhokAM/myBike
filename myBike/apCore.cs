using System;
using System.Collections.Generic;
using System.Text;

// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.

// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.

// You should have received a copy of the GNU General Public License
// along with this program. If not, see <https://www.gnu.org/licenses/>.

namespace myBike
{
    class CalcSize
    {
        public string GetValue(int biketype, int bikerheight)
        {
            string bikesize = "";
            switch (biketype)
            {
                case 1:
                    {
                        if (bikerheight < 145)
                        {
                            bikesize = "Рекомендується придбати дитячий велосипед.";
                        }
                        if (bikerheight >= 145 && bikerheight < 155)
                        {
                            bikesize = "Рекомендується розмір рами 13\"-14\" або 33-35 сантиметрів (XS).";
                        }
                        if (bikerheight >= 155 && bikerheight < 165)
                        {
                            bikesize = "Рекомендується розмір рами 14\"-15\" або 35-38 сантиметрів (XS).";
                        }
                        if (bikerheight >= 165 && bikerheight < 170)
                        {
                            bikesize = "Рекомендується розмір рами 15\"-16\" або 38-41 сантиметр (XS-S).";
                        }
                        if (bikerheight >= 170 && bikerheight < 175)
                        {
                            bikesize = "Рекомендується розмір рами 16\"-17\" або 41-43 сантиметри (S-M).";
                        }
                        if (bikerheight >= 175 && bikerheight < 180)
                        {
                            bikesize = "Рекомендується розмір рами 17\"-18\" або 43-46 сантиметрів (M).";
                        }
                        if (bikerheight >= 180 && bikerheight < 185)
                        {
                            bikesize = "Рекомендується розмір рами 18\"-19\" або 46-48 сантиметрів (M-L).";
                        }
                        if (bikerheight >= 185 && bikerheight < 190)
                        {
                            bikesize = "Рекомендується розмір рами 19\"-21\" або 48-53 сантиметрів (L-XL).";
                        }
                        if (bikerheight >= 190 && bikerheight < 195)
                        {
                            bikesize = "Рекомендується розмір рами 21\"-22\" або 53-56 сантиметрів (XL).";
                        }
                        if (bikerheight >= 195 && bikerheight < 200)
                        {
                            bikesize = "Рекомендується розмір рами 22\"-23\" або 56-58 сантиметрів (XL-XXL).";
                        }
                        if (bikerheight >= 200)
                        {
                            bikesize = "Рекомендується розмір рами 23\"-24\" або 58-62 сантиметрів (XXL).";
                        }
                        break;
                    }
                case 2:
                    {
                        if (bikerheight < 155)
                        {
                            bikesize = "Рекомендується придбати дитячий велосипед.";
                        }
                        if (bikerheight >= 155 && bikerheight < 165)
                        {
                            bikesize = "Рекомендується розмір рами 48-51 сантиметр (XS).";
                        }
                        if (bikerheight >= 165 && bikerheight < 170)
                        {
                            bikesize = "Рекомендується розмір рами 51-53 сантиметри (S).";
                        }
                        if (bikerheight >= 170 && bikerheight < 175)
                        {
                            bikesize = "Рекомендується розмір рами 53-55 сантиметрів(S-M).";
                        }
                        if (bikerheight >= 175 && bikerheight < 180)
                        {
                            bikesize = "Рекомендується розмір рами 55-58 сантиметрів (M).";
                        }
                        if (bikerheight >= 180 && bikerheight < 185)
                        {
                            bikesize = "Рекомендується розмір рами 58-60 сантиметр (L).";
                        }
                        if (bikerheight >= 185 && bikerheight < 190)
                        {
                            bikesize = "Рекомендується розмір рами 60-61 сантиметри (L-XL).";
                        }
                        if (bikerheight >= 190 && bikerheight < 195)
                        {
                            bikesize = "Рекомендується розмір рами 61-62 сантиметрів (XL).";
                        }
                        if (bikerheight >= 195)
                        {
                            bikesize = "Рекомендується розмір рами більше 65 сантиметрів (XL).";
                        }
                        break;
                    }
                case 3:
                    {
                        if (bikerheight < 155)
                        {
                            bikesize = "Рекомендується придбати дитячий велосипед.";
                        }
                        if (bikerheight >= 155 && bikerheight < 170)
                        {
                            bikesize = "Рекомендується розмір рами 46-50 сантиметрів.";
                        }
                        if (bikerheight >= 170 && bikerheight < 185)
                        {
                            bikesize = "Рекомендується розмір рами 50-54 сантиметри.";
                        }
                        if (bikerheight >= 185 && bikerheight < 195)
                        {
                            bikesize = "Рекомендується розмір рами 54-58 сантиметрів.";
                        }
                        if (bikerheight >= 195)
                        {
                            bikesize = "Рекомендується розмір рами більше 58 сантиметрів.";
                        }
                        break;
                    }
                case 4:
                    {
                        if (bikerheight < 140)
                        {
                            bikesize = "Рекомендується придбати дитячий велосипед.";
                        }
                        if (bikerheight >= 140 && bikerheight < 150)
                        {
                            bikesize = "Рекомендується розмір рами (довжина верхньої труби) 19,5\".";
                        }
                        if (bikerheight >= 150 && bikerheight < 170)
                        {
                            bikesize = "Рекомендується розмір рами (довжина верхньої труби) 20,0\".";
                        }
                        if (bikerheight >= 170 && bikerheight < 180)
                        {
                            bikesize = "Рекомендується розмір рами (довжина верхньої труби) 20,5\".";
                        }
                        if (bikerheight >= 180)
                        {
                            bikesize = "Рекомендується розмір рами (довжина верхньої труби) 21,5\".";
                        }
                        break;
                    }
                case 5:
                    {
                        if (bikerheight >= 75 && bikerheight < 90)
                        {
                            bikesize = "Якщо дитині 1-3 роки рекомендується біговел або велосипед з колесами менше 12\", якщо 3-4 роки - з колесами 12\".";
                        }
                        if (bikerheight >= 90 && bikerheight < 100)
                        {
                            bikesize = "Рекомендується велосипед з колесами 12\".";
                        }
                        if (bikerheight >= 100 && bikerheight < 120)
                        {
                            bikesize = "Рекомендується велосипед з колесами 16\".";
                        }
                        if (bikerheight >= 120 && bikerheight < 135)
                        {
                            bikesize = "Рекомендується велосипед з колесами 20\".";
                        }
                        if (bikerheight >= 135 && bikerheight < 155)
                        {
                            bikesize = "Рекомендується велосипед з колесами 24\".";
                        }
                        if (bikerheight >= 155)
                        {
                            bikesize = "Рекомендується придбати велосипед для дорослого.";
                        }
                        break;
                    }
            }
            return bikesize;
        }

        public string GetNote(int biketype)
        {
            string bikenote = "";
            switch (biketype)
            {
                case 1:
                    {
                        bikenote = "Примітка: для отримання розміру рами МТБ помножте висоту внутрішньої сторони ноги на коефіцієнт 0,226. Значення, яке ви отримаєте, покаже ростовку рами в дюймах. Щоб отримати розмір в санти- метрах, отримане значення потрібно помножити на 2,54.";
                        break;
                    }
                case 2:
                    {
                        bikenote = "Примітка: для отримання розміру рами шосейного велосипеда помножте висоту внутрішньої сторони ноги на коефіцієнт 0,665. Отримане значення покаже ростовку рами в сантиметрах. Для триатлону від підрахованого значення потрібно відняти 3 см.";
                        break;
                    }
                case 3:
                    {
                        bikenote = "Примітка: для туристичних і трекінгових велосипедів помножте висоту внутрішньої сторони ноги на коефіцієнт 0,66. Значення, яке ви отримаєте, буде відповідати ростовці рами в сантиметрах. Якщо висоту внутрішньої сторони ноги помножити на 0,259, ви отримаєте розмір рами в дюймах.";
                        break;
                    }
                case 4:
                    {
                        bikenote = "Примітка: ростовкою у BMX називається довжина верхньої труби рами (top tube, TT). Вимірюється вона в дюймах. Проте вибір BMX - справа дуже індивідуальна. Комусь подобається кататися на ко- ротких рамах, комусь на довгих.";
                        break;
                    }
                case 5:
                    {
                        bikenote = "Примітка: кататися на велосипедах діти повинні обов'язково під наглядом дорослих.";
                        break;
                    }
            }
            return bikenote;
        }
    }

    class CalcCadence
    {
        public string GetValue(int a_size, int b_size, int bikespeed, int l_wheel)
        {
            int cadence = (int)((float)(bikespeed) / (float)(0.00006 * l_wheel * ((float)a_size / (float)b_size)));
            return "Каденс: " + cadence.ToString() + " об/хв";
        }
    }

    class CalcSpeed
    {
        public string GetValue(int a_size, int b_size, int cadence, int l_wheel)
        {
            float speed = (float)Math.Round(0.00006f * cadence * l_wheel * ((float)a_size / (float)b_size), 1);
            return "Швидкість: " + speed.ToString("0.0") + " км/год";
        }
    }

    class CalcSprocketB
    {
        public string GetValue(int a_size, int speed, int cadence, int l_wheel)
        {
            int b_size = (int)(0.00006 * cadence * l_wheel * ((float)a_size / (float)speed));
            return (b_size < 11) ? "Мінімальний розмір зірочки 11Т\n Потрібно змінити параметри підбору" : "Необхідна зірочка: " + b_size.ToString() + "T";
        }
    }

    class CalcPower
    {
        private string MinuteToHHMM(int minute)
        {
            int HH = minute / 60;
            int MM = minute % 60;
            return (MM != 0) ? HH.ToString() + " год " + MM.ToString() + " хв" : HH.ToString() + " год";
        }

        public string GetPowerValue(int weightbiker, int weightbike, float gradient, float rollresist, int bikerspeed, int windspeed, float airresist, int efficiency)
        {
            float wn = 9.8f * (weightbiker + weightbike);
            float gr = wn * (0.01f * gradient + rollresist);
            float rs = ((bikerspeed / 3.6f) + windspeed >= 0) ? (bikerspeed / 3.6f) + windspeed : 0;
            int power = (int)Math.Round(((bikerspeed / 3.6f) * gr + (bikerspeed / 3.6f) * rs * rs * airresist) / (0.01f * efficiency), 0);
            return "Необхідна потужність: " + power.ToString() + " Вт";
        }

        public string GetTripTimeValue(int distance, int bikerspeed)
        {
            int triptime = (int)Math.Round((16.6667f * distance) / (bikerspeed / 3.6f), 0);
            int totaltime = (int)Math.Round(1.25f * triptime, 0);
            int resttime = totaltime - triptime;
            return "Час \"в сідлі\": " + MinuteToHHMM(triptime) +" Відпочинок: " + MinuteToHHMM(resttime) + "\n Час подорожі: " + MinuteToHHMM(totaltime);
        }

        public string GetCaloriesValue(int weightbiker, int weightbike, float gradient, float rollresist, int bikerspeed, int windspeed, float airresist, int efficiency, int distance)
        {
            float wn = 9.8f * (weightbiker + weightbike);
            float gr = wn * (0.01f * gradient + rollresist);
            float rs = ((bikerspeed / 3.6f) + windspeed >= 0) ? (bikerspeed / 3.6f) + windspeed : 0;
            float power = ((bikerspeed / 3.6f) * gr + (bikerspeed / 3.6f) * rs * rs * airresist) / (0.01f * efficiency);
            float triptime = (16.6667f * distance) / (bikerspeed / 3.6f);
            int calories = (int)Math.Round(triptime / 60f * (power * 4f) / 1.163f, 0);  
            return "Витрата калорій: " + calories.ToString() + " ккал";
        }

        public string GetWeightLossValue(int weightbiker, int weightbike, float gradient, float rollresist, int bikerspeed, int windspeed, float airresist, int efficiency, int distance)
        {
            float wn = 9.8f * (weightbiker + weightbike);
            float gr = wn * (0.01f * gradient + rollresist);
            float rs = ((bikerspeed / 3.6f) + windspeed >= 0) ? (bikerspeed / 3.6f) + windspeed : 0;
            float power = ((bikerspeed / 3.6f) * gr + (bikerspeed / 3.6f) * rs * rs * airresist) / (0.01f * efficiency);
            float triptime = (16.6667f * distance) / (bikerspeed / 3.6f);
            float calories = triptime / 60f * (power * 4f) / 1.163f;
            float weightloss = (float)Math.Round(calories / 7716f, 2);
            return "* для тих, хто підтримує форму: можливість схуднути на " + weightloss.ToString() + " кг";
        }
    }
}