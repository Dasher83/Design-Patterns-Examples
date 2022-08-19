﻿using AbstractFactory.Interfaces;

namespace AbstractFactory.Models.Chairs
{
    internal class ArtDecoChair : IChair
    {
        private readonly byte _legs;
        private readonly bool _isReclinable;
        public ArtDecoChair(byte legs, bool isReclinable)
        {
            _legs = legs;
            _isReclinable = isReclinable;
        }

        public byte Legs => _legs;

        public bool IsReclinable => _isReclinable;

        public void SitOn()
        {
            string reclinable = _isReclinable ? "reclinable " : "";
            string legs = _legs > 0 ? $"{_legs} " : "no ";
            Console.WriteLine($"I'm sitting on a {reclinable}Art Deco style chair with {legs}legs!");
            Console.WriteLine();
        }
    }
}
