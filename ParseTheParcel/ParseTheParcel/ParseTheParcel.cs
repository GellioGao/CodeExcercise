﻿using System;

using ParseTheParcel.Interfaces;
using ParseTheParcel.Models;

namespace ParseTheParcel
{
    public class ParseTheParcel : IParseTheParcel
    {
        private readonly IParcelTypeParser parser;

        public ParseTheParcel(IParcelTypeParser parser)
        {
            if (parser == null)
            {
                throw new ArgumentNullException(nameof(parser));
            }
            this.parser = parser;
        }

        public Parcel CalculateCost(ParcelInfo info)
        {
            try
            {
                var parcel = this.parser.Calculate(info);
                return parcel;
            }
            catch (ArgumentNullException ane)
            {
                // Logs
            }
            catch (Exception ex)
            {
                // Logs
            }
            return new Parcel();
        }
    }
}