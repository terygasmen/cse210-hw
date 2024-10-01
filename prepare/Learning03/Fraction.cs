using System;

public class Fraction {
        private int _numerator;
        private int _denominator;

        // no paramters (1/1)
        public Fraction() {
                _numerator = 1;
                _denominator = 1;
        }
        // one parameter (numerator/1)
        public Fraction(int numerator) {
                _numerator = numerator;
                _denominator = 1;
        }
        // two parameters (numerator/denominator)
        public Fraction(int numerator, int denominator) {
                _numerator = numerator;
                _denominator = denominator;
        }

        //getter setter for the numerator
        public int GetNumerator() {
                return _numerator;
        }
        public void SetNumerator(int numerator) {
                _numerator = numerator;
        }

        //getter setter for denominator
        public int GetDenominator() {
                return _denominator;
        }
        public void SetDenominator(int denominator) {
                _denominator = denominator;
        }

        // return fraction as a string
        public string GetFractionString() {
                return $"{_numerator}/{_denominator}";
        }
        // return decimal value of the fraction
        public double GetDecimalValue() {
                return (double)_numerator / _denominator;
        }
}