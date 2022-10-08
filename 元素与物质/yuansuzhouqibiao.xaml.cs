using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Store;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// https://go.microsoft.com/fwlink/?LinkId=234238 上介绍了“空白页”项模板

namespace 元素与物质
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class yuansuzhouqibiao : Page
    {

        public yuansuzhouqibiao()
        {
            this.InitializeComponent();
        }




        private void H_Click(object sender, RoutedEventArgs e)
        {
            T1.Text = "1";
            Xiangduiyuanzizhiliang.Text = "1.008";
            Yuansu.Text = "H";
            Zhouqi.Text = "1";
            Zu.Text = "lA";
            ZHUANGTAI.Text = "气态";
            RONGDIAN.Text = "-259";
            FEIDIAN.Text = "-253";
            MIDU.Text = "0.00008988";
            YANSE.Text = "无色";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "53";
            YUANZITIJI.Text = "14.40";
            DIANFUXING.Text = "2.20";
            DIANLINENG.Text = "13.5984";
            DIANZIPAIBU.Text = "1";
            CHZN.Text = "氢";
            EN.Text = "hydrogen";
            T.Text = "非纯净氢气易爆炸";
        }

        private void He_Click(object sender, RoutedEventArgs e)
        {
            T1.Text = "2";
            Xiangduiyuanzizhiliang.Text = "4.003";
            Yuansu.Text = "He";
            Zhouqi.Text = "1";
            Zu.Text = "IIA";
            ZHUANGTAI.Text = "气态";
            RONGDIAN.Text = "-272.20";
            FEIDIAN.Text = "-268.93";
            MIDU.Text = "0.0001785";
            YANSE.Text = "无色";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "31";
            YUANZITIJI.Text = "27.20";
            DIANFUXING.Text = "-";
            DIANLINENG.Text = "24.5874";
            DIANZIPAIBU.Text = "2";
            CHZN.Text = "氦";
            EN.Text = "helium";
            T.Text = "吸入大量氦气会导致缺氧，对人体有害";

        }

        private void Li_Click(object sender, RoutedEventArgs e)
        {
            T1.Text = "3";
            Xiangduiyuanzizhiliang.Text = "6.941";
            Yuansu.Text = "Li";
            Zhouqi.Text = "2";
            Zu.Text = "IA";
            ZHUANGTAI.Text = "固态";
            RONGDIAN.Text = "180.54";
            FEIDIAN.Text = "1342";
            MIDU.Text = "0.534";
            YANSE.Text = "银色";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "152";
            YUANZITIJI.Text = "13.1";
            DIANFUXING.Text = "0.98";
            DIANLINENG.Text = "5.3917";
            DIANZIPAIBU.Text = "2,1";
            CHZN.Text = "锂";
            EN.Text = "lithium";
            T.Text = "锂离开无氮空间，接触水就会发生分解，产生刺鼻的气味；同时具有腐蚀性";

        }

        private void Be_Click(object sender, RoutedEventArgs e)
        {
            T1.Text = "4";
            Xiangduiyuanzizhiliang.Text = "9.012";
            Yuansu.Text = "Be";
            Zhouqi.Text = "2";
            Zu.Text = "IIA";
            ZHUANGTAI.Text = "固态";
            RONGDIAN.Text = "1287";
            FEIDIAN.Text = "2469";
            MIDU.Text = "1.85";
            YANSE.Text = "灰色";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "112";
            YUANZITIJI.Text = "4.9";
            DIANFUXING.Text = "1.57";
            DIANLINENG.Text = "9.3227";
            DIANZIPAIBU.Text = "2,2";
            CHZN.Text = "铍";
            EN.Text = "beryllium";
            T.Text = "一立方米的空气中只要有一毫克铍的粉尘,就会使人染上急性肺炎";

        }

        private void B_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "B";
            T1.Text = "5";
            Xiangduiyuanzizhiliang.Text = "10.81";
            Zhouqi.Text = "2";
            Zu.Text = "IIIA";
            ZHUANGTAI.Text = "固态";
            RONGDIAN.Text = "2076";
            FEIDIAN.Text = "3927";
            MIDU.Text = "2.34";
            YANSE.Text = "黑色";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "90";
            YUANZITIJI.Text = "4.6";
            DIANFUXING.Text = "2.04";
            DIANLINENG.Text = "8.298";
            DIANZIPAIBU.Text = "2,3";
            CHZN.Text = "硼";
            EN.Text = "boron";
            T.Text = "硼酸、硼砂等可用作医药，两者均有毒性";

        }

        private void C_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "C";
            T1.Text = "6";
            Xiangduiyuanzizhiliang.Text = "12.01";
            Zhouqi.Text = "2";
            Zu.Text = "IVA";
            ZHUANGTAI.Text = "固态";
            RONGDIAN.Text = "3675";
            FEIDIAN.Text = "4027";
            MIDU.Text = "2.267";
            YANSE.Text = "黑色";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "67";
            YUANZITIJI.Text = "5.31";
            DIANFUXING.Text = "2.55";
            DIANLINENG.Text = "11.2603";
            DIANZIPAIBU.Text = "2,4";
            CHZN.Text = "碳";
            EN.Text = "carbon";
            T.Text = "纯碳对人类几乎无毒；碳污染是指二氧化碳的污染";

        }

        private void N_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "N";
            T1.Text = "7";
            Xiangduiyuanzizhiliang.Text = "14.01";
            Zhouqi.Text = "2";
            Zu.Text = "VA";
            ZHUANGTAI.Text = "气态";
            RONGDIAN.Text = "-210";
            FEIDIAN.Text = "-195.79";
            MIDU.Text = "0.0012506";
            YANSE.Text = "无色";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "56";
            DIANFUXING.Text = "3.04";
            DIANLINENG.Text = "14.5341";
            YUANZITIJI.Text = "17.3";
            DIANZIPAIBU.Text = "2,5";
            CHZN.Text = "氮";
            EN.Text = "nitrogen";
            T.Text = "通常无毒；氮污染 （nitrogen pollution）指由氮的化合物引起的环境污染";

        }

        private void O_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "O";
            T1.Text = "8";
            Xiangduiyuanzizhiliang.Text = "16";
            Zhouqi.Text = "2";
            Zu.Text = "VIA";
            ZHUANGTAI.Text = "气态";
            RONGDIAN.Text = "-218.79";
            FEIDIAN.Text = "-182.95";
            MIDU.Text = "0.001429";
            YANSE.Text = "无色";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "48";
            DIANFUXING.Text = "3.44";
            DIANLINENG.Text = "13.6181";
            YUANZITIJI.Text = "14";
            DIANZIPAIBU.Text = "2,6";
            CHZN.Text = "氧";
            EN.Text = "oxygen";
            T.Text = "在炼钢过程中吹以高纯度氧气，氧便和碳及磷、硫、硅等起氧化反应，这不但降低了钢的含碳量，还有利于清除磷、硫、硅等杂质";

        }

        private void F_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "F";
            T1.Text = "9";
            Xiangduiyuanzizhiliang.Text = "19";
            Zhouqi.Text = "2";
            Zu.Text = "VIIA";
            ZHUANGTAI.Text = "气态";
            MIDU.Text = "0.001696";
            RONGDIAN.Text = "-219.62";
            FEIDIAN.Text = "-188.12";
            YANSE.Text = "无色";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "42";
            DIANFUXING.Text = "3.98";
            DIANLINENG.Text = "17.4228";
            YUANZITIJI.Text = "17.1";
            DIANZIPAIBU.Text = "2,7";
            CHZN.Text = "氟";
            EN.Text = "fluorine";
            T.Text = "一种剧毒的气体，腐蚀性也很强";

        }

        private void Ne_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Ne";
            T1.Text = "10";
            Xiangduiyuanzizhiliang.Text = "20.18";
            Zhouqi.Text = "2";
            Zu.Text = "0";
            ZHUANGTAI.Text = "气态";
            MIDU.Text = "0.008999";
            RONGDIAN.Text = "-248.59";
            FEIDIAN.Text = "-246.08";
            YANSE.Text = "无色";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "38";
            DIANFUXING.Text = "-";
            DIANLINENG.Text = "21.5645";
            YUANZITIJI.Text = "16.7";
            DIANZIPAIBU.Text = "2,8";
            CHZN.Text = "氖";
            EN.Text = "neon";
            T.Text = "氖最常用在霓红灯之中";

        }

        private void Na_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Na";
            T1.Text = "11";
            Xiangduiyuanzizhiliang.Text = "20.18";
            Zhouqi.Text = "3";
            Zu.Text = "IA";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "0.971";
            RONGDIAN.Text = "97.72";
            FEIDIAN.Text = "883";
            YANSE.Text = "银色";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "186";
            DIANFUXING.Text = "0.93";
            DIANLINENG.Text = "5.1391";
            YUANZITIJI.Text = "23.7";
            DIANZIPAIBU.Text = "2,8,1";
            CHZN.Text = "钠";
            EN.Text = "sodium";
            T.Text = "钠是一种很强的还原剂，可以把钛、钴、铌等金属从它们的卤化物里还原出来；钠也应用在电光源上，高压钠灯发出的黄光透雾能力强";

        }

        private void Mg_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Mg";
            T1.Text = "12";
            Xiangduiyuanzizhiliang.Text = "24.31";
            Zhouqi.Text = "3";
            Zu.Text = "IIA";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "1.738";
            RONGDIAN.Text = "650";
            FEIDIAN.Text = "1090";
            YANSE.Text = "银色";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "160";
            DIANFUXING.Text = "1.31";
            DIANLINENG.Text = "7.6462";
            YUANZITIJI.Text = "13.97";
            DIANZIPAIBU.Text = "2,8,2";
            CHZN.Text = "镁";
            EN.Text = "magnesium";
            T.Text = "金属镁是人类可以制得并在空气中长期存在的有实用价值的最轻的金属,在工业上通常由电解法或硅还原法制得";

        }

        private void Al_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Al";
            T1.Text = "13";
            Xiangduiyuanzizhiliang.Text = "26.98";
            Zhouqi.Text = "3";
            Zu.Text = "IIIA";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "2.698";
            RONGDIAN.Text = "660.32";
            FEIDIAN.Text = "2519";
            YANSE.Text = "银色";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "143";
            DIANFUXING.Text = "1.61";
            DIANLINENG.Text = "5.9858";
            YUANZITIJI.Text = "9.98";
            DIANZIPAIBU.Text = "2,8,3";
            CHZN.Text = "铝";
            EN.Text = "aluminum";
            T.Text = "纯铝可做超高电压的电缆";

        }

        private void Si_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Si";
            T1.Text = "14";
            Xiangduiyuanzizhiliang.Text = "28.09";
            Zhouqi.Text = "3";
            Zu.Text = "IVA";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "2.3296";
            RONGDIAN.Text = "1414";
            FEIDIAN.Text = "3265";
            YANSE.Text = "灰色";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "111";
            DIANFUXING.Text = "1.90";
            DIANLINENG.Text = "8.1517";
            YUANZITIJI.Text = "12.1";
            DIANZIPAIBU.Text = "2,8,4";
            CHZN.Text = "硅";
            EN.Text = "silicon";
            T.Text = "金属硅是工业提纯的单质硅，主要用于生产有机硅、制取高纯度的半导体材料以及配制有特殊用途的合金等";

        }

        private void P_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "P";
            T1.Text = "15";
            Xiangduiyuanzizhiliang.Text = "30.97";
            Zhouqi.Text = "3";
            Zu.Text = "VA";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "1.82";
            RONGDIAN.Text = "44.1";
            FEIDIAN.Text = "279.85";
            YANSE.Text = "无色";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "98";
            DIANFUXING.Text = "2.19";
            DIANLINENG.Text = "10.4867";
            YUANZITIJI.Text = "17";
            DIANZIPAIBU.Text = "2,8,5";
            CHZN.Text = "磷";
            EN.Text = "phosphorus";
            T.Text = "磷是生物细胞质的重要组成元素，也是植物生长必不可少的一种元素。世界上84%～90%的磷矿用于生产各种磷肥，3.3%生产饲料添加剂，4%生产洗涤剂，其余用于化工、轻工、国防等工业";

        }

        private void S_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "S";
            T1.Text = "16";
            Xiangduiyuanzizhiliang.Text = "32.06";
            Zhouqi.Text = "3";
            Zu.Text = "VIA";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "2.067";
            RONGDIAN.Text = "115.21";
            FEIDIAN.Text = "444.65";
            YANSE.Text = "黄色";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "88";
            DIANFUXING.Text = "2.58";
            DIANLINENG.Text = "10.36";
            YUANZITIJI.Text = "15.5";
            DIANZIPAIBU.Text = "2,8,6";
            CHZN.Text = "硫";
            EN.Text = "sulfur";
            T.Text = "大部分用于制造硫酸。橡胶制品工业、火柴、烟火、硫酸盐、亚硫酸盐、硫化物等产品中也需要很多硫磺";

        }

        private void Cl_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Cl";
            T1.Text = "17";
            Xiangduiyuanzizhiliang.Text = "35.45";
            Zhouqi.Text = "3";
            Zu.Text = "VIIA";
            ZHUANGTAI.Text = "气态";
            MIDU.Text = "0.003214";
            RONGDIAN.Text = "-101.5";
            FEIDIAN.Text = "-34.04";
            YANSE.Text = "黄色";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "79";
            DIANFUXING.Text = "3.16";
            DIANLINENG.Text = "12.9676";
            YUANZITIJI.Text = "22.7";
            DIANZIPAIBU.Text = "2,8,7";
            CHZN.Text = "氯";
            EN.Text = "chlorine";
            T.Text = "氯主要用于化学工业尤其是有机合成工业上，以生产塑料、合成橡胶、染料及其他化学制品或中间体，还用于漂白剂、消毒剂、合成药物等";

        }

        private void Ar_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Ar";
            T1.Text = "18";
            Xiangduiyuanzizhiliang.Text = "39.95";
            Zhouqi.Text = "3";
            Zu.Text = "0";
            ZHUANGTAI.Text = "气态";
            MIDU.Text = "0.0017837";
            RONGDIAN.Text = "-189.35";
            FEIDIAN.Text = "-185.85";
            YANSE.Text = "无色";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "71";
            DIANFUXING.Text = "-";
            DIANLINENG.Text = "15.7596";
            YUANZITIJI.Text = "22.4";
            DIANZIPAIBU.Text = "2,8,8";
            CHZN.Text = "氩";
            EN.Text = "argon";
            T.Text = "在飞机制造、造船、原子能工业和机械工业部门，对特殊金属，例如铝、镁、铜及其合金和不锈钢在焊接时，往往用氩作为焊接保护气，防止焊接件被空气氧化或氮化";

        }

        private void K_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "K";
            T1.Text = "19";
            Xiangduiyuanzizhiliang.Text = "39.0983";
            Zhouqi.Text = "4";
            Zu.Text = "IA";
            YANSE.Text = "银色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "0.862";
            RONGDIAN.Text = "63.38";
            FEIDIAN.Text = "759";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "227";
            DIANFUXING.Text = "0.82";
            DIANLINENG.Text = "4.3407";
            YUANZITIJI.Text = "45.46";
            DIANZIPAIBU.Text = "2,8,8,1";
            CHZN.Text = "钾";
            EN.Text = "kalium";
            T.Text = "钾在陶瓷、玻璃、印染、纺织、医药、电子、航空、冶金等方面也有着巨大的应用";

        }

        private void Ca_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Ca";
            T1.Text = "20";
            Xiangduiyuanzizhiliang.Text = "40.078";
            Zhouqi.Text = "4";
            Zu.Text = "IIA";
            YANSE.Text = "银色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "1.54";
            RONGDIAN.Text = "1115.15";
            FEIDIAN.Text = "1757.15";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "197";
            DIANFUXING.Text = "1";
            DIANLINENG.Text = "6.1132";
            YUANZITIJI.Text = "29.9";
            DIANZIPAIBU.Text = "2,8,8,2";
            CHZN.Text = "钙";
            EN.Text = "calcium";
            T.Text = "钙是构成人体骨骼和牙齿的主要成分，且在维持人体循环、呼吸、神经、内分泌、消化、血液、肌肉、骨骼、泌尿、免疫等各系统正常生理功能中起重要调节作用";

        }

        private void Sc_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Sc";
            T1.Text = "21";
            Xiangduiyuanzizhiliang.Text = "44.9559";
            Zhouqi.Text = "4";
            Zu.Text = "IIIB";
            YANSE.Text = "银色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "2.99";
            RONGDIAN.Text = "1814.15";
            FEIDIAN.Text = "3109.15";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "162";
            DIANFUXING.Text = "1.36";
            DIANLINENG.Text = "6.5615";
            YUANZITIJI.Text = "15";
            DIANZIPAIBU.Text = "2,8,9,2";
            CHZN.Text = "钪";
            EN.Text = "Scandium";
            T.Text = "一种柔软过渡金属，常与钆、铒混合存在";

        }

        private void Ti_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Ti";
            T1.Text = "22";
            Xiangduiyuanzizhiliang.Text = "47.867";
            Zhouqi.Text = "4";
            Zu.Text = "IVB";
            YANSE.Text = "银色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "4.54";
            RONGDIAN.Text = "1941.15";
            FEIDIAN.Text = "356015";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "147";
            DIANFUXING.Text = "1.54";
            DIANLINENG.Text = "6.8281";
            YUANZITIJI.Text = "10.64";
            DIANZIPAIBU.Text = "2,8,10,2";
            CHZN.Text = "钛";
            EN.Text = "Titanium";
            T.Text = "能在氮气中燃烧，熔点高";

        }

        private void V_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "V";
            T1.Text = "23";
            Xiangduiyuanzizhiliang.Text = "50.9415";
            Zhouqi.Text = "4";
            Zu.Text = "VB";
            YANSE.Text = "银色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "6.11";
            RONGDIAN.Text = "2183.15";
            FEIDIAN.Text = "3680.15";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "134";
            DIANFUXING.Text = "1.63";
            DIANLINENG.Text = "6.8281";
            YUANZITIJI.Text = "8.78";
            DIANZIPAIBU.Text = "2,8,11,2";
            CHZN.Text = "钒";
            EN.Text = "Vanadium";
            T.Text = "高熔点稀有金属";

        }

        private void Cr_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Cr";
            T1.Text = "24";
            Xiangduiyuanzizhiliang.Text = "51.9961";
            Zhouqi.Text = "4";
            Zu.Text = "VIB";
            YANSE.Text = "银色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "7.15";
            RONGDIAN.Text = "2180.15";
            FEIDIAN.Text = "2944.15";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "128";
            DIANFUXING.Text = "1.66";
            DIANLINENG.Text = "6.7665";
            YUANZITIJI.Text = "7.23";
            DIANZIPAIBU.Text = "2,8,13,1";
            CHZN.Text = "铬";
            EN.Text = "Chromium";
            T.Text = "硬度最高的金属";

        }

        private void Mn_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Mn";
            T1.Text = "25";
            Xiangduiyuanzizhiliang.Text = "54.9380";
            Zhouqi.Text = "4";
            Zu.Text = "VIIB";
            YANSE.Text = "银色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "7.44";
            RONGDIAN.Text = "1519.15";
            FEIDIAN.Text = "2334.15";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "127";
            DIANFUXING.Text = "1.55";
            DIANLINENG.Text = "7.434";
            YUANZITIJI.Text = "7.40";
            DIANZIPAIBU.Text = "2,8,13,2";
            CHZN.Text = "锰";
            EN.Text = "Manganese";
            T.Text = "在地壳中分布广泛";

        }

        private void Fe_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Fe";
            T1.Text = "26";
            Xiangduiyuanzizhiliang.Text = "55.845";
            Zhouqi.Text = "4";
            Zu.Text = "VIII";
            YANSE.Text = "灰色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "7.874";
            RONGDIAN.Text = "1811.15";
            FEIDIAN.Text = "3134.15";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "126";
            DIANFUXING.Text = "1.83";
            DIANLINENG.Text = "7.9024";
            YUANZITIJI.Text = "7.10";
            DIANZIPAIBU.Text = "2,8,14,2";
            CHZN.Text = "铁";
            EN.Text = "Iron";
            T.Text = "地壳含量第二高，单质产量最高，有磁性";

        }

        private void Co_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Co";
            T1.Text = "27";
            Xiangduiyuanzizhiliang.Text = "58.9332";
            Zhouqi.Text = "4";
            Zu.Text = "VIII";
            YANSE.Text = "灰色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "8.86";
            RONGDIAN.Text = "1768.15";
            FEIDIAN.Text = "3200.15";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "125";
            DIANFUXING.Text = "1.88";
            DIANLINENG.Text = "7.881";
            YUANZITIJI.Text = "6.70";
            DIANZIPAIBU.Text = "2,8,15,2";
            CHZN.Text = "钴";
            EN.Text = "Cobalt";
            T.Text = "同位素60Co被应用于X光发生器中，有磁性";

        }

        private void Ni_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Ni";
            T1.Text = "28";
            Xiangduiyuanzizhiliang.Text = "58.6934";
            Zhouqi.Text = "4";
            Zu.Text = "VIII";
            YANSE.Text = "灰色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "8.912";
            RONGDIAN.Text = "1728.15";
            FEIDIAN.Text = "3186.15";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "124";
            DIANFUXING.Text = "1.91";
            DIANLINENG.Text = "7.6398";
            YUANZITIJI.Text = "6.59";
            DIANZIPAIBU.Text = "2,8,16,2";
            CHZN.Text = "镍";
            EN.Text = "Nickel";
            T.Text = "有磁性和良好可塑性";

        }

        private void Cu_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Cu";
            T1.Text = "29";
            Xiangduiyuanzizhiliang.Text = "63.546";
            Zhouqi.Text = "4";
            Zu.Text = "IB";
            YANSE.Text = "铜色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "8.96";
            RONGDIAN.Text = "1357.75";
            FEIDIAN.Text = "2835.15";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "128";
            DIANFUXING.Text = "1.90";
            DIANLINENG.Text = "7.7264";
            YUANZITIJI.Text = "7.10";
            DIANZIPAIBU.Text = "2,8,18,1";
            CHZN.Text = "铜";
            EN.Text = "Copper";
            T.Text = "人类发现较早的金属之一，可塑性很好";

        }

        private void Zn_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Zn";
            T1.Text = "30";
            Xiangduiyuanzizhiliang.Text = "65.38";
            Zhouqi.Text = "4";
            Zu.Text = "IIB";
            YANSE.Text = "灰色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "7.134";
            RONGDIAN.Text = "692.68";
            FEIDIAN.Text = "1180.15";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "134";
            DIANFUXING.Text = "1.65";
            DIANLINENG.Text = "9.3942";
            YUANZITIJI.Text = "9.20";
            DIANZIPAIBU.Text = "2,8,18,2";
            CHZN.Text = "锌";
            EN.Text = "Zinc";
            T.Text = "人体需要的微量元素";

        }

        private void Ga_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Ga";
            T1.Text = "31";
            Xiangduiyuanzizhiliang.Text = "69.723";
            Zhouqi.Text = "4";
            Zu.Text = "IIIA";
            YANSE.Text = "银色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "5.907";
            RONGDIAN.Text = "302.91";
            FEIDIAN.Text = "2477.15";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "135";
            DIANFUXING.Text = "1.81";
            DIANLINENG.Text = "5.9993";
            YUANZITIJI.Text = "11.8";
            DIANZIPAIBU.Text = "2,8,18,3";
            CHZN.Text = "镓";
            EN.Text = "Gallium";
            T.Text = "熔点低沸点高";

        }

        private void Ge_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Ge";
            T1.Text = "32";
            Xiangduiyuanzizhiliang.Text = "72.63";
            Zhouqi.Text = "4";
            Zu.Text = "IVA";
            YANSE.Text = "灰色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "5.323";
            RONGDIAN.Text = "1211.40";
            FEIDIAN.Text = "3106.15";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "122";
            DIANFUXING.Text = "2.01";
            DIANLINENG.Text = "7.8994";
            YUANZITIJI.Text = "13.6";
            DIANZIPAIBU.Text = "2,8,18,4";
            CHZN.Text = "Ge";
            EN.Text = "Germanium";
            T.Text = "是一种重要的半导体材料";

        }

        private void As_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "As";
            T1.Text = "33";
            Xiangduiyuanzizhiliang.Text = "74.9216";
            Zhouqi.Text = "4";
            Zu.Text = "VA";
            YANSE.Text = "银色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "5.776";
            RONGDIAN.Text = "1090.15";
            FEIDIAN.Text = "876.15";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "119";
            DIANFUXING.Text = "2.18";
            DIANLINENG.Text = "9.7886";
            YUANZITIJI.Text = "12.97";
            DIANZIPAIBU.Text = "2,8,18,5";
            CHZN.Text = "砷";
            EN.Text = "Arsenic";
            T.Text = "As2O3（即砒霜）剧毒";

        }

        private void Se_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Se";
            T1.Text = "34";
            Xiangduiyuanzizhiliang.Text = "78.96";
            Zhouqi.Text = "4";
            Zu.Text = "VIA";
            YANSE.Text = "灰色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "4.809";
            RONGDIAN.Text = "494.15";
            FEIDIAN.Text = "958.15";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "120";
            DIANFUXING.Text = "2.55";
            DIANLINENG.Text = "9.7524";
            YUANZITIJI.Text = "16.45";
            DIANZIPAIBU.Text = "2,8,18,6";
            CHZN.Text = "硒";
            EN.Text = "Selenium";
            T.Text = "可使玻璃致色为鲜红色";

        }

        private void Br_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Br";
            T1.Text = "35";
            Xiangduiyuanzizhiliang.Text = "79.904";
            Zhouqi.Text = "4";
            Zu.Text = "VIIA";
            YANSE.Text = "红色";
            ZHUANGTAI.Text = "液态";
            MIDU.Text = "3.122";
            RONGDIAN.Text = "265.95";
            FEIDIAN.Text = "331.95";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "120";
            DIANFUXING.Text = "2.96";
            DIANLINENG.Text = "11.8138";
            YUANZITIJI.Text = "23.5";
            DIANZIPAIBU.Text = "2,8,18,7";
            CHZN.Text = "溴";
            EN.Text = "Bromine";
            T.Text = "活泼，单质为红棕色液体";

        }

        private void Kr_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Kr";
            T1.Text = "36";
            Xiangduiyuanzizhiliang.Text = "83.798";
            Zhouqi.Text = "4";
            Zu.Text = "0";
            YANSE.Text = "无色";
            ZHUANGTAI.Text = "气态";
            MIDU.Text = "0.0037";
            RONGDIAN.Text = "115.79";
            FEIDIAN.Text = "119.93";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "88";
            DIANFUXING.Text = "1.36";
            DIANLINENG.Text = "3";
            YUANZITIJI.Text = "38.9";
            DIANZIPAIBU.Text = "2,8,18,8";
            CHZN.Text = "氪";
            EN.Text = "Krypton";
            T.Text = "稀有气体之一";

        }

        private void Rb_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Rb";
            T1.Text = "37";
            Xiangduiyuanzizhiliang.Text = "85.4678";
            Zhouqi.Text = "5";
            Zu.Text = "IA";
            YANSE.Text = "银色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "1.532";
            RONGDIAN.Text = "312.46";
            FEIDIAN.Text = "961.15";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "248";
            DIANFUXING.Text = "0.82";
            DIANLINENG.Text = "4.1771";
            YUANZITIJI.Text = "55.90";
            DIANZIPAIBU.Text = "2,8,18,8,1";
            CHZN.Text = "铷";
            EN.Text = "Rubidium";
            T.Text = "比钾活泼";

        }

        private void Sr_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Sr";
            T1.Text = "38";
            Xiangduiyuanzizhiliang.Text = "87.62";
            Zhouqi.Text = "5";
            Zu.Text = "IIA";
            YANSE.Text = "银色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "2.64";
            RONGDIAN.Text = "1050.15";
            FEIDIAN.Text = "1655.15";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "215";
            DIANFUXING.Text = "0.95";
            DIANLINENG.Text = "5.6949";
            YUANZITIJI.Text = "33.7";
            DIANZIPAIBU.Text = "2,8,18,8,2";
            CHZN.Text = "锶";
            EN.Text = "Strontium";
            T.Text = "是碱土元素中丰度最小的元素";

        }

        private void Y_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Y";
            T1.Text = "39";
            Xiangduiyuanzizhiliang.Text = "88.9059";
            Zhouqi.Text = "5";
            Zu.Text = "IIIB";
            YANSE.Text = "银色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "4.469";
            RONGDIAN.Text = "1799.15";
            FEIDIAN.Text = "3609.15";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "180";
            DIANFUXING.Text = "1.22";
            DIANLINENG.Text = "6.2173";
            YUANZITIJI.Text = "19.8";
            DIANZIPAIBU.Text = "2,8,18,9,2";
            CHZN.Text = "钇";
            EN.Text = "Yttrium";
            T.Text = "人工合成的钇铝榴石曾被当做钻石的替代品";

        }

        private void Zr_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Zr";
            T1.Text = "40";
            Xiangduiyuanzizhiliang.Text = "91.224";
            Zhouqi.Text = "5";
            Zu.Text = "IVB";
            YANSE.Text = "银色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "6.506";
            RONGDIAN.Text = "2128.15";
            FEIDIAN.Text = "4682.15";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "160";
            DIANFUXING.Text = "1.33";
            DIANLINENG.Text = "6.6339";
            YUANZITIJI.Text = "14.0";
            DIANZIPAIBU.Text = "2,8,18,10,2";
            CHZN.Text = "锆";
            EN.Text = "Zirconium";
            T.Text = "化物立方氧化锆为钻石的人工替代品";

        }

        private void Nb_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Nb";
            T1.Text = "41";
            Xiangduiyuanzizhiliang.Text = "92.90638";
            Zhouqi.Text = "5";
            Zu.Text = "VB";
            YANSE.Text = "灰色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "8.57";
            RONGDIAN.Text = "2750.15";
            FEIDIAN.Text = "5017.15";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "146";
            DIANFUXING.Text = "1.60";
            DIANLINENG.Text = "6.7589";
            YUANZITIJI.Text = "10.87";
            DIANZIPAIBU.Text = "2,8,18,12,1";
            CHZN.Text = "铌";
            EN.Text = "Niobium";
            T.Text = "铌钢被用于制作汽车外壳";

        }

        private void Mo_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Mo";
            T1.Text = "42";
            Xiangduiyuanzizhiliang.Text = "95.96";
            Zhouqi.Text = "5";
            Zu.Text = "VIB";
            YANSE.Text = "灰色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "10.22";
            RONGDIAN.Text = "2896.15";
            FEIDIAN.Text = "4912.15";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "139";
            DIANFUXING.Text = "2.16";
            DIANLINENG.Text = "7.0924";
            YUANZITIJI.Text = "9.4";
            DIANZIPAIBU.Text = "2,8,18,13,1";
            CHZN.Text = "钼";
            EN.Text = "Molybdenum";
            T.Text = "植物生长所需的微量元素";

        }

        private void Tc_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Tc";
            T1.Text = "43";
            Xiangduiyuanzizhiliang.Text = "[98]";
            Zhouqi.Text = "5";
            Zu.Text = "VIIB";
            YANSE.Text = "银色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "11.5";
            RONGDIAN.Text = "2430.15";
            FEIDIAN.Text = "4538.15";
            FANGSHEXING.Text = "存在";
            YUANZIBANJING.Text = "136";
            DIANFUXING.Text = "1.90";
            DIANLINENG.Text = "7.28";
            YUANZITIJI.Text = "8.50";
            DIANZIPAIBU.Text = "2,8,18,13,2";
            CHZN.Text = "锝";
            EN.Text = "Technetium";
            T.Text = "原子序数最小的放射性元素";

        }

        private void Ru_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Ru";
            T1.Text = "44";
            Xiangduiyuanzizhiliang.Text = "101.07";
            Zhouqi.Text = "5";
            Zu.Text = "VIII";
            YANSE.Text = "银色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "12.37";
            RONGDIAN.Text = "2607.15";
            FEIDIAN.Text = "4423.15";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "134";
            DIANFUXING.Text = "2.20";
            DIANLINENG.Text = "7.3605";
            YUANZITIJI.Text = "8.3";
            DIANZIPAIBU.Text = "2,8,18,15,1";
            CHZN.Text = "钌";
            EN.Text = "Ruthenium";
            T.Text = "硬而脆呈浅灰色的多价稀有金属元素";

        }

        private void Rh_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Rh";
            T1.Text = "45";
            Xiangduiyuanzizhiliang.Text = "102.9055";
            Zhouqi.Text = "5";
            Zu.Text = "VIII";
            YANSE.Text = "银色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "12.41";
            RONGDIAN.Text = "2237.15";
            FEIDIAN.Text = "3968.15";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "134";
            DIANFUXING.Text = "2.28";
            DIANLINENG.Text = "7.4589";
            YUANZITIJI.Text = "8.3";
            DIANZIPAIBU.Text = "2,8,18,16,1";
            CHZN.Text = "钌";
            EN.Text = "Ruthenium";
            T.Text = "硬而脆呈浅灰色的多价稀有金属元素";

        }

        private void Pd_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Pd";
            T1.Text = "46";
            Xiangduiyuanzizhiliang.Text = "106.42";
            Zhouqi.Text = "5";
            Zu.Text = "VIII";
            YANSE.Text = "银色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "12.02";
            RONGDIAN.Text = "1828.05";
            FEIDIAN.Text = "3236.15";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "137";
            DIANFUXING.Text = "2.20";
            DIANLINENG.Text = "8.3369";
            YUANZITIJI.Text = "8.90";
            DIANZIPAIBU.Text = "2,8,18,18";
            CHZN.Text = "钯";
            EN.Text = "Palladium";
            T.Text = "被应用于酒精检测中";

        }

        private void Ag_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Ag";
            T1.Text = "47";
            Xiangduiyuanzizhiliang.Text = "107.8682";
            Zhouqi.Text = "5";
            Zu.Text = "IB";
            YANSE.Text = "银色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "10.49";
            RONGDIAN.Text = "1234.93";
            FEIDIAN.Text = "2435.15";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "144";
            DIANFUXING.Text = "1.93";
            DIANLINENG.Text = "7.5762";
            YUANZITIJI.Text = "10.30";
            DIANZIPAIBU.Text = "2,8,18,18,1";
            CHZN.Text = "银";
            EN.Text = "Silver";
            T.Text = "贵金属，曾经是全球范围内的硬通货，导电性最好";

        }

        private void Cd_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Cd";
            T1.Text = "48";
            Xiangduiyuanzizhiliang.Text = "112.411";
            Zhouqi.Text = "5";
            Zu.Text = "IIB";
            YANSE.Text = "银色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "8.69";
            RONGDIAN.Text = "594.22";
            FEIDIAN.Text = "1040.15";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "151";
            DIANFUXING.Text = "1.69";
            DIANLINENG.Text = "8.9938";
            YUANZITIJI.Text = "13.1";
            DIANZIPAIBU.Text = "2,8,18,18,2";
            CHZN.Text = "镉";
            EN.Text = "Cadmium";
            T.Text = "重金属，过量摄入会导致痛痛病";

        }

        private void In_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "In";
            T1.Text = "49";
            Xiangduiyuanzizhiliang.Text = "114.818";
            Zhouqi.Text = "5";
            Zu.Text = "IIIA";
            YANSE.Text = "银色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "7.31";
            RONGDIAN.Text = "429.75";
            FEIDIAN.Text = "2345.15";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "167";
            DIANFUXING.Text = "1.78";
            DIANLINENG.Text = "5.7864";
            YUANZITIJI.Text = "15.7";
            DIANZIPAIBU.Text = "2,8,18,18,3";
            CHZN.Text = "铟";
            EN.Text = "Indium";
            T.Text = "可塑性强，有延展性，115In是主要核素，有放射性";

        }

        private void Sn_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Sn";
            T1.Text = "50";
            Xiangduiyuanzizhiliang.Text = "118.71";
            Zhouqi.Text = "5";
            Zu.Text = "IVA";
            YANSE.Text = "银色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "7.287";
            RONGDIAN.Text = "505.08";
            FEIDIAN.Text = "2875.15";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "140";
            DIANFUXING.Text = "1.96";
            DIANLINENG.Text = "7.3439";
            YUANZITIJI.Text = "16.3";
            DIANZIPAIBU.Text = "2,8,18,18,4";
            CHZN.Text = "锡";
            EN.Text = "Tin";
            T.Text = "人类最早发现应用的元素之一，被用于制造容器";

        }

        private void Sb_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Sb";
            T1.Text = "51";
            Xiangduiyuanzizhiliang.Text = "121.76";
            Zhouqi.Text = "5";
            Zu.Text = "VA";
            YANSE.Text = "银色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "6.685";
            RONGDIAN.Text = "903.78";
            FEIDIAN.Text = "1860.15";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "140";
            DIANFUXING.Text = "2.05";
            DIANLINENG.Text = "8.6084";
            YUANZITIJI.Text = "18.22";
            DIANZIPAIBU.Text = "2,8,18,18,5";
            CHZN.Text = "锑";
            EN.Text = "Antimony";
            T.Text = "熔点低，被用于制作保险丝";

        }

        private void Te_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Te";
            T1.Text = "52";
            Xiangduiyuanzizhiliang.Text = "127.6";
            Zhouqi.Text = "5";
            Zu.Text = "VIA";
            YANSE.Text = "银色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "6.232";
            RONGDIAN.Text = "722.66";
            FEIDIAN.Text = "1261.15";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "140";
            DIANFUXING.Text = "2.10";
            DIANLINENG.Text = "9.0096";
            YUANZITIJI.Text = "20.5";
            DIANZIPAIBU.Text = "2,8,18,18,6";
            CHZN.Text = "碲";
            EN.Text = "Tellurium";
            T.Text = "密度最大的非金属";

        }

        private void I_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "I";
            T1.Text = "53";
            Xiangduiyuanzizhiliang.Text = "126.904";
            Zhouqi.Text = "5";
            Zu.Text = "VIIA";
            YANSE.Text = "灰色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "4.93";
            RONGDIAN.Text = "386.85";
            FEIDIAN.Text = "457.40";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "140";
            DIANFUXING.Text = "2.66";
            DIANLINENG.Text = "10.4513";
            YUANZITIJI.Text = "25.74";
            DIANZIPAIBU.Text = "2,8,18,18,7";
            CHZN.Text = "碘";
            EN.Text = "Iodine";
            T.Text = "活泼，甲状腺所需的微量元素";

        }

        private void Xe_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Xe";
            T1.Text = "54";
            Xiangduiyuanzizhiliang.Text = "131.293";
            Zhouqi.Text = "5";
            Zu.Text = "0";
            YANSE.Text = "无色";
            ZHUANGTAI.Text = "气态";
            MIDU.Text = "0.005887";
            RONGDIAN.Text = "161.45";
            FEIDIAN.Text = "165.03";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "1008";
            DIANFUXING.Text = "2.60";
            DIANLINENG.Text = "12.1298";
            YUANZITIJI.Text = "37.3";
            DIANZIPAIBU.Text = "2,8,18,18,8";
            CHZN.Text = "氙";
            EN.Text = "Xenon";
            T.Text = "稀有气体之一";

        }

        private void Cs_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Cs";
            T1.Text = "55";
            Xiangduiyuanzizhiliang.Text = "132.905";
            Zhouqi.Text = "6";
            Zu.Text = "IA";
            YANSE.Text = "银色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "1.873";
            RONGDIAN.Text = "301.59";
            FEIDIAN.Text = "944.15";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "265";
            DIANFUXING.Text = "0.79";
            DIANLINENG.Text = "3.8939";
            YUANZITIJI.Text = "71.07";
            DIANZIPAIBU.Text = "2,8,18,18,8,1";
            CHZN.Text = "铯";
            EN.Text = "Cesium";
            T.Text = "活泼";

        }

        private void Ba_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Ba";
            T1.Text = "56";
            Xiangduiyuanzizhiliang.Text = "137.327";
            Zhouqi.Text = "6";
            Zu.Text = "IIA";
            YANSE.Text = "银色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "3.594";
            RONGDIAN.Text = "1000.15";
            FEIDIAN.Text = "2170.15";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "222";
            DIANFUXING.Text = "0.89";
            DIANLINENG.Text = "5.2117";
            YUANZITIJI.Text = "39.24";
            DIANZIPAIBU.Text = "2,8,18,18,8,2";
            CHZN.Text = "钡";
            EN.Text = "Barium";
            T.Text = "硫酸钡被应用于钡餐透视（检查是否胃穿孔）";

        }

        private void Hf_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Hf";
            T1.Text = "72";
            Xiangduiyuanzizhiliang.Text = "178.49";
            Zhouqi.Text = "6";
            Zu.Text = "IVB";
            YANSE.Text = "灰色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "13.31";
            RONGDIAN.Text = "2506.15";
            FEIDIAN.Text = "4876.15";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "159";
            DIANFUXING.Text = "1.3";
            DIANLINENG.Text = "6.8251";
            YUANZITIJI.Text = "13.6";
            DIANZIPAIBU.Text = "2,8,18,32,10,2";
            CHZN.Text = "铪";
            EN.Text = "Hafnium";
            T.Text = "银白色，熔点高。可用来制耐高温合金，也用于核工业等";

        }

        private void Ta_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Ta";
            T1.Text = "73";
            Xiangduiyuanzizhiliang.Text = "180.9479";
            Zhouqi.Text = "6";
            Zu.Text = "VB";
            YANSE.Text = "灰色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "16.654";
            RONGDIAN.Text = "3290.15";
            FEIDIAN.Text = "5731.15";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "146";
            DIANFUXING.Text = "1.50";
            DIANLINENG.Text = "7.5496";
            YUANZITIJI.Text = "10.9";
            DIANZIPAIBU.Text = "2,8,18,32,11,2";
            CHZN.Text = "钽";
            EN.Text = "Tantalum";
            T.Text = "钢灰色，耐腐蚀质硬，熔点高。可用于航天工业及核工业";

        }

        private void W_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "W";
            T1.Text = "74";
            Xiangduiyuanzizhiliang.Text = "183.84";
            Zhouqi.Text = "6";
            Zu.Text = "VIB";
            YANSE.Text = "灰色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "19.25";
            RONGDIAN.Text = "3695.15";
            FEIDIAN.Text = "5828.15";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "139";
            DIANFUXING.Text = "2.36";
            DIANLINENG.Text = "7.864";
            YUANZITIJI.Text = "9。53";
            DIANZIPAIBU.Text = "2,8,18,32,12,2";
            CHZN.Text = "钨";
            EN.Text = "Tungsten";
            T.Text = "稳定元素中熔点最高";

        }

        private void Re_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Ba";
            T1.Text = "75";
            Xiangduiyuanzizhiliang.Text = "186.207";
            Zhouqi.Text = "6";
            Zu.Text = "VIIB";
            YANSE.Text = "灰色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "21.02";
            RONGDIAN.Text = "3459.15";
            FEIDIAN.Text = "5869.15";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "137";
            DIANFUXING.Text = "1.9";
            DIANLINENG.Text = "7.8335";
            YUANZITIJI.Text = "8.85";
            DIANZIPAIBU.Text = "2,8,18,32,13,2";
            CHZN.Text = "铼";
            EN.Text = "Rhenium";
            T.Text = "最晚被发现的稳定元素";

        }

        private void Os_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Os";
            T1.Text = "76";
            Xiangduiyuanzizhiliang.Text = "190.23";
            Zhouqi.Text = "6";
            Zu.Text = "VIII";
            YANSE.Text = "灰色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "22.61";
            RONGDIAN.Text = "3306.15";
            FEIDIAN.Text = "5285.15";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "135";
            DIANFUXING.Text = "2.20";
            DIANLINENG.Text = "8.4382";
            YUANZITIJI.Text = "8.49";
            DIANZIPAIBU.Text = "2,8,18,32,14,2";
            CHZN.Text = "锇";
            EN.Text = "Osmium";
            T.Text = "密度最大的金属";

        }

        private void Ir_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Ir";
            T1.Text = "77";
            Xiangduiyuanzizhiliang.Text = "192.217";
            Zhouqi.Text = "6";
            Zu.Text = "VIII";
            YANSE.Text = "银色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "22.56";
            RONGDIAN.Text = "2739";
            FEIDIAN.Text = "4701.15";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "136";
            DIANFUXING.Text = "2.20";
            DIANLINENG.Text = "8.967";
            YUANZITIJI.Text = "8.54";
            DIANZIPAIBU.Text = "2,8,18,32,15,2";
            CHZN.Text = "铱";
            EN.Text = "Iridium";
            T.Text = "　熔点高，质硬而脆。可用来制科学仪器等";

        }

        private void Pt_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Pt";
            T1.Text = "78";
            Xiangduiyuanzizhiliang.Text = "195.084";
            Zhouqi.Text = "6";
            Zu.Text = "VIII";
            YANSE.Text = "灰色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "21.45";
            RONGDIAN.Text = "2041.45";
            FEIDIAN.Text = "4098.15";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "139";
            DIANFUXING.Text = "2.28";
            DIANLINENG.Text = "8.9587";
            YUANZITIJI.Text = "9.10";
            DIANZIPAIBU.Text = "2,8,18,32,17,1";
            CHZN.Text = "铂";
            EN.Text = "Platinum";
            T.Text = "被应用于珠宝首饰中的贵金属，俗称铂金";

        }

        private void Au_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Au";
            T1.Text = "79";
            Xiangduiyuanzizhiliang.Text = "196.967";
            Zhouqi.Text = "6";
            Zu.Text = "IB";
            YANSE.Text = "金色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "19.282";
            RONGDIAN.Text = "1337.15";
            FEIDIAN.Text = "3129.15";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "144";
            DIANFUXING.Text = "2.54";
            DIANLINENG.Text = "9.2255";
            YUANZITIJI.Text = "10.2";
            DIANZIPAIBU.Text = "2,8,18,32,18,1";
            CHZN.Text = "金";
            EN.Text = "Gold";
            T.Text = "化学性质极稳定，人类最早发现及应用的贵金属，全球硬通货";

        }

        private void Hg_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Hg";
            T1.Text = "80";
            Xiangduiyuanzizhiliang.Text = "200.59";
            Zhouqi.Text = "6";
            Zu.Text = "IIB";
            YANSE.Text = "银色";
            ZHUANGTAI.Text = "液态";
            MIDU.Text = "13.5336";
            RONGDIAN.Text = "234.32";
            FEIDIAN.Text = "630.15";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "151";
            DIANFUXING.Text = "2.00";
            DIANLINENG.Text = "10.4375";
            YUANZITIJI.Text = "14.82";
            DIANZIPAIBU.Text = "2,8,18,32,18,2";
            CHZN.Text = "汞";
            EN.Text = "Mercury";
            T.Text = "惟一一种在常温下为液态的金属";

        }

        private void Tl_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Tl";
            T1.Text = "81";
            Xiangduiyuanzizhiliang.Text = "204.3833";
            Zhouqi.Text = "6";
            Zu.Text = "IIIA";
            YANSE.Text = "银色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "11.85";
            RONGDIAN.Text = "577.15";
            FEIDIAN.Text = "1746.15";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "170";
            DIANFUXING.Text = "1.62";
            DIANLINENG.Text = "6.1082";
            YUANZITIJI.Text = "17.20";
            DIANZIPAIBU.Text = "2,8,18,32,18,3";
            CHZN.Text = "铊";
            EN.Text = "Thallium";
            T.Text = "银白色，质软。可用来制合金等。铊的化合物有毒";

        }

        private void Pb_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Pb";
            T1.Text = "82";
            Xiangduiyuanzizhiliang.Text = "207.2";
            Zhouqi.Text = "6";
            Zu.Text = "IVA";
            YANSE.Text = "灰色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "11.342";
            RONGDIAN.Text = "600.61";
            FEIDIAN.Text = "2022.15";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "175";
            DIANFUXING.Text = "2.33";
            DIANLINENG.Text = "7.4167";
            YUANZITIJI.Text = "18.17";
            DIANZIPAIBU.Text = "2,8,18,32,18,4";
            CHZN.Text = "铅";
            EN.Text = "Lead";
            T.Text = "密度大，熔点低，对人体有毒性。许多化妆品中必须含有的元素";

        }

        private void Bi_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Bi";
            T1.Text = "83";
            Xiangduiyuanzizhiliang.Text = "208.9804";
            Zhouqi.Text = "6";
            Zu.Text = "VA";
            YANSE.Text = "灰色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "9.78";
            RONGDIAN.Text = "544.65";
            FEIDIAN.Text = "1837.15";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "156";
            DIANFUXING.Text = "2.02";
            DIANLINENG.Text = "7.2856";
            YUANZITIJI.Text = "21.30";
            DIANZIPAIBU.Text = "2,8,18,32,18,5";
            CHZN.Text = "铋";
            EN.Text = "Bismuth";
            T.Text = "合金熔点很低，可用来做保险丝和汽锅上的安全塞等";

        }

        private void Po_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Po";
            T1.Text = "84";
            Xiangduiyuanzizhiliang.Text = "[210]";
            Zhouqi.Text = "6";
            Zu.Text = "VIA";
            YANSE.Text = "银色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "9.196";
            RONGDIAN.Text = "527.15";
            FEIDIAN.Text = "1235.15";
            FANGSHEXING.Text = "存在";
            YUANZIBANJING.Text = "168";
            DIANFUXING.Text = "2.00";
            DIANLINENG.Text = "8.417";
            YUANZITIJI.Text = "22.23";
            DIANZIPAIBU.Text = "2,8,18,32,18,6";
            CHZN.Text = "钋";
            EN.Text = "Polonium";
            T.Text = "放射";

        }

        private void At_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "At";
            T1.Text = "85";
            Xiangduiyuanzizhiliang.Text = "[210]";
            Zhouqi.Text = "6";
            Zu.Text = "VIIA";
            YANSE.Text = "银色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "7.00";
            RONGDIAN.Text = "575.15";
            FEIDIAN.Text = "610.15";
            FANGSHEXING.Text = "存在";
            YUANZIBANJING.Text = "-";
            DIANFUXING.Text = "2.20";
            DIANLINENG.Text = "9.30";
            YUANZITIJI.Text = "30.00";
            DIANZIPAIBU.Text = "2,8,18,32,18,7";
            CHZN.Text = "砹";
            EN.Text = "Astatine";
            T.Text = "放射、活泼";

        }

        private void Rn_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Rn";
            T1.Text = "86";
            Xiangduiyuanzizhiliang.Text = "[222]";
            Zhouqi.Text = "6";
            Zu.Text = "0";
            YANSE.Text = "无色";
            ZHUANGTAI.Text = "气态";
            MIDU.Text = "0.00973";
            RONGDIAN.Text = "202.00";
            FEIDIAN.Text = "211.30";
            FANGSHEXING.Text = "存在";
            YUANZIBANJING.Text = "120";
            DIANFUXING.Text = "-";
            DIANLINENG.Text = "10.7485";
            YUANZITIJI.Text = "50.50";
            DIANZIPAIBU.Text = "2,8,18,32,18,8";
            CHZN.Text = "氡";
            EN.Text = "Radon";
            T.Text = "放射";

        }

        private void Fr_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Fr";
            T1.Text = "87";
            Xiangduiyuanzizhiliang.Text = "[223]";
            Zhouqi.Text = "7";
            Zu.Text = "IA";
            YANSE.Text = "银色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "1.87";
            RONGDIAN.Text = "296.15";
            FEIDIAN.Text = "950.15";
            FANGSHEXING.Text = "存在";
            YUANZIBANJING.Text = "260";
            DIANFUXING.Text = "0.70";
            DIANLINENG.Text = "4.0727";
            YUANZITIJI.Text = "71.07";
            DIANZIPAIBU.Text = "2,8,18,32,18,8,1";
            CHZN.Text = "钫";
            EN.Text = "Francium";
            T.Text = "放射（注：放射性虽短但仍然存在）";

        }

        private void Ra_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Ra";
            T1.Text = "88";
            Xiangduiyuanzizhiliang.Text = "[226]";
            Zhouqi.Text = "7";
            Zu.Text = "IIA";
            YANSE.Text = "银色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "5.50";
            RONGDIAN.Text = "973.15";
            FEIDIAN.Text = "2010.15";
            FANGSHEXING.Text = "存在";
            YUANZIBANJING.Text = "-";
            DIANFUXING.Text = "0.90";
            DIANLINENG.Text = "5.2784";
            YUANZITIJI.Text = "45.2";
            DIANZIPAIBU.Text = "2,8,18,32,18,8,2";
            CHZN.Text = "镭";
            EN.Text = "Radium";
            T.Text = "放射";

        }

        private void Rf_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Rf";
            T1.Text = "104";
            Xiangduiyuanzizhiliang.Text = "[267]";
            Zhouqi.Text = "7";
            Zu.Text = "IVB";
            YANSE.Text = "-";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "23";
            RONGDIAN.Text = "2373.15";
            FEIDIAN.Text = "5773.15";
            FANGSHEXING.Text = "存在";
            YUANZIBANJING.Text = "-";
            DIANFUXING.Text = "-";
            DIANLINENG.Text = "6.011";
            YUANZITIJI.Text = "-";
            DIANZIPAIBU.Text = "2,8,18,32,32,10,2";
            CHZN.Text = "鑪(lú)";
            EN.Text = "Rutherfordium";
            T.Text = "人造 放射";

        }

        private void Db_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Db";
            T1.Text = "105";
            Xiangduiyuanzizhiliang.Text = "[268]";
            Zhouqi.Text = "7";
            Zu.Text = "VB";
            YANSE.Text = "-";
            ZHUANGTAI.Text = "-";
            MIDU.Text = "39";
            RONGDIAN.Text = "-";
            FEIDIAN.Text = "-";
            FANGSHEXING.Text = "存在";
            YUANZIBANJING.Text = "-";
            DIANFUXING.Text = "-";
            DIANLINENG.Text = "-";
            YUANZITIJI.Text = "-";
            DIANZIPAIBU.Text = "2,8,18,32,32,11,2";
            CHZN.Text = "钅杜(dù)";
            EN.Text = "Dubnium";
            T.Text = "人造 放射";

        }

        private void Sg_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Sg";
            T1.Text = "106";
            Xiangduiyuanzizhiliang.Text = "[269]";
            Zhouqi.Text = "7";
            Zu.Text = "VIB";
            YANSE.Text = "-";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "35";
            RONGDIAN.Text = "-";
            FEIDIAN.Text = "-";
            FANGSHEXING.Text = "存在";
            YUANZIBANJING.Text = "-";
            DIANFUXING.Text = "-";
            DIANLINENG.Text = "-";
            YUANZITIJI.Text = "-";
            DIANZIPAIBU.Text = "2,8,18,32,32,12,2";
            CHZN.Text = "钅喜(xǐ)";
            EN.Text = "Seaborgium";
            T.Text = "人造 放射";

        }

        private void Bh_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Bh";
            T1.Text = "107";
            Xiangduiyuanzizhiliang.Text = "[270]";
            Zhouqi.Text = "7";
            Zu.Text = "VIIB";
            YANSE.Text = "-";
            ZHUANGTAI.Text = "-";
            MIDU.Text = "37";
            RONGDIAN.Text = "-";
            FEIDIAN.Text = "-";
            FANGSHEXING.Text = "存在";
            YUANZIBANJING.Text = "-";
            DIANFUXING.Text = "-";
            DIANLINENG.Text = "-";
            YUANZITIJI.Text = "-";
            DIANZIPAIBU.Text = "2,8,18,32,32,13,2";
            CHZN.Text = "钅波(bō)";
            EN.Text = "Bohrium";
            T.Text = "人造 放射";

        }

        private void Hs_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Hs";
            T1.Text = "108";
            Xiangduiyuanzizhiliang.Text = "[269]";
            Zhouqi.Text = "7";
            Zu.Text = "VIII";
            YANSE.Text = "-";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "41";
            RONGDIAN.Text = "-";
            FEIDIAN.Text = "-";
            FANGSHEXING.Text = "存在";
            YUANZIBANJING.Text = "-";
            DIANFUXING.Text = "-";
            DIANLINENG.Text = "-";
            YUANZITIJI.Text = "-";
            DIANZIPAIBU.Text = "2,8,18,32,32,14,2";
            CHZN.Text = "𬭶";
            EN.Text = "Hassium";
            T.Text = "人造 放射";

        }

        private void Mt_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Mt";
            T1.Text = "109";
            Xiangduiyuanzizhiliang.Text = "[278]";
            Zhouqi.Text = "7";
            Zu.Text = "VIII";
            YANSE.Text = "-";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "35";
            RONGDIAN.Text = "-";
            FEIDIAN.Text = "-";
            FANGSHEXING.Text = "存在";
            YUANZIBANJING.Text = "-";
            DIANFUXING.Text = "-";
            DIANLINENG.Text = "-";
            YUANZITIJI.Text = "-";
            DIANZIPAIBU.Text = "2,8,18,32,32,15,2";
            CHZN.Text = "鿏";
            EN.Text = "Meitnerium";
            T.Text = "人造 放射";

        }

        private void Ds_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Ds";
            T1.Text = "110";
            Xiangduiyuanzizhiliang.Text = "[281]";
            Zhouqi.Text = "7";
            Zu.Text = "VIII";
            YANSE.Text = "-";
            ZHUANGTAI.Text = "-";
            MIDU.Text = "35";
            RONGDIAN.Text = "-";
            FEIDIAN.Text = "-";
            FANGSHEXING.Text = "存在";
            YUANZIBANJING.Text = "-";
            DIANFUXING.Text = "-";
            DIANLINENG.Text = "-";
            YUANZITIJI.Text = "-";
            DIANZIPAIBU.Text = "2,8,18,32,32,16,2";
            CHZN.Text = "鐽";
            EN.Text = "Darmstadtium";
            T.Text = "人造 放射";

        }

        private void Rg_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Rg";
            T1.Text = "111";
            Xiangduiyuanzizhiliang.Text = "[281]";
            Zhouqi.Text = "7";
            Zu.Text = "IB";
            YANSE.Text = "-";
            ZHUANGTAI.Text = "-";
            MIDU.Text = "-";
            RONGDIAN.Text = "-";
            FEIDIAN.Text = "-";
            FANGSHEXING.Text = "存在";
            YUANZIBANJING.Text = "-";
            DIANFUXING.Text = "-";
            DIANLINENG.Text = "-";
            YUANZITIJI.Text = "-";
            DIANZIPAIBU.Text = "2,8,18,32,32,17,2";
            CHZN.Text = "錀";
            EN.Text = "Roentgenium";
            T.Text = "超重元素";

        }

        private void Cn_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Cn";
            T1.Text = "112";
            Xiangduiyuanzizhiliang.Text = "[285]";
            Zhouqi.Text = "7";
            Zu.Text = "IIB";
            YANSE.Text = "-";
            ZHUANGTAI.Text = "-";
            MIDU.Text = "-";
            RONGDIAN.Text = "-";
            FEIDIAN.Text = "-";
            FANGSHEXING.Text = "存在";
            YUANZIBANJING.Text = "-";
            DIANFUXING.Text = "-";
            DIANLINENG.Text = "-";
            YUANZITIJI.Text = "-";
            DIANZIPAIBU.Text = "2,8,18,32,32,18,2";
            CHZN.Text = "鎶";
            EN.Text = "Copernicium";
            T.Text = "超重元素";

        }

        private void Uut_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Nh";
            T1.Text = "113";
            Xiangduiyuanzizhiliang.Text = "[286]";
            Zhouqi.Text = "7";
            Zu.Text = "IIIA";
            YANSE.Text = "-";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "16";
            RONGDIAN.Text = "703.15";
            FEIDIAN.Text = "1373.15";
            FANGSHEXING.Text = "存在";
            YUANZIBANJING.Text = "-";
            DIANFUXING.Text = "-";
            DIANLINENG.Text = "-";
            YUANZITIJI.Text = "-";
            DIANZIPAIBU.Text = "2,8,18,32,32,18,3";
            CHZN.Text = "鉨";
            EN.Text = "Nihonium";
            T.Text = "不稳定的超重元素";

        }

        private void Fl_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Fl";
            T1.Text = "114";
            Xiangduiyuanzizhiliang.Text = "[289]";
            Zhouqi.Text = "7";
            Zu.Text = "IVA";
            YANSE.Text = "-";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "14";
            RONGDIAN.Text = "343.15";
            FEIDIAN.Text = "423.15";
            FANGSHEXING.Text = "存在";
            YUANZIBANJING.Text = "-";
            DIANFUXING.Text = "-";
            DIANLINENG.Text = "-";
            YUANZITIJI.Text = "-";
            DIANZIPAIBU.Text = "2,8,18,32,32,18,4";
            CHZN.Text = "𫓧";
            EN.Text = "Flerovium";
            T.Text = "第一种表现出惰性气体特征的超重元素";

        }

        private void Uup_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Mc";
            T1.Text = "115";
            Xiangduiyuanzizhiliang.Text = "[288]";
            Zhouqi.Text = "7";
            Zu.Text = "VA";
            YANSE.Text = "-";
            ZHUANGTAI.Text = "-";
            MIDU.Text = "-";
            RONGDIAN.Text = "-";
            FEIDIAN.Text = "-";
            FANGSHEXING.Text = "存在";
            YUANZIBANJING.Text = "-";
            DIANFUXING.Text = "-";
            DIANLINENG.Text = "-";
            YUANZITIJI.Text = "-";
            DIANZIPAIBU.Text = "2,8,18,32,32,18,5";
            CHZN.Text = "镆";
            EN.Text = "Moscovium";
            T.Text = "人工合成的放射性金属元素";

        }

        private void Lv_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Lv";
            T1.Text = "116";
            Xiangduiyuanzizhiliang.Text = "[293]";
            Zhouqi.Text = "7";
            Zu.Text = "VIA";
            YANSE.Text = "-";
            ZHUANGTAI.Text = "-";
            MIDU.Text = "-";
            RONGDIAN.Text = "-";
            FEIDIAN.Text = "-";
            FANGSHEXING.Text = "存在";
            YUANZIBANJING.Text = "-";
            DIANFUXING.Text = "-";
            DIANLINENG.Text = "-";
            YUANZITIJI.Text = "-";
            DIANZIPAIBU.Text = "2,8,18,32,32,18,6";
            CHZN.Text = "𫟷";
            EN.Text = "Livermorium";
            T.Text = "人工合成的放射性化学元素";

        }

        private void Uus_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Ts";
            T1.Text = "117";
            Xiangduiyuanzizhiliang.Text = "[294]";
            Zhouqi.Text = "7";
            Zu.Text = "VIIA";
            YANSE.Text = "-";
            ZHUANGTAI.Text = "-";
            MIDU.Text = "-";
            RONGDIAN.Text = "-";
            FEIDIAN.Text = "-";
            FANGSHEXING.Text = "存在";
            YUANZIBANJING.Text = "-";
            DIANFUXING.Text = "-";
            DIANLINENG.Text = "-";
            YUANZITIJI.Text = "-";
            DIANZIPAIBU.Text = "2,8,18,32,32,18,7";
            CHZN.Text = "石田(tián)";
            EN.Text = "Tennessine";
            T.Text = "卤族元素,人造 放射";

        }

        private void Uuo_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Og";
            T1.Text = "118";
            Xiangduiyuanzizhiliang.Text = "[294]";
            Zhouqi.Text = "7";
            Zu.Text = "VIB";
            YANSE.Text = "-";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "13.65";
            RONGDIAN.Text = "-";
            FEIDIAN.Text = "-";
            FANGSHEXING.Text = "存在";
            YUANZIBANJING.Text = "152";
            DIANFUXING.Text = "-";
            DIANLINENG.Text = "-";
            YUANZITIJI.Text = "-";
            DIANZIPAIBU.Text = "2,8,18,32,32,18,8";
            CHZN.Text = "气奥(ào)";
            EN.Text = "Oganesson";
            T.Text = "人工合成的稀有气体元素";

        }

        /// 

        private void La_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "La";
            T1.Text = "57";
            Xiangduiyuanzizhiliang.Text = "138.905";
            Zhouqi.Text = "6";
            Zu.Text = "-";
            YANSE.Text = "银色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "6.145";
            RONGDIAN.Text = "1193.15";
            FEIDIAN.Text = "3737.15";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "187";
            DIANFUXING.Text = "1.10";
            DIANLINENG.Text = "5.5769";
            YUANZITIJI.Text = "22.50";
            DIANZIPAIBU.Text = "2,8,18,18,9,2";
            CHZN.Text = "镧";
            EN.Text = "Lanthanum";
            T.Text = "第一个镧系元素";
        }

        private void Ce_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Ce";
            T1.Text = "58";
            Xiangduiyuanzizhiliang.Text = "140.116";
            Zhouqi.Text = "6";
            Zu.Text = "-";
            YANSE.Text = "银色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "6.77";
            RONGDIAN.Text = "1068.15";
            FEIDIAN.Text = "3716.15";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "182";
            DIANFUXING.Text = "1.12";
            DIANLINENG.Text = "5.5387";
            YUANZITIJI.Text = "20.67";
            DIANZIPAIBU.Text = "2,8,18,19,9,2";
            CHZN.Text = "铈";
            EN.Text = "Cerium";
            T.Text = "用来制造打火石";
        }

        private void Pr_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Pr";
            T1.Text = "59";
            Xiangduiyuanzizhiliang.Text = "140.908";
            Zhouqi.Text = "6";
            Zu.Text = "-";
            YANSE.Text = "银色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "6.773";
            RONGDIAN.Text = "1208.15";
            FEIDIAN.Text = "3793.15";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "182";
            DIANFUXING.Text = "1.13";
            DIANLINENG.Text = "5.473";
            YUANZITIJI.Text = "20.8";
            DIANZIPAIBU.Text = "2,8,18,21,8,2";
            CHZN.Text = "镨";
            EN.Text = "Praseodymium";
            T.Text = "英文名称最长";
        }

        private void Nd_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Nd";
            T1.Text = "60";
            Xiangduiyuanzizhiliang.Text = "144.242";
            Zhouqi.Text = "6";
            Zu.Text = "-";
            YANSE.Text = "银色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "7.007";
            RONGDIAN.Text = "1297.15";
            FEIDIAN.Text = "3347.15";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "181";
            DIANFUXING.Text = "1.14";
            DIANLINENG.Text = "5.525";
            YUANZITIJI.Text = "20.60";
            DIANZIPAIBU.Text = "2,8,18,22,8,2";
            CHZN.Text = "钕";
            EN.Text = "Neodymium";
            T.Text = "磁性强";
        }

        private void Pm_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Pm";
            T1.Text = "61";
            Xiangduiyuanzizhiliang.Text = "[145]";
            Zhouqi.Text = "6";
            Zu.Text = "-";
            YANSE.Text = "银色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "7.26";
            RONGDIAN.Text = "1315.15";
            FEIDIAN.Text = "3273.15";
            FANGSHEXING.Text = "存在";
            YUANZIBANJING.Text = "183";
            DIANFUXING.Text = "-";
            DIANLINENG.Text = "5.582";
            YUANZITIJI.Text = "22.39";
            DIANZIPAIBU.Text = "2,8,18,23,8,2";
            CHZN.Text = "钷";
            EN.Text = "Promethium";
            T.Text = "有放射性";
        }

        private void Sm_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Sm";
            T1.Text = "62";
            Xiangduiyuanzizhiliang.Text = "150.36";
            Zhouqi.Text = "6";
            Zu.Text = "-";
            YANSE.Text = "银色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "7.52";
            RONGDIAN.Text = "1345.15";
            FEIDIAN.Text = "2067.15";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "180";
            DIANFUXING.Text = "1.17";
            DIANLINENG.Text = "5.6437";
            YUANZITIJI.Text = "20.00";
            DIANZIPAIBU.Text = "2,8,18,24,8,2";
            CHZN.Text = "钐";
            EN.Text = "Samarium";
            T.Text = "磁性强";
        }

        private void Eu_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Eu";
            T1.Text = "63";
            Xiangduiyuanzizhiliang.Text = "151.964";
            Zhouqi.Text = "6";
            Zu.Text = "-";
            YANSE.Text = "银色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "5.243";
            RONGDIAN.Text = "1099.15";
            FEIDIAN.Text = "1802.15";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "180";
            DIANFUXING.Text = "1.20";
            DIANLINENG.Text = "5.6704";
            YUANZITIJI.Text = "20.80";
            DIANZIPAIBU.Text = "2,8,18,25,8,2";
            CHZN.Text = "铕";
            EN.Text = "Europium";
            T.Text = "活泼，能放出红光";
        }

        private void Gd_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Gd";
            T1.Text = "64";
            Xiangduiyuanzizhiliang.Text = "157.25";
            Zhouqi.Text = "6";
            Zu.Text = "-";
            YANSE.Text = "银色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "7.895";
            RONGDIAN.Text = "1585.15";
            FEIDIAN.Text = "3546.15";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "180";
            DIANFUXING.Text = "1.20";
            DIANLINENG.Text = "6.1501";
            YUANZITIJI.Text = "19.90";
            DIANZIPAIBU.Text = "2,8,18,25,9,2";
            CHZN.Text = "钆";
            EN.Text = "Gadolinium";
            T.Text = "未配对电子达到上限";
        }

        private void Tb_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Tb";
            T1.Text = "65";
            Xiangduiyuanzizhiliang.Text = "158.925";
            Zhouqi.Text = "6";
            Zu.Text = "-";
            YANSE.Text = "银色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "8.229";
            RONGDIAN.Text = "1629.15";
            FEIDIAN.Text = "3503.15";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "177";
            DIANFUXING.Text = "1.20";
            DIANLINENG.Text = "5.8638";
            YUANZITIJI.Text = "19.20";
            DIANZIPAIBU.Text = "2,8,18,27,8,2";
            CHZN.Text = "铽";
            EN.Text = "Terbium";
            T.Text = "通电时改变形状";
        }

        private void Dy_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Dy";
            T1.Text = "66";
            Xiangduiyuanzizhiliang.Text = "162.50";
            Zhouqi.Text = "6";
            Zu.Text = "-";
            YANSE.Text = "银色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "8.55";
            RONGDIAN.Text = "1680.15";
            FEIDIAN.Text = "2840.15";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "178";
            DIANFUXING.Text = "1.22";
            DIANLINENG.Text = "5.9389";
            YUANZITIJI.Text = "19.00";
            DIANZIPAIBU.Text = "2,8,18,28,8,2";
            CHZN.Text = "镝";
            EN.Text = "Dysprosium";
            T.Text = "英文名称源自“很难得到”";
        }

        private void Ho_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Ho";
            T1.Text = "67";
            Xiangduiyuanzizhiliang.Text = "164.930";
            Zhouqi.Text = "6";
            Zu.Text = "-";
            YANSE.Text = "银色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "8.795";
            RONGDIAN.Text = "1734.15";
            FEIDIAN.Text = "2993.15";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "176";
            DIANFUXING.Text = "1.23";
            DIANLINENG.Text = "6.0215";
            YUANZITIJI.Text = "18.70";
            DIANZIPAIBU.Text = "2,8,18,29,8,2";
            CHZN.Text = "钬";
            EN.Text = "Holmium";
            T.Text = "银白色，质软，可用来制磁性材料";
        }

        private void Er_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Er";
            T1.Text = "68";
            Xiangduiyuanzizhiliang.Text = "167.259";
            Zhouqi.Text = "6";
            Zu.Text = "-";
            YANSE.Text = "银色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "9.066";
            RONGDIAN.Text = "1802.15";
            FEIDIAN.Text = "3141.15";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "176";
            DIANFUXING.Text = "1.24";
            DIANLINENG.Text = "6.1077";
            YUANZITIJI.Text = "18.40";
            DIANZIPAIBU.Text = "2,8,18,30,8,2";
            CHZN.Text = "铒";
            EN.Text = "Erbium";
            T.Text = "银灰色，质软，可用来制特种合金，激光器等";
        }

        private void Tm_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Tm";
            T1.Text = "69";
            Xiangduiyuanzizhiliang.Text = "168.934";
            Zhouqi.Text = "6";
            Zu.Text = "-";
            YANSE.Text = "银色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "9.321";
            RONGDIAN.Text = "1818.15";
            FEIDIAN.Text = "2223.15";
            FANGSHEXING.Text = "存在";
            YUANZIBANJING.Text = "176";
            DIANFUXING.Text = "1.25";
            DIANLINENG.Text = "6.1843";
            YUANZITIJI.Text = "18.10";
            DIANZIPAIBU.Text = "2,8,18,31,8,2";
            CHZN.Text = "铥";
            EN.Text = "Thulium";
            T.Text = "银白色，质软，可用来制X射线源等";
        }

        private void Yb_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Yb";
            T1.Text = "70";
            Xiangduiyuanzizhiliang.Text = "173.054";
            Zhouqi.Text = "6";
            Zu.Text = "-";
            YANSE.Text = "银色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "6.965";
            RONGDIAN.Text = "1097.15";
            FEIDIAN.Text = "1469.15";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "176";
            DIANFUXING.Text = "1.10";
            DIANLINENG.Text = "6.2542";
            YUANZITIJI.Text = "24.79";
            DIANZIPAIBU.Text = "2,8,18,32,8,2";
            CHZN.Text = "镱";
            EN.Text = "Ytterbium";
            T.Text = "银白色，质软，可用来制特种合金，也用作激光材料等";
        }

        private void Lu_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Lu";
            T1.Text = "71";
            Xiangduiyuanzizhiliang.Text = "174.967";
            Zhouqi.Text = "6";
            Zu.Text = "-";
            YANSE.Text = "银色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "9.84";
            RONGDIAN.Text = "1925.15";
            FEIDIAN.Text = "3675.15";
            FANGSHEXING.Text = "-";
            YUANZIBANJING.Text = "174";
            DIANFUXING.Text = "1.27";
            DIANLINENG.Text = "5.4259";
            YUANZITIJI.Text = "17.78";
            DIANZIPAIBU.Text = "2,8,18,32,9,2";
            CHZN.Text = "镥";
            EN.Text = "Lutetium";
            T.Text = "银白色，质软，可用于核工业";
        }


        /// 


        private void Ac_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Ac";
            T1.Text = "89";
            Xiangduiyuanzizhiliang.Text = "[227]";
            Zhouqi.Text = "7";
            Zu.Text = "-";
            YANSE.Text = "银色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "10.07";
            RONGDIAN.Text = "1323.15";
            FEIDIAN.Text = "3471.15";
            FANGSHEXING.Text = "存在";
            YUANZIBANJING.Text = "-";
            DIANFUXING.Text = "1.10";
            DIANLINENG.Text = "5.17";
            YUANZITIJI.Text = "22.54";
            DIANZIPAIBU.Text = "2,8,18,32,18,9,2";
            CHZN.Text = "锕";
            EN.Text = "Actinium";
            T.Text = "放射";
        }

        private void Th_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Th";
            T1.Text = "90";
            Xiangduiyuanzizhiliang.Text = "232.038";
            Zhouqi.Text = "7";
            Zu.Text = "-";
            YANSE.Text = "银色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "11.70";
            RONGDIAN.Text = "2115.15";
            FEIDIAN.Text = "5061.15";
            FANGSHEXING.Text = "存在";
            YUANZIBANJING.Text = "179";
            DIANFUXING.Text = "1.30";
            DIANLINENG.Text = "6.3067";
            YUANZITIJI.Text = "19.90";
            DIANZIPAIBU.Text = "2,8,18,32,18,10,2";
            CHZN.Text = "钍";
            EN.Text = "Thorium";
            T.Text = "放射";
        }

        private void Pa_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Pa";
            T1.Text = "91";
            Xiangduiyuanzizhiliang.Text = "231.036";
            Zhouqi.Text = "7";
            Zu.Text = "-";
            YANSE.Text = "银色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "15.37";
            RONGDIAN.Text = "1841.15";
            FEIDIAN.Text = "4300.15";
            FANGSHEXING.Text = "存在";
            YUANZIBANJING.Text = "163";
            DIANFUXING.Text = "1.50";
            DIANLINENG.Text = "5.89";
            YUANZITIJI.Text = "15.00";
            DIANZIPAIBU.Text = "2,8,18,32,20,9,2";
            CHZN.Text = "镤";
            EN.Text = "Protactinium";
            T.Text = "放射";
        }

        private void U_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "U";
            T1.Text = "92";
            Xiangduiyuanzizhiliang.Text = "238.029";
            Zhouqi.Text = "7";
            Zu.Text = "-";
            YANSE.Text = "银色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "18.95";
            RONGDIAN.Text = "1405.35";
            FEIDIAN.Text = "4404.15";
            FANGSHEXING.Text = "存在";
            YUANZIBANJING.Text = "156";
            DIANFUXING.Text = "1.38";
            DIANLINENG.Text = "6.1941";
            YUANZITIJI.Text = "12.59";
            DIANZIPAIBU.Text = "2,8,18,32,21,9,2";
            CHZN.Text = "铀";
            EN.Text = "Uranium";
            T.Text = "放射，同位素铀235被用于制作原子弹";
        }

        private void Np_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Np";
            T1.Text = "93";
            Xiangduiyuanzizhiliang.Text = "[237]";
            Zhouqi.Text = "7";
            Zu.Text = "-";
            YANSE.Text = "银色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "20.45";
            RONGDIAN.Text = "910.15";
            FEIDIAN.Text = "4273.15";
            FANGSHEXING.Text = "存在";
            YUANZIBANJING.Text = "155";
            DIANFUXING.Text = "1.36";
            DIANLINENG.Text = "6.2657";
            YUANZITIJI.Text = "11.62";
            DIANZIPAIBU.Text = "2,8,18,32,22,9,2";
            CHZN.Text = "镎";
            EN.Text = "Neptunium";
            T.Text = "放射";
        }

        private void Pu_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Pu";
            T1.Text = "94";
            Xiangduiyuanzizhiliang.Text = "[244]";
            Zhouqi.Text = "7";
            Zu.Text = "-";
            YANSE.Text = "银色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "19.816";
            RONGDIAN.Text = "912.55";
            FEIDIAN.Text = "35.1.15";
            FANGSHEXING.Text = "存在";
            YUANZIBANJING.Text = "159";
            DIANFUXING.Text = "1.28";
            DIANLINENG.Text = "6.0262";
            YUANZITIJI.Text = "12.32";
            DIANZIPAIBU.Text = "2,8,18,32,24,8,2";
            CHZN.Text = "钚";
            EN.Text = "Plutonium";
            T.Text = "放射";
        }

        private void Am_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Am";
            T1.Text = "95";
            Xiangduiyuanzizhiliang.Text = "[243]";
            Zhouqi.Text = "7";
            Zu.Text = "-";
            YANSE.Text = "银色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "13.69";
            RONGDIAN.Text = "1449.15";
            FEIDIAN.Text = "2880.15";
            FANGSHEXING.Text = "存在";
            YUANZIBANJING.Text = "173";
            DIANFUXING.Text = "1.30";
            DIANLINENG.Text = "5.9738";
            YUANZITIJI.Text = "17.78";
            DIANZIPAIBU.Text = "2,8,18,32,25,8,2";
            CHZN.Text = "镅";
            EN.Text = "Americium";
            T.Text = "人造 放射 用于烟雾报警器中";
        }

        private void Cm_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Cm";
            T1.Text = "96";
            Xiangduiyuanzizhiliang.Text = "[247]";
            Zhouqi.Text = "7";
            Zu.Text = "-";
            YANSE.Text = "银色";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "13.51";
            RONGDIAN.Text = "1613.15";
            FEIDIAN.Text = "3383.15";
            FANGSHEXING.Text = "存在";
            YUANZIBANJING.Text = "174";
            DIANFUXING.Text = "1.30";
            DIANLINENG.Text = "5.9915";
            YUANZITIJI.Text = "18.28";
            DIANZIPAIBU.Text = "2,8,18,32,25,9,2";
            CHZN.Text = "锔";
            EN.Text = "Curium";
            T.Text = "人造 放射";
        }

        private void Bk_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Bk";
            T1.Text = "97";
            Xiangduiyuanzizhiliang.Text = "[247]";
            Zhouqi.Text = "7";
            Zu.Text = "-";
            YANSE.Text = "-";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "14.78";
            RONGDIAN.Text = "1259.15";
            FEIDIAN.Text = "3173.15";
            FANGSHEXING.Text = "存在";
            YUANZIBANJING.Text = "170";
            DIANFUXING.Text = "1.30";
            DIANLINENG.Text = "6.1979";
            YUANZITIJI.Text = "16.70";
            DIANZIPAIBU.Text = "2,8,18,32,27,8,2";
            CHZN.Text = "锫";
            EN.Text = "Berkelium";
            T.Text = "人造 放射";
        }

        private void Cf_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Cf";
            T1.Text = "98";
            Xiangduiyuanzizhiliang.Text = "[251]";
            Zhouqi.Text = "7";
            Zu.Text = "-";
            YANSE.Text = "-";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "15.10";
            RONGDIAN.Text = "1173.15";
            FEIDIAN.Text = "-";
            FANGSHEXING.Text = "存在";
            YUANZIBANJING.Text = "-";
            DIANFUXING.Text = "1.30";
            DIANLINENG.Text = "6.2817";
            YUANZITIJI.Text = "18.40";
            DIANZIPAIBU.Text = "2,8,18,32,28,8,2";
            CHZN.Text = "锎";
            EN.Text = "Californium";
            T.Text = "人造 放射 最贵金属";
        }

        private void Es_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Es";
            T1.Text = "99";
            Xiangduiyuanzizhiliang.Text = "[252]";
            Zhouqi.Text = "7";
            Zu.Text = "-";
            YANSE.Text = "-";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "8.84";
            RONGDIAN.Text = "1133.15";
            FEIDIAN.Text = "-";
            FANGSHEXING.Text = "存在";
            YUANZIBANJING.Text = "-";
            DIANFUXING.Text = "1.30";
            DIANLINENG.Text = "6.42";
            YUANZITIJI.Text = "28.50";
            DIANZIPAIBU.Text = "2,8,18,32,29,8,2";
            CHZN.Text = "锿";
            EN.Text = "Einsteinium";
            T.Text = "人造 放射";
        }

        private void Fm_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Fm";
            T1.Text = "100";
            Xiangduiyuanzizhiliang.Text = "[257]";
            Zhouqi.Text = "7";
            Zu.Text = "-";
            YANSE.Text = "-";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "-";
            RONGDIAN.Text = "1800.15";
            FEIDIAN.Text = "-";
            FANGSHEXING.Text = "存在";
            YUANZIBANJING.Text = "-";
            DIANFUXING.Text = "1.30";
            DIANLINENG.Text = "6.50";
            YUANZITIJI.Text = "29.10";
            DIANZIPAIBU.Text = "2,8,18,32,30,8,2";
            CHZN.Text = "镄";
            EN.Text = "Fermium";
            T.Text = "人造 放射";
        }

        private void Md_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Md";
            T1.Text = "101";
            Xiangduiyuanzizhiliang.Text = "[258]";
            Zhouqi.Text = "7";
            Zu.Text = "-";
            YANSE.Text = "-";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "-";
            RONGDIAN.Text = "1100.00";
            FEIDIAN.Text = "-";
            FANGSHEXING.Text = "存在";
            YUANZIBANJING.Text = "-";
            DIANFUXING.Text = "1.30";
            DIANLINENG.Text = "6.58";
            YUANZITIJI.Text = "-";
            DIANZIPAIBU.Text = "2,8,18,32,31,8,2";
            CHZN.Text = "钔";
            EN.Text = "Mendelevium";
            T.Text = "人造 放射";
        }

        private void No_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "No";
            T1.Text = "102";
            Xiangduiyuanzizhiliang.Text = "[259]";
            Zhouqi.Text = "7";
            Zu.Text = "-";
            YANSE.Text = "-";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "-";
            RONGDIAN.Text = "1100.15";
            FEIDIAN.Text = "-";
            FANGSHEXING.Text = "存在";
            YUANZIBANJING.Text = "-";
            DIANFUXING.Text = "1.30";
            DIANLINENG.Text = "6.65";
            YUANZITIJI.Text = "-";
            DIANZIPAIBU.Text = "2,8,18,32,32,8,2";
            CHZN.Text = "锘";
            EN.Text = "Nobelium";
            T.Text = "人造 放射";
        }

        private void Lr_Click(object sender, RoutedEventArgs e)
        {
            Yuansu.Text = "Lr";
            T1.Text = "103";
            Xiangduiyuanzizhiliang.Text = "[262]";
            Zhouqi.Text = "7";
            Zu.Text = "-";
            YANSE.Text = "-";
            ZHUANGTAI.Text = "固态";
            MIDU.Text = "-";
            RONGDIAN.Text = "1900.00";
            FEIDIAN.Text = "-";
            FANGSHEXING.Text = "存在";
            YUANZIBANJING.Text = "-";
            DIANFUXING.Text = "1.30";
            DIANLINENG.Text = "4.90";
            YUANZITIJI.Text = "-";
            DIANZIPAIBU.Text = "2,8,18,32,32,8,3";
            CHZN.Text = "铹";
            EN.Text = "Lawrencium";
            T.Text = "人造 放射";
        }

        public static implicit operator yuansuzhouqibiao(MainPage v)
        {
            throw new NotImplementedException();
        }
    }
}
