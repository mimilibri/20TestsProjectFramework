

using System;
using OpenQA.Selenium;

namespace _20TestsProjectFramework.ComponentHelper
{
    public static class TableHelper
    {
        internal static string GetTableXpath(string locator, int row, int col)
        {
            return $"{locator}//tbody//tr[{row}]//td[{col}]";
        }

        public static string GetColumnValue(string @locator, int @row, int @col)
        {
            var tableXpath = GetTableXpath(locator, row, col);
            string value= String.Empty;
            var table = ObjectRepository.Driver.FindElement(By.XPath(tableXpath));


            if (table.Displayed)
            {
                value = table.Text;
            }

            return value;
        }

    }
}
