using Windows.ApplicationModel;
using Windows.ApplicationModel.Store;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
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
    public sealed partial class wuzhi : Page
    {
        public LicenseInformation AppLicenseInformation { get; set; }

        public wuzhi()
        {
            this.InitializeComponent();
        }

        private async void Up_Click_1(object sender, RoutedEventArgs e)
        {
            if (!AppLicenseInformation.ProductLicenses["MyInAppOfferToken"].IsActive)
            {
                try
                {
                    // The customer doesn't own this feature, so 
                    // show the purchase dialog.

                    PurchaseResults results = await CurrentApp.RequestProductPurchaseAsync("MyInAppOfferToken");

                    //Check the license state to determine if the in-app purchase was successful.

                    if (results.Status == ProductPurchaseStatus.Succeeded)
                    {
                        S7.Visibility = Visibility.Collapsed;
                        AD1.Visibility = Visibility.Collapsed;

                    }
                }
                catch (Exception ex)
                {
                    // The in-app purchase was not completed because 
                    // an error occurred.
                    throw ex;
                }
            }
            else
            {
                // The customer already owns this feature.
            }
        }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            // Remove these lines of code before publishing!
            // The actual CurrentApp will create a WindowsStoreProxy.xml
            // in the package's \LocalState\Microsoft\Windows Store\ApiData
            // folder where it stores the actual purchases.
            // Here we're just giving it a fake version of that file
            // for testing.
            StorageFolder proxyDataFolder = await Package.Current.InstalledLocation.GetFolderAsync("Assets");
            StorageFile proxyFile = await proxyDataFolder.GetFileAsync("test.xml");
            //await CurrentAppSimulator.ReloadSimulatorAsync(proxyFile);
            //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            // You may want to put this at the App level
            AppLicenseInformation = CurrentApp.LicenseInformation;

            if (AppLicenseInformation.ProductLicenses["MyInAppOfferToken"].IsActive)
            {
                // Customer can access this feature.
                S7.Visibility = Visibility.Collapsed;
                AD1.Visibility = Visibility.Collapsed;

            }
            else
            {
                // Customer can NOT access this feature.
                S7.Visibility = Visibility.Visible;
                AD1.Visibility = Visibility.Visible;

            }
        }

        private void A1_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            YINGWENMING.Text = "perchloric acid";
            FENZILIANG.Text = "100.46";

            XINGZHUANG.Text = "液体";
            YANSE.Text = "透明";
            QIWEI.Text = "强刺激性";
            FEIDIAN.Text = "19℃（1.46kPa），130℃（爆炸）";
            RONGDIAN.Text = "-112℃";
            RONGJIEXING.Text = "与水混溶";

            KERANXING.Text = "不具有（可助燃）";
            WENDINGXING.Text = "-";
            SUANXING.Text = "是";
            JIANXING.Text = "-";
            YANGHUAXING.Text = "是";
            HUANYUANXING.Text = "-";

            ZHIQU.Text = "1、实验室中，用浓硫酸与KClO4作用的方法：KClO4 ＋H2SO4 ＝KHSO4 ＋ HClO4.  " + System.Environment.NewLine + "2、工业上，用电解氧化盐酸的方法制取HClO4，电解时用铂作阳极，银或铜作阴极。";
            JIANYAN.Text = "加入可溶性钾盐观察是否沉淀，存在沉淀即可";

            WEIHAI.Text = "该品有强烈腐蚀性。皮肤粘膜接触、误服或吸入后，引起强烈刺激症状。  " + System.Environment.NewLine + "该品助燃，具强腐蚀性、强刺激性，可致人体灼伤。";
            FANGZHI.Text = "皮肤接触：立即脱去污染的衣着，用大量流动清水冲洗至少15分钟。就医。" + System.Environment.NewLine + " 眼睛接触：立即提起眼睑，用大量流动清水或生理盐水彻底冲洗至少15分钟。就医。" + System.Environment.NewLine + "  吸入：迅速脱离现场至空气新鲜处。保持呼吸道通畅。如呼吸困难，给输氧。如呼吸停止，立即进行人工呼吸。就医。" + System.Environment.NewLine + " 食入：用水漱口，给饮牛奶或蛋清。就医。";

            RICHANGYONGTU.Text = "-";
            GONGYEYONGTU.Text = "用于电镀工业、电影胶片、人造金刚石工业、电抛光工业和医药工业。 " + System.Environment.NewLine + "也用于生产砂轮除去碳粒杂质。用作强氧化剂。 " + System.Environment.NewLine + "还用于生产烟花和炸药。50%高氯酸用作丙烯腈聚合物的溶剂。 " + System.Environment.NewLine + "是制造金属高氯酸盐的原料。 " + System.Environment.NewLine + "可作化学分析试剂。";
        }

        private void A2_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            YINGWENMING.Text = "Hydroiodic Acid";
            FENZILIANG.Text = "127.9124";

            XINGZHUANG.Text = "无色气体、浅黄色液体或团状物固体";
            YANSE.Text = "无色";
            QIWEI.Text = "强烈的刺激味";
            FEIDIAN.Text = "-35.38℃";
            RONGDIAN.Text = "-50.8℃";
            RONGJIEXING.Text = "易溶于水";

            KERANXING.Text = "具有";
            WENDINGXING.Text = "-";
            SUANXING.Text = "是";
            JIANXING.Text = "-";
            YANGHUAXING.Text = "-";
            HUANYUANXING.Text = "是";

            ZHIQU.Text = "1、将碘和赤磷分别缓慢地加入到盛有水的反应器中，在搅拌下进行反应，把反应溶液过滤后，将滤液进行蒸馏，收集125～130℃的馏分。制得57%氢碘酸溶液，加入蒸馏水，得含量合格的试剂。若有游离的I2存在，在蒸馏前，先加水稀释，加热至沸，再加入50%次磷酸，直到碘的颜色消失，再进行蒸馏，即可。"+ System.Environment.NewLine +" 2、用红磷、水及碘制取碘化氢的浓溶液。在耐高温的蒸馏瓶中加入100gI2，10mLH2O。蒸馏瓶颈依次与充满玻璃棉的管和装有少量水的洗瓶相通，最后为吸收HI与装有50～60mL水的容器相通。该容器用冷水冷却。将5g红磷在研钵中与10mL水仔细研磨，将所得悬浮物移入滴液漏斗。漏斗安装在蒸馏瓶的支口上，小心滴下1滴磷悬浮物，待强烈反应后，缓慢滴加其余悬浮液（过快加入会引起爆炸）。当HI排出速度减慢时，可稍加热反应器。产量70g，按碘计产率70 %。制碘化氢气体，可用强脱水剂与浓氢碘酸溶液。在耐高温玻璃制成武兹烧瓶中，加入P2O5，同时用冷水冷却烧瓶。然后经滴液漏斗滴加HI溶液，此时可逸出均匀碘化氢气流。";
            JIANYAN.Text = "通过Cl2、Br2、浓硫酸氧化游离出碘";

            WEIHAI.Text = "有强腐蚀作用。其蒸气或烟雾对眼睛、皮肤、粘膜和呼吸道有强烈的刺激作用。";
            FANGZHI.Text = "皮肤接触：立即脱去污染的衣着，用大量流动清水冲洗至少15分钟。就医。 "+ System.Environment.NewLine + " 眼睛接触：立即提起眼睑，用大量流动清水或生理盐水彻底冲洗至少15分钟。就医。"+ System.Environment.NewLine + "  吸入：迅速脱离现场至空气新鲜处。保持呼吸道通畅。如呼吸困难，给输氧。如呼吸停止，立即进行人工呼吸。就医。" + System.Environment.NewLine +" 食入：用水漱口，给饮牛奶或蛋清。就医。";

            RICHANGYONGTU.Text = "-";
            GONGYEYONGTU.Text = "1、用作分析试剂，如有机分析中测定甲氧基与乙氧基。溶解碱土金属硫酸盐及碘化汞。作还原剂，还用于碘化物的制备； " + System.Environment.NewLine + "2、测定硒、甲氧基、乙氧基的分析试剂以及某些物质的溶剂； " + System.Environment.NewLine + "3、还原剂（单独使用或与红磷一道使用），还原烯基硅醚，从α - 三甲硅基环氧化合物合成α - 三甲硅基酮。分裂醚。使多环酮或酚环化成多环芳烃； " + System.Environment.NewLine + "4、用于合成碘化物、杀菌剂及用作药物原料； " + System.Environment.NewLine + "5、有机碘化物的制造、通用试剂、医药用中间体；用作分析试剂，也用于碘化物的制备。";
        }

        private void A3_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            YINGWENMING.Text = "Sulfuric acid";
            FENZILIANG.Text = "98.078";

            XINGZHUANG.Text = "液体";
            YANSE.Text = "无色";
            QIWEI.Text = "无味";
            FEIDIAN.Text = "337 ℃";
            RONGDIAN.Text = "10.371 ℃";
            RONGJIEXING.Text = "与水任意比互溶";

            KERANXING.Text = "不具有";
            WENDINGXING.Text = "-";
            SUANXING.Text = "是";
            JIANXING.Text = "-";
            YANGHUAXING.Text = "是";
            HUANYUANXING.Text = "-";

            ZHIQU.Text = "实验室制法" + System.Environment.NewLine + "可以用FeSO4·7H2O加强热，用加冰水混合物的U型管冷凝即可，用NaOH吸收SO2，理论可得29.5%的H2SO4。关键在于尾气吸收。" + System.Environment.NewLine + "工业制法" + System.Environment.NewLine+ "1.制取二氧化硫（沸腾炉）燃烧硫或高温处理黄铁矿，制取二氧化硫" + System.Environment.NewLine + "2.接触氧化为三氧化硫（接触室）" + System.Environment.NewLine + "3.用98.3%硫酸吸收（吸收塔）" + System.Environment.NewLine + "4.加水" + System.Environment.NewLine + "5.提纯可将工业浓硫酸进行蒸馏，便可得到浓度95 %～98 % 的商品硫酸。";
            JIANYAN.Text = "使用经过盐酸酸化的的氯化钡。向待测物溶液滴入几滴经过盐酸酸化的氯化钡溶液，震荡，如果产生白色沉淀；向溶液中加入镁粉后生成可燃性气体，则待测溶液中含有硫酸。";

            WEIHAI.Text = "对皮肉造成极大伤害;若不慎让硫酸接触到眼睛的话就有可能会造成永久性失明；而若不慎误服，则会对体内器官构成不可逆的伤害，甚至会致命。";
            FANGZHI.Text = "第一时间用大量清水冲洗10～15分钟，大量的水能够迅速冷却受损组织并带走热量。由于浓硫酸接触皮肤后会迅速将皮肤炭化，用干布擦拭可能会将已受损的皮肤擦破甚至擦掉。而若硫酸意外地溅到保护衣物，应立即将其脱下，并彻底地冲洗有关部位的皮肤。";

            RICHANGYONGTU.Text = "溶解淤塞在渠道里的油污及食物残渣等。";
            GONGYEYONGTU.Text = "用于化学纤维的生产为人民所熟悉的粘胶丝;日用品的生产;常用药物如阿斯匹林、咖啡因、维生素B2、维生素B12及维生素C、某些激素、异烟肼、汞溴红、糖精等的制备;原子能工业及火箭技术";
        }

        private void A4_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            YINGWENMING.Text = "Hydrobromic acid";
            FENZILIANG.Text = "80.91";

            XINGZHUANG.Text = "液体";
            YANSE.Text = "无色或浅黄色";
            QIWEI.Text = "有刺激性臭味";
            FEIDIAN.Text = "126℃";
            RONGDIAN.Text = "-86℃";
            RONGJIEXING.Text = "可溶于水";

            KERANXING.Text = "具有";
            WENDINGXING.Text = "-";
            SUANXING.Text = "是";
            JIANXING.Text = "-";
            YANGHUAXING.Text = "-";
            HUANYUANXING.Text = "是";

            ZHIQU.Text = "1.赤磷法：先将赤磷放入盛水的反应器中，在搅拌下缓慢加入溴素，反应生成氢溴酸和亚磷酸，通过沉降、过滤、蒸馏制得氢溴酸成品。" + System.Environment.NewLine + "2.二氧化硫法：将二氧化硫通入加有溴和碎冰的反应釜中，保持温度在20℃以下进行反应直至溶液呈黄色。将混合溶液进行蒸馏，蒸出溶液加入氢氧化钡溶液与生成的硫酸反应，生成硫酸钡沉淀。经静置，过滤，除去沉淀，再蒸馏滤液即得氢溴酸成品。" + System.Environment.NewLine + "3.化合法：液溴与氢气在活性炭催化剂存在下直接合成溴化氢。然后蒸馏、提纯，制得溴化氢。" + System.Environment.NewLine + "4.置换法：在催化剂FeBr3存在下，将苯溴化。在烧瓶中放置200g无水苯和几克溴化铁(或铁粉)，然后，将烧瓶用涂石蜡的塞子，塞好，塞子上插有滴液漏斗和排气管，经滴液漏斗缓慢加入135mL溴(在负压下)。这时会发生激烈反应(烧瓶应用水冷却)，并均匀地放出溴化氢。出来的气体通过一U型管，它的一端装满FeBr3以吸收苯，另一端装满蒽以结合带出来的溴。溴与含水的红磷作用。在烧瓶中放10g红磷，20mL水。经滴液漏斗在负压下缓慢加入35mL溴。为了将出来的气体提纯，使它通过一个充满石棉与含水(但不是湿的)红磷混合物的U型管。被提纯的氢溴酸用氯仿萃取，分去水相进行蒸馏。62℃时蒸出少量氯仿，在125～126℃蒸出氢溴酸(相对密度1.473)。" + System.Environment.NewLine + "5.酸法：在200毫升水中加入120克粉末状的溴化钾。将容器放在冷水中，并缓侵地加入90毫升浓硫酸。温度应不使超过75℃，否则就会生成少量的游离溴。即使生成少量的溴也无妨，因为它将在蒸馏过程中随沸点为100—115℃之间的馏份而蒸馏出来。将溶液冷却至室温，并在玻芯漏斗中滤出酸式硫酸钾。将滤液放在500毫升蒸馏瓶中，装上水冷凝器和接受器，并放在铁丝网上加热。溶液中有0.01一0.015%的硫酸根离子并无妨碍，将比恒沸混合物沸点低1℃，开始馏出的蒸馏液保留起来。当温度下降时应立即停止蒸馏。溶液的比重是会改变的，因为蒸馏液的组成会随着大气压力而发生改变，所得产率约为85%。将低沸点的馏份进行再蒸馏就可以增大产率。如果需要不含硫酸根离子的值沸液，在比恒沸液馏出温度低5℃时即开始收集蒸馏液，将这个酸进行再蒸馏，并仅收集在恒沸点时馏出的溶液以获得比重最大的恒沸酸。在第二次蒸馏之前加入氢氧化钡并不能制得更纯些的产物。产率约近似地为计算量的86%。将氢溴酸与氯化亚锡一道蒸馏，可得无色的氢溴酸。浓硫酸也可以用浓磷酸替代。";
            JIANYAN.Text = "使用用硝酸银溶液，出现淡黄色固体即可";

            WEIHAI.Text = "可引起皮肤、粘膜的刺激或灼伤。长期低浓度接触可引起呼吸道刺激症状和消化功能障碍。";
            FANGZHI.Text = "1皮肤接触：脱去污染的衣着，用流动清水冲洗10分钟或用2%碳酸氢钠溶液冲洗。若有灼伤，就医治疗。" + System.Environment.NewLine + "2眼睛接触：立即提起眼睑，用流动清水或生理盐水冲洗至少15分钟。就医。" + System.Environment.NewLine + "3吸入：迅速脱离现场至空气新鲜处。如出现呼吸困难应立即救治。呼吸停止时，立即进行人工呼吸。" + System.Environment.NewLine + "4食入：入误食入口应立即就医处治。";

            RICHANGYONGTU.Text = "-";
            GONGYEYONGTU.Text = "1医药工业用于合成镇静剂和麻醉剂等医药用品。" + System.Environment.NewLine + "2石油工业用作烷基化催化剂。" + System.Environment.NewLine + "3作为分析试剂还用于测定硫、硒、砷、锌和铁，以及从砷、锑中分离锡等。" + System.Environment.NewLine + "4也用于合成染料或香料。";
        }

        private void A5_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            YINGWENMING.Text = "hydrochloric acid";
            FENZILIANG.Text = "36.5";

            XINGZHUANG.Text = "液体";
            YANSE.Text = "无色至淡黄色";
            QIWEI.Text = "刺激性";
            FEIDIAN.Text = "110℃（383K，20.2%溶液）" + System.Environment.NewLine + "48℃（321K，38%溶液）";
            RONGDIAN.Text = "-27.32℃（247K，38%溶液）";
            RONGJIEXING.Text = "与水混溶";

            KERANXING.Text = "不具有";
            WENDINGXING.Text = "-";
            SUANXING.Text = "是";
            JIANXING.Text = "-";
            YANGHUAXING.Text = "-";
            HUANYUANXING.Text = "是";

            ZHIQU.Text = "电解饱和食盐水；通过氯气与二氧化硫在水溶液中作用来制备";
            JIANYAN.Text = "试品用水稀释，加甲基红指示液，用氢氧化钠滴定液滴定。甲基红指示液变红时停止滴定，读出氢氧化钠滴定液使用量，计算盐酸含量。";

            WEIHAI.Text = "能与一些活性金属粉末发生反应, 放出氢气。遇氰化物能产生剧毒的氰化氢气体。与碱发生中和反应，并放出大量的热。具有较强的腐蚀性";
            FANGZHI.Text = "1皮肤接触：立即脱去污染的衣着，用大量流动清水冲洗至少15分钟，可涂抹弱碱性物质（如碱水、肥皂水等），就医。" + System.Environment.NewLine + "2眼睛接触： 立即提起眼睑，用大量流动清水或生理盐水彻底冲洗至少15分钟。就医。" + System.Environment.NewLine + "3吸入：迅速脱离现场至空气新鲜处。保持呼吸道通畅。如呼吸困难，给输氧。如呼吸停止，立即进行人工呼吸。就医。" + System.Environment.NewLine + "4食入：用大量水漱口，吞服大量生鸡蛋清或牛奶（禁止服用小苏打等药品），就医。";

            RICHANGYONGTU.Text = "利用盐酸可以与难溶性碱反应的性质，制取洁厕灵、除锈剂等日用品。";
            GONGYEYONGTU.Text = "分析化学；酸洗钢材；制备化合物；控制pH及中和碱液；用于焰色反应；阳离子交换树脂的再生";
        }

        private void A6_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            YINGWENMING.Text = "Nitric acid";
            FENZILIANG.Text = "63.01";

            XINGZHUANG.Text = "液体";
            YANSE.Text = "无色";
            QIWEI.Text = "刺激性";
            FEIDIAN.Text = "122℃";
            RONGDIAN.Text = "-42℃";
            RONGJIEXING.Text = "易溶于水";

            KERANXING.Text = "是";
            WENDINGXING.Text = "-";
            SUANXING.Text = "是";
            JIANXING.Text = "-";
            YANGHUAXING.Text = "是";
            HUANYUANXING.Text = "-";

            ZHIQU.Text = "工业：铂铑合金网，在合金网的催化下，氨被氧化成一氧化氮（NO）。生成的一氧化氮利用反应后残余的氧气继续氧化为二氧化氮，随后将二氧化氮通入水中制取硝酸。" + System.Environment.NewLine + "实验室：烧瓶中加入沸石，浓硫酸，硝酸钠。置于铁架台上的铁圈上，铁圈下隔 石棉网放置加热设备，烧瓶口用带有玻璃管的橡皮塞塞住，玻璃管用橡皮管相连，另一头置于有水的烧杯中。";
            JIANYAN.Text = "-";

            WEIHAI.Text = "溅到皮肤上也会引起严重烧伤。";
            FANGZHI.Text = "1皮肤接触：立即脱去污染的衣着，用大量流动清水冲洗至少15分钟，可涂抹弱碱性物质（如碱水、肥皂水等），就医。" + System.Environment.NewLine + "2眼睛接触： 立即提起眼睑，用大量流动清水或生理盐水彻底冲洗至少15分钟。就医。" + System.Environment.NewLine + "3吸入：迅速脱离现场至空气新鲜处。保持呼吸道通畅。如呼吸困难，给输氧。如呼吸停止，立即进行人工呼吸。就医。" + System.Environment.NewLine + "4食入：用大量水漱口，吞服大量生鸡蛋清或牛奶（禁止服用小苏打等药品），就医。";

            RICHANGYONGTU.Text = "-";
            GONGYEYONGTU.Text = "炸药；供制氮肥、王水、硝酸盐、硝化甘油、硝化纤维素、硝基苯、苦味酸等";
        }

        private void A7_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            YINGWENMING.Text = "Iodic acid";
            FENZILIANG.Text = "175.91";

            XINGZHUANG.Text = "无色斜方结晶，或有光泽的结晶";
            YANSE.Text = "白色";
            QIWEI.Text = "特殊气味";
            FEIDIAN.Text = "-";
            RONGDIAN.Text = "110℃";
            RONGJIEXING.Text = "易溶于水";

            KERANXING.Text = "-";
            WENDINGXING.Text = "-";
            SUANXING.Text = "是";
            JIANXING.Text = "-";
            YANGHUAXING.Text = "是";
            HUANYUANXING.Text = "-";

            ZHIQU.Text = "利用碘单质在碱性水溶液中可以发生歧化反应的特点，可以制取碘酸盐。" + System.Environment.NewLine + "利用溶解度差异较大，将碘化物和碘酸盐分离，得到碘酸盐，酸化后得碘酸。" + System.Environment.NewLine + "利用氧化法可得到溴酸盐和碘酸盐，如在碱性溶液中用Cl2氧化Br-或I-，得到溴酸盐或碘酸盐。";
            JIANYAN.Text = "-";

            WEIHAI.Text = "对眼、粘膜、皮肤和上呼吸道有刺激性。";
            FANGZHI.Text = "1皮肤接触：立即脱去污染的衣着，用大量流动清水冲洗至少15分钟，可涂抹弱碱性物质（如碱水、肥皂水等），就医。" + System.Environment.NewLine + "2眼睛接触： 立即提起眼睑，用大量流动清水或生理盐水彻底冲洗至少15分钟。就医。" + System.Environment.NewLine + "3吸入：迅速脱离现场至空气新鲜处。保持呼吸道通畅。如呼吸困难，给输氧。如呼吸停止，立即进行人工呼吸。就医。" + System.Environment.NewLine + "4食入：用大量水漱口，吞服大量生鸡蛋清或牛奶（禁止服用小苏打等药品），就医。";

            RICHANGYONGTU.Text = "-";
            GONGYEYONGTU.Text = "分析试剂；碘化物的制备";
        }

        private void A8_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            YINGWENMING.Text = "Trichloroacetic acid solution";
            FENZILIANG.Text = "163.40";

            XINGZHUANG.Text = "固体";
            YANSE.Text = "无色";
            QIWEI.Text = "刺激性";
            FEIDIAN.Text = "197.5℃";
            RONGDIAN.Text = "57.5℃";
            RONGJIEXING.Text = "溶于水、乙醇、乙醚";

            KERANXING.Text = "是";
            WENDINGXING.Text = "-";
            SUANXING.Text = "是";
            JIANXING.Text = "-";
            YANGHUAXING.Text = "-";
            HUANYUANXING.Text = "-";

            ZHIQU.Text = "由醋酸氯化后分离以氯乙酸母液作原料，硫磺粉为催化剂，在90-100℃条件下继续氯化，然后再结晶，即得。";
            JIANYAN.Text = "-";

            WEIHAI.Text = "吸入本品粉尘对呼吸道有刺激作用，可引起咳嗽、胸痛和中枢神经系统抑制。眼直接接触可造成严重损害，重者可导致失明。皮肤接触可致化学性灼伤。口服灼伤口腔和消化道，出现剧烈腹痛、呕吐和虚脱。";
            FANGZHI.Text = "1皮肤接触：立即脱去污染的衣着，用大量流动清水冲洗至少15分钟，可涂抹弱碱性物质（如碱水、肥皂水等），就医。" + System.Environment.NewLine + "2眼睛接触： 立即提起眼睑，用大量流动清水或生理盐水彻底冲洗至少15分钟。就医。" + System.Environment.NewLine + "3吸入：迅速脱离现场至空气新鲜处。保持呼吸道通畅。如呼吸困难，给输氧。如呼吸停止，立即进行人工呼吸。就医。" + System.Environment.NewLine + "4食入：用大量水漱口，吞服大量生鸡蛋清或牛奶（禁止服用小苏打等药品），就医。";

            RICHANGYONGTU.Text = "-";
            GONGYEYONGTU.Text = "用于有机合成和制医药、化学试剂、杀虫剂;";
        }

        private void A9_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            YINGWENMING.Text = "Oxalic acid;Ethanedioic acid";
            FENZILIANG.Text = "90.04";

            XINGZHUANG.Text = "片状固体";
            YANSE.Text = "无色";
            QIWEI.Text = "氧化法草酸无气味；合成法草酸有味";
            FEIDIAN.Text = "150～160℃";
            RONGDIAN.Text = "101～102℃";
            RONGJIEXING.Text = "1g溶于7ml水、2ml沸水、2.5ml乙醇、1.8ml沸乙醇、100ml乙醚、5.5ml甘油";

            KERANXING.Text = "是";
            WENDINGXING.Text = "189.5℃分解";
            SUANXING.Text = "是";
            JIANXING.Text = "-";
            YANGHUAXING.Text = "-";
            HUANYUANXING.Text = "是";

            ZHIQU.Text = "甲酸钠法、氧化法、羰基合成法、乙二醇氧化法、丙烯氧化法、一氧化碳偶联法";
            JIANYAN.Text = "以酚酞为指示剂，用氢氧化钠标准溶液滴定。";

            WEIHAI.Text = "草酸的致命之处在于它能使人体血液中的钙离子含量降低到临界水平；过量摄入草酸还会造成结石";
            FANGZHI.Text = "-";

            RICHANGYONGTU.Text = "-";
            GONGYEYONGTU.Text = "医药工业；用作酚醛树脂合成的催化剂；漂白剂";
        }

        private void A10_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            YINGWENMING.Text = "Maleic acid";
            FENZILIANG.Text = "116.0722";

            XINGZHUANG.Text = "晶体";
            YANSE.Text = "无色";
            QIWEI.Text = "涩味";
            FEIDIAN.Text = "355.482°C";
            RONGDIAN.Text = "134-138℃";
            RONGJIEXING.Text = "易溶于乙醇、丙酮、水";

            KERANXING.Text = "-";
            WENDINGXING.Text = "-";
            SUANXING.Text = "是";
            JIANXING.Text = "-";
            YANGHUAXING.Text = "是";
            HUANYUANXING.Text = "-";

            ZHIQU.Text = "工业上生产顺丁烯二酸是在五氧化二钒催化下，于450～500℃用空气氧化苯，先生成顺丁烯二酸酐，经水解即得";
            JIANYAN.Text = "-";

            WEIHAI.Text = "有少量技术能力比较低的企业了提高淀粉的粘度、稳定性等性能，在食用淀粉中加入大量顺丁烯二酸淀粉酯，但由于技术等条件的限制，作为原料的顺丁烯二酸酐存在着大量的残留，从而使食用淀粉存在着巨大的食品安全隐患。";
            FANGZHI.Text = "-";

            RICHANGYONGTU.Text = "-";
            GONGYEYONGTU.Text = "制造不饱和聚酯树脂";
        }

        private void A11_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            YINGWENMING.Text = "Sulfurous acid";
            FENZILIANG.Text = "82.0791";

            XINGZHUANG.Text = "液体";
            YANSE.Text = "无色";
            QIWEI.Text = "刺激性";
            FEIDIAN.Text = "大于35°c";
            RONGDIAN.Text = "-";
            RONGJIEXING.Text = "溶于水";

            KERANXING.Text = "-";
            WENDINGXING.Text = "稳定；亚硫酸水溶液在紫外线下长时间照射或加热到140℃时会按下式发生分解";
            SUANXING.Text = "是";
            JIANXING.Text = "-";
            YANGHUAXING.Text = "是";
            HUANYUANXING.Text = "-";

            ZHIQU.Text = "将工业二氧化硫气体或钢瓶二氧化硫洗瓶后，通入纯水，即得亚硫酸";
            JIANYAN.Text = "-";

            WEIHAI.Text = "对眼睛、皮肤、粘膜和呼吸道有强烈的刺激作用。吸入后可因喉、支气管的痉挛、水肿、炎症，化学性肺炎、肺水肿而致死。中毒表现有烧灼感、咳嗽、喘息、喉炎、气短、头痛、恶心和呕吐。";
            FANGZHI.Text = "1皮肤接触：立即脱去污染的衣着，用大量流动清水冲洗至少15分钟，可涂抹弱碱性物质（如碱水、肥皂水等），就医。" + System.Environment.NewLine + "2眼睛接触： 立即提起眼睑，用大量流动清水或生理盐水彻底冲洗至少15分钟。就医。" + System.Environment.NewLine + "3吸入：迅速脱离现场至空气新鲜处。保持呼吸道通畅。如呼吸困难，给输氧。如呼吸停止，立即进行人工呼吸。就医。" + System.Environment.NewLine + "4食入：用大量水漱口，吞服大量生鸡蛋清或牛奶（禁止服用小苏打等药品），就医。";

            RICHANGYONGTU.Text = "-";
            GONGYEYONGTU.Text = "用作分析试剂、还原剂及防腐剂，用于纺织、造纸、冶金工业和有机合成。";
        }

        private void A12_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            YINGWENMING.Text = "Pyruvic acid";
            FENZILIANG.Text = "88.06";

            XINGZHUANG.Text = "透明液体";
            YANSE.Text = "浅黄色至黄色";
            QIWEI.Text = "醋酸气味";
            FEIDIAN.Text = "165℃";
            RONGDIAN.Text = "11.8℃";
            RONGJIEXING.Text = "与水、乙醇、乙醚等混溶";

            KERANXING.Text = "-";
            WENDINGXING.Text = "-";
            SUANXING.Text = "是";
            JIANXING.Text = "-";
            YANGHUAXING.Text = "是";
            HUANYUANXING.Text = "-";

            ZHIQU.Text = "酒石酸脱水脱羧法；乳酸氧化法；酶催化法；微生物发酵法；基因工程技术";
            JIANYAN.Text = "-";

            WEIHAI.Text = "-";
            FANGZHI.Text = "-";

            RICHANGYONGTU.Text = "在代谢中的作用；抗氧化作用";
            GONGYEYONGTU.Text = "-";
        }

        private void A13_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            YINGWENMING.Text = "Propanedioic acid";
            FENZILIANG.Text = "104.06";

            XINGZHUANG.Text = "结晶";
            YANSE.Text = "白色";
            QIWEI.Text = "-";
            FEIDIAN.Text = "386.8°C";
            RONGDIAN.Text = "135.6 ℃";
            RONGJIEXING.Text = "溶于水，溶于乙醇、乙醚。溶于丙酮";

            KERANXING.Text = "-";
            WENDINGXING.Text = "受热即失去二氧化碳生成乙酸";
            SUANXING.Text = "是";
            JIANXING.Text = "-";
            YANGHUAXING.Text = "-";
            HUANYUANXING.Text = "-";

            ZHIQU.Text = "乙酸与氯气反应得到氯乙酸，再用碳酸钠处理生成钠盐，与氰化钠发生亲核取代反应，得到氰乙酸。氢氧化钠溶液水解，氰基转化为羧酸根离子，然后酸化即得丙二酸。";
            JIANYAN.Text = "-";

            WEIHAI.Text = "健康危害：对眼睛、皮肤、粘膜和上呼吸道有刺激作用，高浓度时有损害作用。接触后可引起烧灼感、咳嗽、喉炎、头痛、恶心和呕吐等。" + System.Environment.NewLine + "环境危害： 对环境有危害，对水体和大气可造成污染";
            FANGZHI.Text = "用大量水冲洗";

            RICHANGYONGTU.Text = "-";
            GONGYEYONGTU.Text = "医药中间体；络合剂；香料；粘合剂；树脂添加剂；化学镀的添加物质；电镀抛光剂";
        }

        private void A14_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            YINGWENMING.Text = "Chloroacetic acid";
            FENZILIANG.Text = "94.49";

            XINGZHUANG.Text = "结晶";
            YANSE.Text = "无色；淡黄色";
            QIWEI.Text = "刺激性";
            FEIDIAN.Text = "188";
            RONGDIAN.Text = "61~63";
            RONGJIEXING.Text = "易溶于水，溶于乙醇、乙醚、苯、二硫化碳和氯仿";

            KERANXING.Text = ">500°c可燃";
            WENDINGXING.Text = "-";
            SUANXING.Text = "是";
            JIANXING.Text = "-";
            YANGHUAXING.Text = "-";
            HUANYUANXING.Text = "是";

            ZHIQU.Text = "氯乙烯、氯乙酰氯水解法、三氯乙烯水解法、氯乙炔法、四氯乙烯法、丙三醇法、二氯乙酸法、三氯乙醛法、氯乙醇氧化法、乙烯酮氧化法和乙酸催化氯化法等十多种，工业生产方法主要有三氯乙烯水解法、氯乙酰氯法以及乙酸催化氯化法三种";
            JIANYAN.Text = "-";

            WEIHAI.Text = "吸入高浓度该品蒸气或皮肤接触其溶液后，可迅速大量吸收，造成急性中毒。吸入初期为上呼吸道刺激症状。中毒后数小时即可出现心、肺、肝、肾及中枢神经损害，重者呈现严重酸中毒。患者可有抽搐、昏迷、休克、血尿和肾功能衰竭。酸雾可致眼部刺激症状和角膜灼伤。皮肤灼伤可出现水疱，1～2周后水疱吸收。慢性影响：经常接触低浓度该品酸雾，可有头痛、头晕现象。";
            FANGZHI.Text = "立即脱离事故现场，转移到空气新鲜处，脱去污染的衣物，并用大量清水冲洗污染皮肤至少15分钟；眼污染时应分开眼睑用微温水缓流冲洗至少15分钟。注意勿让冲洗后流下的水再污染 健康 的眼； 使病人安静，保暖，休息，密切观察病情变化。轻度中毒病人以支持疗法为主，同时给予对症治疗。较重中毒病人应早期、适量、短程给予糖皮质激素，以控制肺水肿。";

            RICHANGYONGTU.Text = "-";
            GONGYEYONGTU.Text = "测定锌、钙、硅和钛。合成咖啡碱、肾上腺素、氨基乙酸、萘乙酸。制造各种染料。除锈剂";
        }

        private void A15_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            YINGWENMING.Text = "Phthalic acid";
            FENZILIANG.Text = "166.13";

            XINGZHUANG.Text = "结晶或结晶性粉末";
            YANSE.Text = "无色";
            QIWEI.Text = "-";
            FEIDIAN.Text = "230";
            RONGDIAN.Text = "168";
            RONGJIEXING.Text = "溶于甲醇和乙醇，微溶于水和乙醚，不溶于氯仿、苯和石油醚";

            KERANXING.Text = "-";
            WENDINGXING.Text = "在213ºC分解成水和邻苯二甲酸酐";
            SUANXING.Text = "是";
            JIANXING.Text = "-";
            YANGHUAXING.Text = "-";
            HUANYUANXING.Text = "是";

            ZHIQU.Text = "将邻苯二甲酸酐加到60℃水中，边搅拌边加入氨水至ph值为8，脱色过滤后，用盐酸酸化，所得结晶经水洗合格后，即为成品。";
            JIANYAN.Text = "-";

            WEIHAI.Text = "-";
            FANGZHI.Text = "1皮肤接触：立即脱去污染的衣着，用大量流动清水冲洗至少15分钟，可涂抹弱碱性物质（如碱水、肥皂水等），就医。" + System.Environment.NewLine + "2眼睛接触： 立即提起眼睑，用大量流动清水或生理盐水彻底冲洗至少15分钟。就医。" + System.Environment.NewLine + "3吸入：迅速脱离现场至空气新鲜处。保持呼吸道通畅。如呼吸困难，给输氧。如呼吸停止，立即进行人工呼吸。就医。" + System.Environment.NewLine + "4食入：用大量水漱口，吞服大量生鸡蛋清或牛奶（禁止服用小苏打等药品），就医。";

            RICHANGYONGTU.Text = "-";
            GONGYEYONGTU.Text = "1. 配制标准溶液" + System.Environment.NewLine + "2.用作分析试剂" + System.Environment.NewLine + "3.用于制取染料、聚酯树脂、涤纶、药物及增塑剂等";
        }

        private void A16_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            YINGWENMING.Text = "Salicylic acid";
            FENZILIANG.Text = "138.12";

            XINGZHUANG.Text = "针状晶体或毛状结晶性粉末";
            YANSE.Text = "白色";
            QIWEI.Text = "刺鼻酸味";
            FEIDIAN.Text = "210";
            RONGDIAN.Text = "158～161";
            RONGJIEXING.Text = "易溶于乙醇、乙醚、氯仿，微溶于水，在沸水中溶解";

            KERANXING.Text = "-";
            WENDINGXING.Text = "-";
            SUANXING.Text = "是";
            JIANXING.Text = "-";
            YANGHUAXING.Text = "-";
            HUANYUANXING.Text = "-";

            ZHIQU.Text = "苯酚与氢氧化钠反应生成苯酚钠，蒸馏脱水后，通二氧化碳进行羧基化反应，制得水杨酸钠盐，再用硫酸酸化，而得粗品。粗品经升华精制得成品。原料消耗定额：苯酚（98%）704kg/t、烧碱（95%）417kg/t、硫酸（95%）500kg/t、二氧化碳（99%）467kg/t";
            JIANYAN.Text = "-";

            WEIHAI.Text = "中毒时可表现恶心、呕吐、头痛、听觉障碍，大量出汗、面色潮红、口渴、皮肤苍白、紫绀、粘膜出血、胃灼痛、肝脏肿大、黄疸、脉快、呼吸加速和变深。此外，尚可发生水、电解质失衡和中毒。有时可发生低血糖或暂时性血糖升高和尿甚者可发生烦躁不安，精神错乱、抽搐、昏迷、休克和呼吸衰竭。";
            FANGZHI.Text = "1皮肤接触：立即脱去污染的衣着，用大量流动清水冲洗至少15分钟，可涂抹弱碱性物质（如碱水、肥皂水等），就医。" + System.Environment.NewLine + "2眼睛接触： 立即提起眼睑，用大量流动清水或生理盐水彻底冲洗至少15分钟。就医。" + System.Environment.NewLine + "3吸入：迅速脱离现场至空气新鲜处。保持呼吸道通畅。如呼吸困难，给输氧。如呼吸停止，立即进行人工呼吸。就医。" + System.Environment.NewLine + "4食入：用大量水漱口，吞服大量生鸡蛋清或牛奶（禁止服用小苏打等药品），就医。";

            RICHANGYONGTU.Text = "《水杨酸苯酚贴膏》，俗称鸡眼膏";
            GONGYEYONGTU.Text = "防焦剂及生产紫外线吸收剂和发泡剂；配合指示剂；医药工业的原料；环氧树脂固化的促进剂；防腐剂";
        }

        private void B1_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            YINGWENMING.Text = "lithium hydroxide";
            FENZILIANG.Text = "23.95";

            XINGZHUANG.Text = "四方晶系晶体";
            YANSE.Text = "白色";
            QIWEI.Text = "辣味";
            FEIDIAN.Text = "925℃";
            RONGDIAN.Text = "471℃";
            RONGJIEXING.Text = "易溶";

            KERANXING.Text = "-";
            WENDINGXING.Text = "925℃（分解）";
            SUANXING.Text = "-";
            JIANXING.Text = "是";
            YANGHUAXING.Text = "-";
            HUANYUANXING.Text = "是";

            ZHIQU.Text = "氢氧化锂通常是靠将碳酸锂与石灰乳调成浆状，用100℃水蒸气加热，滤去碳酸钙的方法来制备。";
            JIANYAN.Text = "使紫色石蕊试液变蓝，使无色酚酞变红；而其浓溶液经实验验证，可以使酚酞变性，使溶液由红色变为无色";

            WEIHAI.Text = "该品腐蚀性极强，能灼伤眼睛、皮肤和上呼吸道，口服腐蚀消化道，可引起死亡。吸入，可引起喉、支气管炎症、痉挛，化学性肺炎、肺水肿等。";
            FANGZHI.Text = "1皮肤接触：立即脱去污染的衣着，用大量流动清水冲洗至少15分钟，可涂抹弱碱性物质（如碱水、肥皂水等），就医。" + System.Environment.NewLine + "2眼睛接触： 立即提起眼睑，用大量流动清水或生理盐水彻底冲洗至少15分钟。就医。" + System.Environment.NewLine + "3吸入：迅速脱离现场至空气新鲜处。保持呼吸道通畅。如呼吸困难，给输氧。如呼吸停止，立即进行人工呼吸。就医。" + System.Environment.NewLine + "4食入：用大量水漱口，吞服大量生鸡蛋清或牛奶（禁止服用小苏打等药品），就医。";

            RICHANGYONGTU.Text = "-";
            GONGYEYONGTU.Text = "用于制锂盐及锂基润滑脂，碱性蓄电池的电解液，溴化锂制冷机吸收液等;石油、化工、轻工、核工业等用。用于碱性蓄电池时，铝含量不大于0.06%，铅含量不大于0.01%。用作分析试剂、照相显影剂，也用于锂的制造;要用作制取锂化合物的原料。也可用于冶金、石油、玻璃、陶瓷等工业。";
        }

        private void B2_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            YINGWENMING.Text = "Sodium hydroxide";
            FENZILIANG.Text = "39.996";

            XINGZHUANG.Text = "片状或颗粒";
            YANSE.Text = "白色半透明";
            QIWEI.Text = "涩味";
            FEIDIAN.Text = "1390 ℃ (1663 K)";
            RONGDIAN.Text = "318.4℃(591 K)";
            RONGJIEXING.Text = "极易溶于水";

            KERANXING.Text = "-";
            WENDINGXING.Text = "在空气中易潮解";
            SUANXING.Text = "-";
            JIANXING.Text = "是";
            YANGHUAXING.Text = "-";
            HUANYUANXING.Text = "是";

            ZHIQU.Text = "用一些碳酸氢钠（小苏打）和一些氧化钙（生石灰）。把生石灰放于水中，反应后变为石灰浆（氢氧化钙溶液、熟石灰），把碳酸氢钠（或碳酸钠）的固体颗粒（浓溶液也行）加入石灰浆中，为保证产物氢氧化钠的纯度，需使石灰浆过。原因：参考氢氧化钙和碳酸钠的溶解度。搅拌加快其反应，待其反应一会儿后，静置片刻，随着碳酸钙的沉淀，上层清液就是氢氧化钠溶液，小心倒出即可。";
            JIANYAN.Text = "利用酸碱指示剂在溶液pH值不同时显现不同颜色的特性，用酸调整试样溶液的pH至特定值时，通过消耗酸的量计算出试样中氢氧化钠的量与变质的量。";

            WEIHAI.Text = "有强烈刺激和腐蚀性。粉尘或烟雾会刺激眼和呼吸道，腐蚀鼻中隔，皮肤和眼与NaOH直接接触会引起灼伤，误服可造成消化道灼伤，粘膜糜烂、出血和休克。";
            FANGZHI.Text = " 呼吸系统防护：必要时佩带防毒口罩。" + System.Environment.NewLine + "眼睛防护：戴化学安全防护眼镜。防护服：穿工作服（防腐材料制作）。小心使用，小心溅落到衣物、口鼻中。" + System.Environment.NewLine + "手防护：戴橡皮手套。" + System.Environment.NewLine + "其它：工作后，淋浴更衣。注意个人清洁卫生。";

            RICHANGYONGTU.Text = "制造肥皂是烧碱最古老和最广泛的用途。";
            GONGYEYONGTU.Text = "使用氢氧化钠最多的部门是化学药品的制造，其次是造纸、炼铝、炼钨、人造丝、人造棉和肥皂制造业。另外，在生产染料、塑料、药剂及有机中间体，旧橡胶的再生，制金属钠、水的电解以及无机盐生产中，制取硼砂、铬盐、锰酸盐、磷酸盐等，也要使用大量的烧碱。同时氢氧化钠是生产聚碳酸酯、超级吸收质聚合物、沸石、环氧树脂、磷酸钠、亚硫酸钠和大量钠盐的重要原材料之一。";
        }

        private void B3_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            YINGWENMING.Text = "calcium hydroxide";
            FENZILIANG.Text = "74.096";

            XINGZHUANG.Text = "粉末状固体";
            YANSE.Text = "白色";
            QIWEI.Text = "刺激性";
            FEIDIAN.Text = "2850 ℃";
            RONGDIAN.Text = "580℃";
            RONGJIEXING.Text = "微溶";

            KERANXING.Text = "-";
            WENDINGXING.Text = "-";
            SUANXING.Text = "-";
            JIANXING.Text = "是";
            YANGHUAXING.Text = "-";
            HUANYUANXING.Text = "-";

            ZHIQU.Text = "将生石灰（CaO）放入烧杯加入水。氧化钙和水反应，放出热量，生成物是氢氧化钙。反应式：CaO+H2O→Ca(OH)2。";
            JIANYAN.Text = "-";

            WEIHAI.Text = "有刺激和腐蚀作用。吸入粉尘，对呼吸道有强烈刺激性，还有可能引起肺炎。眼接触亦有强烈刺激性，可致灼伤。";
            FANGZHI.Text = "必要时佩带防毒口罩；戴化学安全防护眼镜";

            RICHANGYONGTU.Text = "-";
            GONGYEYONGTU.Text = "生产碳酸钙的原料；降低土壤的酸性；橡胶、石油化工添加剂；制取漂白粉、漂粉精、消毒剂、制酸剂、收敛剂、硬水软化剂、土壤酸性防止剂、脱毛剂、缓冲剂、中和剂、固化剂等";
        }

        private void B4_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            YINGWENMING.Text = "Potassium hydroxide";
            FENZILIANG.Text = "56.1";

            XINGZHUANG.Text = "粉末或片状固体";
            YANSE.Text = "白色";
            QIWEI.Text = "-";
            FEIDIAN.Text = "1324℃";
            RONGDIAN.Text = "380℃";
            RONGJIEXING.Text = "易溶";

            KERANXING.Text = "-";
            WENDINGXING.Text = "极易吸收空气中水分而潮解，吸收二氧化碳而成碳酸钾";
            SUANXING.Text = "-";
            JIANXING.Text = "是";
            YANGHUAXING.Text = "是";
            HUANYUANXING.Text = "是";

            ZHIQU.Text = "隔膜电解法原料氯化钾在化盐槽溶化成饱和溶液，加热至90 ℃时分别加入碳酸钾、苛性钾、氯化钡除去钙、镁和硫酸根等杂质，经沉降除渣、盐酸中和、精制的含氯化钾280～315 g/L的氯化钾溶液经预热到70～75 ℃后进行电解，得氢氧化钾、氯气和氢气。隔膜法所得氢氧化钾浓度为10%～11%，需通过蒸发浓缩和冷却澄清，制得含45%～50%氢氧化钾溶液;也可继续在熬碱锅中浓缩，经脱色，制得固体氢氧化钾，或经制片成片状氢氧化钾产品";
            JIANYAN.Text = "-";

            WEIHAI.Text = "对组织有烧灼作用，可溶解蛋白质，形成碱性变性蛋白质。溶液或粉尘溅到皮肤上，尤其溅到黏膜，可产生软痂。溶液浓度越高，温度越高，作用越强。溅入眼内，不仅可损伤角膜，而且能使眼部深组织损伤。";
            FANGZHI.Text = "1皮肤接触：立即脱去污染的衣着，用大量流动清水冲洗至少15分钟，可涂抹弱碱性物质（如碱水、肥皂水等），就医。" + System.Environment.NewLine + "2眼睛接触： 立即提起眼睑，用大量流动清水或生理盐水彻底冲洗至少15分钟。就医。" + System.Environment.NewLine + "3吸入：迅速脱离现场至空气新鲜处。保持呼吸道通畅。如呼吸困难，给输氧。如呼吸停止，立即进行人工呼吸。就医。" + System.Environment.NewLine + "4食入：用大量水漱口，吞服大量生鸡蛋清或牛奶（禁止服用小苏打等药品），就医。";

            RICHANGYONGTU.Text = "-";
            GONGYEYONGTU.Text = "用作干燥剂、吸收剂，用于制草酸及各种钾盐，还用于电镀、雕刻、石印术等";
        }

        private void B5_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            YINGWENMING.Text = "ammonium hydroxide";
            FENZILIANG.Text = "35.045";

            XINGZHUANG.Text = "液体";
            YANSE.Text = "无色透明";
            QIWEI.Text = "刺激性";
            FEIDIAN.Text = "37.7°C (25%)24.7°C (32%)";
            RONGDIAN.Text = "-77℃";
            RONGJIEXING.Text = "易溶";

            KERANXING.Text = "-";
            WENDINGXING.Text = "氨水易挥发出氨气，随温度升高和放置时间延长而挥发率增加，且随浓度的增大挥发量增加。";
            SUANXING.Text = "-";
            JIANXING.Text = "是";
            YANGHUAXING.Text = "-";
            HUANYUANXING.Text = "-";

            ZHIQU.Text = "先制备氨气，氨气的制备可以用氯化铵和氢氧化钠制取，要加热，或是铵盐和碱混和制备加热。收集用向下排空气法，将气体通入水中，形成氨水。再将制备好的氨水用棕色瓶装瓶即可。";
            JIANYAN.Text = "-";

            WEIHAI.Text = "吸入后对鼻、喉和肺有刺激性，引起咳嗽、气短和哮喘等；可因喉头水肿而窒息死亡；可发生肺水肿，引起死亡。氨水溅入眼内，可造成严重损害，甚至导致失明，皮肤接触可致灼伤。慢性影响：反复低浓度接触，可引起支气管炎。皮肤反复接触，可致皮炎，表现为皮肤干燥、痒、发红。如果身体皮肤有伤口一定要避免接触伤口以防感染。";
            FANGZHI.Text = "立即用水冲洗至少15分钟。若有灼伤，就医治疗。对少量皮肤接触，避免将物质播散面积扩大。注意患者保暖并且保持安静。";

            RICHANGYONGTU.Text = "氨水是实验室重要的试剂，主要用作分析试剂，中和剂,生物碱浸出剂，铝盐合成和弱碱性溶剂。用于铝盐合成和某些元素(如铜、镍)的检定和测定,用以沉淀出各种元素的氢氧化物。";
            GONGYEYONGTU.Text = "毛纺、丝绸、印染等工业用于洗涤羊毛、呢绒、坯布，溶解和调整酸碱度，并作为助染剂等。 有机工业用作胺化剂，生产热固性酚醛树脂的催化剂，无机工业用于制选各种铁盐。";
        }

        private void B6_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            YINGWENMING.Text = "magnesium dihydroxide";
            FENZILIANG.Text = "58.31970";

            XINGZHUANG.Text = "粉末";
            YANSE.Text = "白色";
            QIWEI.Text = "无臭";
            FEIDIAN.Text = "100ºC";
            RONGDIAN.Text = "350ºC";
            RONGJIEXING.Text = "-";

            KERANXING.Text = "-";
            WENDINGXING.Text = "加热至623K（350℃）即脱水分解；在高于350℃时分解为氧化镁和水；在1800℃以上完全脱水";
            SUANXING.Text = "-";
            JIANXING.Text = "是";
            YANGHUAXING.Text = "-";
            HUANYUANXING.Text = "-";

            ZHIQU.Text = "工业上常以海水与廉价的氢氧化钙溶液（石灰乳）反应，可得氢氧化镁沉淀";
            JIANYAN.Text = "-";

            WEIHAI.Text = "氢氧化镁难溶于水，属于较弱的碱，但对眼睛，呼吸系统和皮肤均略有刺激性。故使用时应做适当防护，佩戴手套或护目镜，不慎与眼睛接触后，请立即用大量清水冲洗并就医。腐蚀性基本没有。";
            FANGZHI.Text = "吸入: 如果吸入，请将患者移到新鲜空气处。" + System.Environment.NewLine + "皮肤接触: 脱去污染的衣着，用肥皂水和清水彻底冲洗皮肤。如有不适感，就医。" + System.Environment.NewLine + "眼晴接触: 分开眼睑，用流动清水或生理盐水冲洗。立即就医。" + System.Environment.NewLine + "食入: 漱口，禁止催吐。立即就医。";

            RICHANGYONGTU.Text = "-";
            GONGYEYONGTU.Text = "阻燃剂、镁盐的制造、砂糖的精制、制药工业、日用化工";
        }

        private void B7_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            YINGWENMING.Text = "Copper hydroxide";
            FENZILIANG.Text = "97.5";

            XINGZHUANG.Text = "粉末或晶体";
            YANSE.Text = "蓝色";
            QIWEI.Text = "-";
            FEIDIAN.Text = "100";
            RONGDIAN.Text = "200";
            RONGJIEXING.Text = "难溶于水";

            KERANXING.Text = "-";
            WENDINGXING.Text = "不稳定，受热易分解为氧化铜和水";
            SUANXING.Text = "-";
            JIANXING.Text = "是";
            YANGHUAXING.Text = "-";
            HUANYUANXING.Text = "-";

            ZHIQU.Text = "使用硫酸铜溶液与氢氧化钠溶液混合过滤制取硫酸钠和氢氧化铜";
            JIANYAN.Text = "-";

            WEIHAI.Text = "-";
            FANGZHI.Text = "-";

            RICHANGYONGTU.Text = "-";
            GONGYEYONGTU.Text = "用于媒染剂、催化剂、杀菌剂和颜料，并用于染纸张等、用作分析试剂、媒染剂；制铜盐的原料、媒染剂、人造丝、颜料、制着色纸、用作杀菌剂、船底防污漆的组分。";
        }

        private void B8_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            YINGWENMING.Text = "Barium hydroxide";
            FENZILIANG.Text = "171.35";

            XINGZHUANG.Text = "粉末";
            YANSE.Text = "白色";
            QIWEI.Text = "-";
            FEIDIAN.Text = "780℃";
            RONGDIAN.Text = "78℃";
            RONGJIEXING.Text = "可溶";

            KERANXING.Text = "-";
            WENDINGXING.Text = "-";
            SUANXING.Text = "-";
            JIANXING.Text = "是";
            YANGHUAXING.Text = "-";
            HUANYUANXING.Text = "-";

            ZHIQU.Text = "-";
            JIANYAN.Text = "-";

            WEIHAI.Text = "健康危害：口服后急性中毒表现为恶心、呕吐、腹痛、腹泻、脉缓、进行性肌麻痹、心律紊乱、血钾明显降低等。可因心律紊乱和呼吸肌麻痹而死亡。吸入烟尘可引起中毒，但消化道症状不明显。接触高温本品溶液造成皮肤灼伤可同时吸收中毒。";
            FANGZHI.Text = "-";

            RICHANGYONGTU.Text = "-";
            GONGYEYONGTU.Text = "用作合成酚醛树脂的催化剂，缩聚反应易控制，制得的树脂黏度低，固化速度快，催化剂易除去。参考用量为苯酚的1%～1.5%。也用作水溶性尿素改性苯酚一甲醛胶黏剂的催化剂，固化产物为淡黄色，残存在树脂中的二价钡盐不影响介电性和化学稳定性。 " + System.Environment.NewLine + "用作分析试剂，也用于分离沉淀硫酸根和制造钡盐，测定空气中的二氧化碳。叶绿素的定量。糖及动植物油的精制。锅炉用水清洁剂。杀虫剂。橡胶工业";
        }

        private void B9_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            YINGWENMING.Text = "aluminium hydroxide";
            FENZILIANG.Text = "78.00360";

            XINGZHUANG.Text = "非晶形的粉末";
            YANSE.Text = "白色";
            QIWEI.Text = "-";
            FEIDIAN.Text = "-";
            RONGDIAN.Text = "300℃";
            RONGJIEXING.Text = "难溶";

            KERANXING.Text = "-";
            WENDINGXING.Text = "";
            SUANXING.Text = "是";
            JIANXING.Text = "是";
            YANGHUAXING.Text = "-";
            HUANYUANXING.Text = "-";

            ZHIQU.Text = "将硫酸和铝粉或铝灰作用生成硫酸铝，再与碳酸氢铵进行复分解反应，制得氢氧化铝。或者以铝酸钠溶液与硫酸铝溶液中和至pH6.5，生成氢氧化铝沉淀，经水洗、压滤，于70～80℃下干燥，再经粉碎，制得氢氧化铝。";
            JIANYAN.Text = "-";

            WEIHAI.Text = "代谢/内分泌系统：氢氧化化铝可与肠内的磷酸盐离子结合，形成不溶性磷酸铝，后者不被胃肠道吸收，从而导致血清内磷酸盐浓度下降，而钙的含量上升，造成钙、磷代谢异常，影响骨质形成。长期大量服用，可导致低磷血症、骨质疏松和骨软化症等。";
            FANGZHI.Text = "-";

            RICHANGYONGTU.Text = "常用于治疗胃酸过多";
            GONGYEYONGTU.Text = "氢氧化铝是用量最大和应用最广的无机阻燃添加剂。氢氧化铝作为阻燃剂不仅能阻燃，而且可以防止发烟、不产生滴下物、不产生有毒气体，因此，获得较广泛的应用，使用量也在逐年增加。使用范围：热固性塑料、热塑性塑料、合成橡胶、涂料及建材等行业。同时，氢氧化铝也是电解铝行业所必需氟化铝的基础原料，在该行业氢氧化铝也是得到非常广泛应用。";
        }

        private void B10_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            YINGWENMING.Text = "ferric hydroxide";
            FENZILIANG.Text = "106.867";

            XINGZHUANG.Text = "粉末或絮状沉淀";
            YANSE.Text = "棕色或红褐色";
            QIWEI.Text = "-";
            FEIDIAN.Text = "-";
            RONGDIAN.Text = "757℃";
            RONGJIEXING.Text = "难溶于水";

            KERANXING.Text = "-";
            WENDINGXING.Text = "-";
            SUANXING.Text = "-";
            JIANXING.Text = "是";
            YANGHUAXING.Text = "-";
            HUANYUANXING.Text = "-";

            ZHIQU.Text = "（1）取一个小烧杯，加入25 mL蒸馏水，将烧杯中的蒸馏水加热至沸腾。 " + System.Environment.NewLine + "（2）向沸水中逐滴加入5 ~ 6滴饱和氯化铁溶液。 " + System.Environment.NewLine + "（3）继续煮沸至溶液呈红褐色，停止加热。";
            JIANYAN.Text = "-";

            WEIHAI.Text = "-";
            FANGZHI.Text = "-";

            RICHANGYONGTU.Text = "其胶体可用于净水。";
            GONGYEYONGTU.Text = "用于制造医药、颜料，并用作砷解毒剂等。";
        }


        private void C1_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            YINGWENMING.Text = "Zinc sulphate";
            FENZILIANG.Text = "161.45";

            XINGZHUANG.Text = "斜方晶体或粉末";
            YANSE.Text = "无色或白色";
            QIWEI.Text = "无气味";
            FEIDIAN.Text = " >500(分解)";
            RONGDIAN.Text = "100°C";
            RONGJIEXING.Text = "易溶于水";

            KERANXING.Text = "-";
            WENDINGXING.Text = " >500(分解)";
            SUANXING.Text = "是";
            JIANXING.Text = "-";
            YANGHUAXING.Text = "-";
            HUANYUANXING.Text = "-";

            ZHIQU.Text = "将氧化锌加入稀硫酸溶液调成浆状，待反应完全后，经过滤，加入锌粉把铜、镉、镍等置换出来，过滤，滤液加热，加入高锰酸钾，将铁、锰等杂质氧化，过滤后，澄清，浓缩，冷却结晶，离心分离，干燥制得。亦可用硫酸浸取焙烧的锌矿粉制得。";
            JIANYAN.Text = "-";

            WEIHAI.Text = "该品对眼有中等度刺激性，对皮肤无刺激性。误服可引起恶心、呕吐、腹痛、腹泻等急性胃肠炎症状，严重时发生脱水、休克，甚至可致死亡。";
            FANGZHI.Text = "1皮肤接触：立即脱去污染的衣着，用大量流动清水冲洗至少15分钟，可涂抹弱碱性物质（如碱水、肥皂水等），就医。" + System.Environment.NewLine + "2眼睛接触： 立即提起眼睑，用大量流动清水或生理盐水彻底冲洗至少15分钟。就医。" + System.Environment.NewLine + "3吸入：迅速脱离现场至空气新鲜处。保持呼吸道通畅。如呼吸困难，给输氧。如呼吸停止，立即进行人工呼吸。就医。" + System.Environment.NewLine + "4食入：用大量水漱口，吞服大量生鸡蛋清或牛奶（禁止服用小苏打等药品），就医。";

            RICHANGYONGTU.Text = "催吐剂 " + System.Environment.NewLine + "防止果树苗圃的病害，也是一种补充作物锌微量元素肥的常用肥料，可做基肥，叶面肥等";
            GONGYEYONGTU.Text = "制造锌钡白和锌盐的主要原料，也可用作印染媒染剂，木材和皮革的保存剂，也是生产粘胶纤维和维尼纶纤维的重要辅助原料。另外，在电镀和电解工业中也有应用，还可以用于制造电缆。 " + System.Environment.NewLine + "工业中冷却用水是最大用量水。在密闭式循环冷却系统中的冷却水对金属不能有腐蚀和结垢，因此要进行处理，这个过程就叫水质稳定，硫酸锌在此用作水质稳定剂。";
        }

        private void C2_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            YINGWENMING.Text = "Sodium Carbonate";
            FENZILIANG.Text = "105.99";

            XINGZHUANG.Text = "碳酸钠常温下为粉末或颗粒。有吸水性，露置空气中逐渐吸收 1mol/L水分(约=15%)。";
            YANSE.Text = "白色";
            QIWEI.Text = "无味";
            FEIDIAN.Text = "1600℃";
            RONGDIAN.Text = "851℃";
            RONGJIEXING.Text = "微溶于无水乙醇，难溶于丙醇";

            KERANXING.Text = "否";
            WENDINGXING.Text = "分解温度 744℃";
            SUANXING.Text = "-";
            JIANXING.Text = "是";
            YANGHUAXING.Text = "-";
            HUANYUANXING.Text = "-";

            ZHIQU.Text = "第一步，氨气与水和二氧化碳反应生成一分子的碳酸氢铵，第二步碳酸氢铵与氯化钠反应生成的碳酸氢钠沉淀和氯化铵，碳酸氢钠之所以沉淀是因为它的溶解度较小。经过滤得到碳酸氢钠固体。（这两步和上面的索氏制碱法相同）。第三步，合成的碳酸氢钠部分可以直接出厂销售，其余的碳酸氢钠会被加热分解，生成碳酸钠，生成的二氧化碳可以重新回到第一步循环利用。";
            JIANYAN.Text = "-";

            WEIHAI.Text = "刺激性高";
            FANGZHI.Text = "1皮肤接触：立即脱去污染的衣着，用大量流动清水冲洗至少15分钟，可涂抹弱碱性物质（如碱水、肥皂水等），就医。" + System.Environment.NewLine + "2眼睛接触： 立即提起眼睑，用大量流动清水或生理盐水彻底冲洗至少15分钟。就医。" + System.Environment.NewLine + "3吸入：迅速脱离现场至空气新鲜处。保持呼吸道通畅。如呼吸困难，给输氧。如呼吸停止，立即进行人工呼吸。就医。" + System.Environment.NewLine + "4食入：用大量水漱口，吞服大量生鸡蛋清或牛奶（禁止服用小苏打等药品），就医。";

            RICHANGYONGTU.Text = "作缓冲剂、中和剂和面团改良剂，可用于糕点和面制食品";
            GONGYEYONGTU.Text = "碳酸钠是重要的化工原料之一，广泛应用于轻工日化、建材、化学工业、食品工业、冶金、纺织、石油、国防、医药等领域， 用作制造其他化学品的原料、清洗剂、洗涤剂，也用于照相术和分析领域。其次是冶金、纺织、石油、国防、医药及其它工业。玻璃工业是纯碱的最大消费部门，每吨玻璃消耗纯碱0.2吨。在工业用纯碱中,主要是轻工、建材、化学工业,约占2/3:其次是冶金、纺织、石油、国防、医药及其他工业。";
        }

        private void C3_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            YINGWENMING.Text = "cupric sulfate";
            FENZILIANG.Text = "159.61";

            XINGZHUANG.Text = "结晶";
            YANSE.Text = "白色或灰白色";
            QIWEI.Text = "-";
            FEIDIAN.Text = "-";
            RONGDIAN.Text = "560℃";
            RONGJIEXING.Text = "溶于水、甲醇。不溶于乙醇";

            KERANXING.Text = "-";
            WENDINGXING.Text = "易吸水变蓝绿色的五水合硫酸铜";
            SUANXING.Text = "是";
            JIANXING.Text = "-";
            YANGHUAXING.Text = "-";
            HUANYUANXING.Text = "-";

            ZHIQU.Text = "采用低品位氧化铜矿，粉碎至一定粒度，加入硫酸浸渍，加入溶铜沉铁剂，获得铜铁比大于100的硫酸铜溶液，然后加入化学浓缩剂进行浓缩，排走70%～90%的水分，最后经蒸发、冷却结晶、分离、风干，制得硫酸铜成品";
            JIANYAN.Text = "重量法；铬酸钡光度法；铬酸钡间接原子吸收法；EDTA滴定法";

            WEIHAI.Text = "对胃肠道有刺激作用，误服引起恶心、呕吐、口内有铜性味、胃烧灼感。严重者有腹绞痛、呕血、黑便。可造成严重肾损害和溶血，出现黄疸、贫血、肝大、血红蛋白尿、急性肾功能衰竭和尿毒症。对眼和皮肤有刺激性。长期接触可发生接触性皮炎和鼻、眼粘膜刺激并出现胃肠道症状。";
            FANGZHI.Text = "1皮肤接触：立即脱去污染的衣着，用大量流动清水冲洗至少15分钟，可涂抹弱碱性物质（如碱水、肥皂水等），就医。" + System.Environment.NewLine + "2眼睛接触： 立即提起眼睑，用大量流动清水或生理盐水彻底冲洗至少15分钟。就医。" + System.Environment.NewLine + "3吸入：迅速脱离现场至空气新鲜处。保持呼吸道通畅。如呼吸困难，给输氧。如呼吸停止，立即进行人工呼吸。就医。" + System.Environment.NewLine + "4食入：用大量水漱口，吞服大量生鸡蛋清或牛奶（禁止服用小苏打等药品），就医。";

            RICHANGYONGTU.Text = "化学教育";
            GONGYEYONGTU.Text = "分析试剂；食品级螯合剂和澄清剂；用于制造其他铜盐如氯化亚铜、氯化铜、焦磷酸铜、氧化亚铜、醋酸铜、碳酸铜，铜单偶氮染料如活性艳蓝、活性紫等；与石灰水混合后生成波尔多液，作为杀菌剂；医疗领域用作催吐剂";
        }

        private void C4_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            YINGWENMING.Text = "Sodium Bicarbonate";
            FENZILIANG.Text = "84.01";

            XINGZHUANG.Text = "单斜晶结晶性粉末";
            YANSE.Text = "白色";
            QIWEI.Text = "无臭";
            FEIDIAN.Text = "-";
            RONGDIAN.Text = "270℃";
            RONGJIEXING.Text = "可溶于水，微溶于乙醇";

            KERANXING.Text = "-";
            WENDINGXING.Text = "25℃时溶于10份水，约18℃时溶于12份水。其水溶液因水解而呈微碱性，常温中性质稳定，受热易分解，在50℃以上逐渐分解，在270℃时完全失去二氧化碳，在干燥空气中无变化，在潮湿空气中缓慢潮解。";
            SUANXING.Text = "-";
            JIANXING.Text = "是";
            YANGHUAXING.Text = "-";
            HUANYUANXING.Text = "-";

            ZHIQU.Text = "将碳酸钠溶液，在碳酸钠中通过二氧化碳碳化后，再经分离干燥，即得成品 ";
            JIANYAN.Text = "-";

            WEIHAI.Text = "碳酸氢钠在常温下是接近中性的极微弱的碱， 如将其固体或水溶液加热50℃以上时，可转变为碳酸钠，对人具有刺激性和腐蚀性，对眼睛、皮肤及呼吸道粘膜有刺激性，引起炎症。";
            FANGZHI.Text = "1皮肤接触：立即脱去污染的衣着，用大量流动清水冲洗至少15分钟，可涂抹弱碱性物质（如碱水、肥皂水等），就医。" + System.Environment.NewLine + "2眼睛接触： 立即提起眼睑，用大量流动清水或生理盐水彻底冲洗至少15分钟。就医。" + System.Environment.NewLine + "3吸入：迅速脱离现场至空气新鲜处。保持呼吸道通畅。如呼吸困难，给输氧。如呼吸停止，立即进行人工呼吸。就医。" + System.Environment.NewLine + "4食入：用大量水漱口，吞服大量生鸡蛋清或牛奶（禁止服用小苏打等药品），就医。";

            RICHANGYONGTU.Text = "在大批量生产馒头、油条等食品时，常把苏打粉融水拌入面中，热后分解成碳酸钠、二氧化碳和水，二氧化碳和水蒸气溢出，可致食品更加蓬松，碳酸钠残留在食品中。馒头中添加过量的苏打粉是可以品尝出来的。" + System.Environment.NewLine + "将装有小苏打的盒子敞口放在冰箱里可以排除异味，也可以用小苏打兑温水，清洗冰箱内部。在垃圾桶或其他任何可能发出异味的地方洒一些小苏打，会起到很好的除臭效果。";
            GONGYEYONGTU.Text = "碳酸氢钠同时也是我国著名科学家侯德榜先生所采用的制造纯碱的原材料之一，我国仍有近30%的纯碱通过碳酸氢钠受热分解制得。";
        }

        private void C5_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            YINGWENMING.Text = "Barium Sulfate";
            FENZILIANG.Text = "233.39000";

            XINGZHUANG.Text = "粉末";
            YANSE.Text = "白色";
            QIWEI.Text = "无味";
            FEIDIAN.Text = "330ºC";
            RONGDIAN.Text = "1580ºC";
            RONGJIEXING.Text = "溶于热浓硫酸，几乎不溶于水、稀酸、醇。水悬浮溶液";

            KERANXING.Text = "-";
            WENDINGXING.Text = "分解温度：>1600℃";
            SUANXING.Text = "否";
            JIANXING.Text = "否";
            YANGHUAXING.Text = "-";
            HUANYUANXING.Text = "-";

            ZHIQU.Text = "-";
            JIANYAN.Text = "-";

            WEIHAI.Text = "-";
            FANGZHI.Text = "生产中应注意做好防护，不可直接与人体接触";

            RICHANGYONGTU.Text = "食道，胃，十二指肠，小肠，结肠的造影检查";
            GONGYEYONGTU.Text = "-";
        }

        private void C6_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            YINGWENMING.Text = "Calcium carbonate";
            FENZILIANG.Text = "100.09";

            XINGZHUANG.Text = "固体";
            YANSE.Text = "白色";
            QIWEI.Text = "无味";
            FEIDIAN.Text = "-";
            RONGDIAN.Text = "1339℃";
            RONGJIEXING.Text = "不溶于水";

            KERANXING.Text = "-";
            WENDINGXING.Text = "825～896.6℃分解，在约825℃时分解为氧化钙和二氧化碳";
            SUANXING.Text = "-";
            JIANXING.Text = "是";
            YANGHUAXING.Text = "-";
            HUANYUANXING.Text = "-";

            ZHIQU.Text = "纳米活性碳酸钙的工业制备方法。该方法在一定浓度的Ca(OH)2的悬浮液中通入二氧化碳气体进行碳化。通过对Ca(OH)2悬浮液的温度、二氧化碳气体的流量控制碳酸钙晶核的成核速率；在碳化至形成一定的晶核数后，由晶核形成控制转化为晶体生长控制，此时加入晶形调节剂控制各晶面的生长速率，从而达到形貌可控；继续碳化至终点加入分散剂调节粒子表面电荷得均分散的立方形碳酸钙纳米颗粒；然后将均分散的立方形纳米碳酸钙颗粒进行液相表面包覆处理。所获得的纳米活性碳酸钙粒子在25～100nm之间可控，立方形，比表面大于25m2/g，粒径分布 GSD为1.57，吸油值小于28g/100gCaCO3，且无团聚现象。所获得的产品性能优异，可作为高档橡胶、塑料以及汽车底漆中的功能填料。";
            JIANYAN.Text = "-";

            WEIHAI.Text = "从事开采加工的工人常出现上呼吸道炎症、支气管炎，可伴有肺气肿。X线胸片上出现淋巴结钙化，肺纹理增强。 作业工人患尘肺主要与本品中所含有二氧化硅杂质有关。";
            FANGZHI.Text = "-";

            RICHANGYONGTU.Text = "在实验室可以用来制取二氧化碳";
            GONGYEYONGTU.Text = "食品工业中可作为添加剂使用；可作补钙剂";
        }

        private void C7_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            YINGWENMING.Text = "Potassium Permanganate";
            FENZILIANG.Text = "158.034";

            XINGZHUANG.Text = "细长斜方柱状结晶";
            YANSE.Text = "深紫色";
            QIWEI.Text = "-";
            FEIDIAN.Text = "-";
            RONGDIAN.Text = "240℃";
            RONGJIEXING.Text = "溶于水、碱液，微溶于甲醇、丙酮、硫酸";

            KERANXING.Text = "-";
            WENDINGXING.Text = "稳定，但接触易燃材料可能引起火灾。要避免的物质包括还原剂、强酸、有机材料、易燃材料、过氧化物、醇类和化学活性金属。";
            SUANXING.Text = "-";
            JIANXING.Text = "是";
            YANGHUAXING.Text = "是";
            HUANYUANXING.Text = "-";

            ZHIQU.Text = "矿石中取得的二氧化锰和氢氧化钾在空气中或混合硝酸钾（提供氧气）加热，产生锰酸钾，再于碱性溶液中与氧化剂进行电解化得到高锰酸钾。";
            JIANYAN.Text = "-";

            WEIHAI.Text = "高锰酸钾为氧化剂，用于有机合成、消毒、氧化等。与乙醚、乙醇、硫酸、硫磺、双氧水等接触会发生爆炸；遇甘油立即分解而强烈燃烧。";
            FANGZHI.Text = "-";

            RICHANGYONGTU.Text = "实验室加热高锰酸钾制取氧气；与浓盐酸反应制取氯气；在酸性条件下与草酸反应生成二氧化碳";
            GONGYEYONGTU.Text = "在化学品生产中，广泛用作氧化剂，如用作制糖精、维生素C、异烟肼及安息香酸的氧化剂；医药中用作防腐剂、消毒剂、除臭剂及解毒剂；在水质净化及废水处理中，作水处理剂，以氧化硫化氢、酚、铁、锰和有机、无机等多种污染物，控制臭味和脱色。还用作漂白剂、吸附剂、着色剂及消毒剂等。";
        }

        private void C8_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            YINGWENMING.Text = "magnesium sulphate";
            FENZILIANG.Text = "120.3687";

            XINGZHUANG.Text = "结晶状固体";
            YANSE.Text = "白色";
            QIWEI.Text = "-";
            FEIDIAN.Text = "-";
            RONGDIAN.Text = "1124℃";
            RONGJIEXING.Text = "易溶于水，微溶于乙醇、甘油、乙醚，不溶于丙酮";

            KERANXING.Text = "-";
            WENDINGXING.Text = "无水硫酸镁易吸水，七水硫酸镁易脱水";
            SUANXING.Text = "是";
            JIANXING.Text = "-";
            YANGHUAXING.Text = "-";
            HUANYUANXING.Text = "-";

            ZHIQU.Text = "以氧化镁、氢氧化镁、碳酸镁、菱苦土等为原料加硫酸分解或中和而得。也有以生产氯化钾副产为原料，与制溴后含镁母液按比例混合，冷却结晶分离得粗硫酸镁，再加热过滤、除杂、冷却结晶得工业硫酸镁。还可用苦卤加热浓缩、结晶分离而得或氧化镁及石膏水悬浮液碳化制得。";
            JIANYAN.Text = "-";

            WEIHAI.Text = "本品粉尘对粘膜有刺激作用，长期接触可引起呼吸道炎症。误服有导泻作用，若有肾功能障碍者可致镁中毒，引起胃痛、呕吐、水泻、虚脱、呼吸困难、紫绀等。";
            FANGZHI.Text = "1皮肤接触：立即脱去污染的衣着，用大量流动清水冲洗至少15分钟，可涂抹弱碱性物质（如碱水、肥皂水等），就医。" + System.Environment.NewLine + "2眼睛接触： 立即提起眼睑，用大量流动清水或生理盐水彻底冲洗至少15分钟。就医。" + System.Environment.NewLine + "3吸入：迅速脱离现场至空气新鲜处。保持呼吸道通畅。如呼吸困难，给输氧。如呼吸停止，立即进行人工呼吸。就医。" + System.Environment.NewLine + "4食入：用大量水漱口，吞服大量生鸡蛋清或牛奶（禁止服用小苏打等药品），就医。";

            RICHANGYONGTU.Text = "饲料级硫酸镁作为饲料加工中镁的补充剂";
            GONGYEYONGTU.Text = "硫酸镁溶于水后可与轻烧粉反应形成硫氧镁水泥。硫氧镁水泥具有较好的防火性、保温性、耐久性和环保性，应用在防火门芯板、外墙保温板、硅质改性保温板、防火板等诸多领域 " + System.Environment.NewLine + "用于制革、炸药、肥料、造纸、瓷器、印染料、铅酸蓄电池等工业。硫酸镁和其他钾、钙、氨基酸盐、硅酸盐等矿物质一样，可以用作浴盐。";
        }

        private void C9_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            YINGWENMING.Text = "Calcium bicarbonate";
            FENZILIANG.Text = "162.06";

            XINGZHUANG.Text = "固体";
            YANSE.Text = "白色";
            QIWEI.Text = "-";
            FEIDIAN.Text = "-";
            RONGDIAN.Text = "-";
            RONGJIEXING.Text = "易溶";

            KERANXING.Text = "-";
            WENDINGXING.Text = "碳酸氢钙在0摄氏度以下比较稳定；常温下易分解，得到碳酸钙固体";
            SUANXING.Text = "-";
            JIANXING.Text = "-";
            YANGHUAXING.Text = "-";
            HUANYUANXING.Text = "-";

            ZHIQU.Text = "-";
            JIANYAN.Text = "-";

            WEIHAI.Text = "-";
            FANGZHI.Text = "-";

            RICHANGYONGTU.Text = "-";
            GONGYEYONGTU.Text = "碳酸氢钙可用作钙强化剂、乳化稳定剂、面团调理剂、营养增补剂、缓冲剂、疏松剂、面用改良剂营养增补剂、酵母食料、乳化剂、固化剂、抗氧化增效剂、稳定剂。";
        }

        private void C10_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            YINGWENMING.Text = "Sodium bisulfate";
            FENZILIANG.Text = "120";

            XINGZHUANG.Text = "颗粒,晶体或粉末";
            YANSE.Text = "灰白色";
            QIWEI.Text = "-";
            FEIDIAN.Text = "330ºC";
            RONGDIAN.Text = "：315 °C";
            RONGJIEXING.Text = "溶于水，不溶于液氨";

            KERANXING.Text = "-";
            WENDINGXING.Text = "避免与水，次氯酸盐接触。易溶于水，但不易潮解，加热时缩聚为焦硫酸钠";
            SUANXING.Text = "是";
            JIANXING.Text = "-";
            YANGHUAXING.Text = "-";
            HUANYUANXING.Text = "-";

            ZHIQU.Text = "硫酸氢钠可通过两种方法获得。混合等物质的量的氢氧化钠和硫酸，可以得到硫酸氢钠和水；氯化钠（食盐）和硫酸可在常温下反应，生成硫酸氢钠和氯化氢气体";
            JIANYAN.Text = "-";

            WEIHAI.Text = "对眼睛、皮肤、粘膜和上呼吸道具强烈刺激作用和腐蚀性。";
            FANGZHI.Text = "不慎与眼睛接触后，请立即用大量清水冲洗并征求医生意见";

            RICHANGYONGTU.Text = "家用清洁剂（45%溶液）； 降低游泳池水的碱度； 宠物食品";
            GONGYEYONGTU.Text = "测定溴、碘、铜和二氧化钛。矿物分析。";
        }


    }
}
