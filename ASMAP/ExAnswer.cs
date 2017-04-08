using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMAP
{
    class ExAnswer
    {
        private string _CauHoi;
        private string _DapA;
        private string _DapB;
        private string _DapC;
        private string _DapD;
        private string _DapAn;
        private string _BanChon;

        public string CauHoi
        {
            get { return _CauHoi; }
            set { _CauHoi = value; }
        }
        public string DapA
        {
            get { return _DapA; }
            set { _DapA = value; }
        }
        public string DapB
        {
            get { return _DapB; }
            set { _DapB = value; }
        }
        public string DapC
        {
            get { return _DapC; }
            set { _DapC = value; }
        }
        public string DapD
        {
            get { return _DapD; }
            set { _DapD = value; }
        }
        public string DapAn
        {
            get { return _DapAn; }
            set { _DapAn = value; }
        }
        public string BanChon
        {
            get { return _BanChon; }
            set { _BanChon = value; }
        }

        public ExAnswer() {
            this.CauHoi = string.Empty;
            this.DapA = string.Empty;
            this.DapB = string.Empty;
            this.DapC = string.Empty;
            this.DapD = string.Empty;
            this.DapAn = "0";
            this.BanChon = "0";
        }
        public ExAnswer(ExAnswer cau) {
            this.CauHoi = cau.CauHoi;
            this.DapA = cau.DapA;
            this.DapB = cau.DapB;
            this.DapC = cau.DapC;
            this.DapD = cau.DapD;
            this.DapAn = cau.DapAn;
            this.BanChon = cau.BanChon;
        }

    }
}
