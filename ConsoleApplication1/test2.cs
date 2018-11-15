using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class test2
    {
    }
}


namespace QuickType
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Welcome
    {
        [JsonProperty("appId")]
        public string AppId { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("siteKey")]
        public string SiteKey { get; set; }

        [JsonProperty("product")]
        public string Product { get; set; }

        [JsonProperty("customerId")]
        public string CustomerId { get; set; }

        [JsonProperty("questionnaire")]
        public Questionnaire Questionnaire { get; set; }

        [JsonProperty("questionnaireState")]
        public QuestionnaireState QuestionnaireState { get; set; }
    }

    public partial class Questionnaire
    {
        [JsonProperty("qCurrentPage")]
        public string QCurrentPage { get; set; }

        [JsonProperty("qDefaultBooleanAnswerDisplayValues")]
        public QDefaultBooleanAnswerDisplayValues QDefaultBooleanAnswerDisplayValues { get; set; }

        [JsonProperty("qDefaultValidationMessages")]
        public Dictionary<string, string> QDefaultValidationMessages { get; set; }

        [JsonProperty("Page1")]
        public Page1 Page1 { get; set; }

        [JsonProperty("Page2")]
        public Page2 Page2 { get; set; }

        [JsonProperty("Page4")]
        public Page4 Page4 { get; set; }

        [JsonProperty("Page6")]
        public Page6 Page6 { get; set; }

        [JsonProperty("Page8")]
        public Page8 Page8 { get; set; }

        [JsonProperty("Page9")]
        public Page9 Page9 { get; set; }

        [JsonProperty("Page10")]
        public Page10 Page10 { get; set; }

        [JsonProperty("Page12RX")]
        public Page12Rx Page12Rx { get; set; }

        [JsonProperty("Page14MIB")]
        public Page14Mib Page14Mib { get; set; }
    }

    public partial class Page1
    {
        [JsonProperty("qIndex")]
        public long QIndex { get; set; }

        [JsonProperty("GroupName")]
        public GroupName GroupName { get; set; }

        [JsonProperty("GroupDOB")]
        public GroupDob GroupDob { get; set; }

        [JsonProperty("GroupAddress")]
        public Group GroupAddress { get; set; }

        [JsonProperty("GroupCityState")]
        public GroupCityState GroupCityState { get; set; }
    }

    public partial class Group
    {
        [JsonProperty("qIndex")]
        public long QIndex { get; set; }

        [JsonProperty("qQuestionsLayout")]
        public string QQuestionsLayout { get; set; }

        [JsonProperty("qDescription")]
        public string QDescription { get; set; }

        [JsonProperty("qAddress", NullValueHandling = NullValueHandling.Ignore)]
        public TartuGecko QAddress { get; set; }

        [JsonProperty("qM3", NullValueHandling = NullValueHandling.Ignore)]
        public LivingstoneSouthernWhiteFacedOwl QM3 { get; set; }

        [JsonProperty("qDynamicQuestions", NullValueHandling = NullValueHandling.Ignore)]
        public object[] QDynamicQuestions { get; set; }

        [JsonProperty("qHonestyStatement", NullValueHandling = NullValueHandling.Ignore)]
        public TartuGecko QHonestyStatement { get; set; }
    }

    public partial class TartuGecko
    {
        [JsonProperty("qIndex")]
        public long QIndex { get; set; }

        [JsonProperty("qLabel")]
        public string QLabel { get; set; }

        [JsonProperty("qAnswerPresentation")]
        public PurpleQAnswerPresentation QAnswerPresentation { get; set; }

        [JsonProperty("qAnswer")]
        public QAAnswer QAnswer { get; set; }

        [JsonProperty("qQuestionType", NullValueHandling = NullValueHandling.Ignore)]
        public PurpleQQuestionType? QQuestionType { get; set; }

        [JsonProperty("qIsHidden", NullValueHandling = NullValueHandling.Ignore)]
        public bool? QIsHidden { get; set; }

        [JsonProperty("qDescription", NullValueHandling = NullValueHandling.Ignore)]
        public string QDescription { get; set; }

        [JsonProperty("qPresentationRules", NullValueHandling = NullValueHandling.Ignore)]
        public PurpleQPresentationRule[] QPresentationRules { get; set; }

        [JsonProperty("qSelectAnswerFromAllowedAnswers", NullValueHandling = NullValueHandling.Ignore)]
        public bool? QSelectAnswerFromAllowedAnswers { get; set; }

        [JsonProperty("qAllowedAnswers", NullValueHandling = NullValueHandling.Ignore)]
        public QAllowedAnswer[] QAllowedAnswers { get; set; }
    }

    public partial class QAllowedAnswer
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("displayValue", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayValue { get; set; }
    }

    public partial class QAAnswer
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public partial class PurpleQPresentationRule
    {
        [JsonProperty("condition")]
        public Condition[] Condition { get; set; }

        [JsonProperty("action")]
        public PurpleAction[] Action { get; set; }
    }

    public partial class PurpleAction
    {
        [JsonProperty("actionType")]
        public ActionType ActionType { get; set; }

        [JsonProperty("actionValue")]
        public ActionValue ActionValue { get; set; }
    }

    public partial class Condition
    {
        [JsonProperty("qOperator")]
        public QOperator QOperator { get; set; }

        [JsonProperty("itemAttribute")]
        public ItemAttribute ItemAttribute { get; set; }

        [JsonProperty("testValue")]
        public string TestValue { get; set; }

        [JsonProperty("itemName", NullValueHandling = NullValueHandling.Ignore)]
        public string ItemName { get; set; }

        [JsonProperty("testValues", NullValueHandling = NullValueHandling.Ignore)]
        public object[] TestValues { get; set; }
    }

    public partial class LivingstoneSouthernWhiteFacedOwl
    {
        [JsonProperty("qIndex")]
        public long QIndex { get; set; }

        [JsonProperty("qLabel")]
        public string QLabel { get; set; }

        [JsonProperty("qQuestionType")]
        public FluffyQQuestionType QQuestionType { get; set; }

        [JsonProperty("qAnswerPresentation")]
        public FluffyQAnswerPresentation QAnswerPresentation { get; set; }

        [JsonProperty("qAnswer")]
        public PurpleQAnswer QAnswer { get; set; }

        [JsonProperty("qValidations", NullValueHandling = NullValueHandling.Ignore)]
        public object[] QValidations { get; set; }

        [JsonProperty("qIsHidden", NullValueHandling = NullValueHandling.Ignore)]
        public bool? QIsHidden { get; set; }

        [JsonProperty("qDescription", NullValueHandling = NullValueHandling.Ignore)]
        public QDescription? QDescription { get; set; }

        [JsonProperty("qPresentationRules", NullValueHandling = NullValueHandling.Ignore)]
        public PurpleQPresentationRule[] QPresentationRules { get; set; }

        [JsonProperty("qSelectAnswerFromAllowedAnswers", NullValueHandling = NullValueHandling.Ignore)]
        public bool? QSelectAnswerFromAllowedAnswers { get; set; }

        [JsonProperty("qAllowedAnswers", NullValueHandling = NullValueHandling.Ignore)]
        public object[] QAllowedAnswers { get; set; }
    }

    public partial class PurpleQAnswer
    {
        [JsonProperty("value")]
        public bool Value { get; set; }
    }

    public partial class GroupCityState
    {
        [JsonProperty("qIndex")]
        public long QIndex { get; set; }

        [JsonProperty("qCity")]
        public TartuGecko QCity { get; set; }

        [JsonProperty("qState")]
        public TartuGecko QState { get; set; }

        [JsonProperty("qZipcode")]
        public TartuGecko QZipcode { get; set; }
    }

    public partial class GroupDob
    {
        [JsonProperty("qIndex")]
        public long QIndex { get; set; }

        [JsonProperty("qQuestionsLayout")]
        public string QQuestionsLayout { get; set; }

        [JsonProperty("qDOB")]
        public TartuGecko QDob { get; set; }
    }

    public partial class GroupName
    {
        [JsonProperty("qIndex")]
        public long QIndex { get; set; }

        [JsonProperty("qDescription")]
        public string QDescription { get; set; }

        [JsonProperty("qFirstName")]
        public TartuGecko QFirstName { get; set; }

        [JsonProperty("qMiddleName")]
        public TartuGecko QMiddleName { get; set; }

        [JsonProperty("qLastName")]
        public TartuGecko QLastName { get; set; }
    }

    public partial class Page10
    {
        [JsonProperty("qIndex")]
        public long QIndex { get; set; }

        [JsonProperty("GroupM3")]
        public Group GroupM3 { get; set; }

        [JsonProperty("GroupM5")]
        public GroupM5 GroupM5 { get; set; }
    }

    public partial class GroupM5
    {
        [JsonProperty("qIndex")]
        public long QIndex { get; set; }

        [JsonProperty("qDescription")]
        public string QDescription { get; set; }

        [JsonProperty("qQuestionsLayout")]
        public string QQuestionsLayout { get; set; }

        [JsonProperty("qM5")]
        public LivingstoneSouthernWhiteFacedOwl QM5 { get; set; }

        [JsonProperty("qM5a")]
        public ArakGroundhog QM5A { get; set; }

        [JsonProperty("qM5aType")]
        public BeijingPigeon QM5AType { get; set; }

        [JsonProperty("qM5aDepression1")]
        public HammerfestPonies QM5ADepression1 { get; set; }

        [JsonProperty("qM5aDepression2")]
        public ArakGroundhog QM5ADepression2 { get; set; }

        [JsonProperty("qM5aDepression3")]
        public ArakGroundhog QM5ADepression3 { get; set; }

        [JsonProperty("qM5aDepression4")]
        public BeijingPigeon QM5ADepression4 { get; set; }

        [JsonProperty("qM5aDepression5")]
        public ArakGroundhog QM5ADepression5 { get; set; }

        [JsonProperty("qM5aDepression6")]
        public HammerfestPonies QM5ADepression6 { get; set; }

        [JsonProperty("qM5aDepression7")]
        public ArakGroundhog QM5ADepression7 { get; set; }

        [JsonProperty("qM5aAnxiety1")]
        public HammerfestPonies QM5AAnxiety1 { get; set; }

        [JsonProperty("qM5aAnxiety2")]
        public ArakGroundhog QM5AAnxiety2 { get; set; }

        [JsonProperty("qM5aAnxiety3")]
        public ArakGroundhog QM5AAnxiety3 { get; set; }

        [JsonProperty("qM5aAnxiety4")]
        public BeijingPigeon QM5AAnxiety4 { get; set; }

        [JsonProperty("qM5aAnxiety5")]
        public ArakGroundhog QM5AAnxiety5 { get; set; }

        [JsonProperty("qM5aAnxiety6")]
        public HammerfestPonies QM5AAnxiety6 { get; set; }

        [JsonProperty("qM5aAnxiety7")]
        public ArakGroundhog QM5AAnxiety7 { get; set; }

        [JsonProperty("qM5aPtsd1")]
        public HammerfestPonies QM5APtsd1 { get; set; }

        [JsonProperty("qM5aPtsd2")]
        public ArakGroundhog QM5APtsd2 { get; set; }

        [JsonProperty("qM5aPtsd3")]
        public ArakGroundhog QM5APtsd3 { get; set; }

        [JsonProperty("qM5aPtsd4")]
        public BeijingPigeon QM5APtsd4 { get; set; }

        [JsonProperty("qM5aPtsd5")]
        public ArakGroundhog QM5APtsd5 { get; set; }

        [JsonProperty("qM5aPtsd6")]
        public HammerfestPonies QM5APtsd6 { get; set; }

        [JsonProperty("qM5aPtsd7")]
        public ArakGroundhog QM5APtsd7 { get; set; }

        [JsonProperty("qM5aBipolar1")]
        public HammerfestPonies QM5ABipolar1 { get; set; }

        [JsonProperty("qM5aBipolar2")]
        public ArakGroundhog QM5ABipolar2 { get; set; }

        [JsonProperty("qM5aBipolar3")]
        public ArakGroundhog QM5ABipolar3 { get; set; }

        [JsonProperty("qM5aBipolar4")]
        public BeijingPigeon QM5ABipolar4 { get; set; }

        [JsonProperty("qM5aBipolar5")]
        public ArakGroundhog QM5ABipolar5 { get; set; }

        [JsonProperty("qM5aBipolar6")]
        public HammerfestPonies QM5ABipolar6 { get; set; }

        [JsonProperty("qM5aBipolar7")]
        public ArakGroundhog QM5ABipolar7 { get; set; }

        [JsonProperty("qM5aSeizures1")]
        public HammerfestPonies QM5ASeizures1 { get; set; }

        [JsonProperty("qM5aSeizures2")]
        public ArakGroundhog QM5ASeizures2 { get; set; }

        [JsonProperty("qM5aSeizures3")]
        public HammerfestPonies QM5ASeizures3 { get; set; }

        [JsonProperty("qM5aSeizures4")]
        public HammerfestPonies QM5ASeizures4 { get; set; }

        [JsonProperty("qM5aSeizures5")]
        public HammerfestPonies QM5ASeizures5 { get; set; }

        [JsonProperty("qM5aSeizures6")]
        public BeijingPigeon QM5ASeizures6 { get; set; }

        [JsonProperty("qM5aPain1")]
        public ArakGroundhog QM5APain1 { get; set; }

        [JsonProperty("qM5aPain2")]
        public ArakGroundhog QM5APain2 { get; set; }

        [JsonProperty("qM5aPain3")]
        public BeijingPigeon QM5APain3 { get; set; }

        [JsonProperty("qM5aPain4")]
        public HammerfestPonies QM5APain4 { get; set; }

        [JsonProperty("qM5aPain5")]
        public ArakGroundhog QM5APain5 { get; set; }

        [JsonProperty("qM5aPain6")]
        public ArakGroundhog QM5APain6 { get; set; }

        [JsonProperty("qM5aPainHR")]
        public HammerfestPonies QM5APainHr { get; set; }

        [JsonProperty("qM5aHeadaches1")]
        public HammerfestPonies QM5AHeadaches1 { get; set; }

        [JsonProperty("qM5aHeadaches2")]
        public HammerfestPonies QM5AHeadaches2 { get; set; }

        [JsonProperty("qM5aHeadaches3")]
        public BeijingPigeon QM5AHeadaches3 { get; set; }

        [JsonProperty("qM5aHeadaches4")]
        public HammerfestPonies QM5AHeadaches4 { get; set; }

        [JsonProperty("qM5aHeadaches5")]
        public HammerfestPonies QM5AHeadaches5 { get; set; }

        [JsonProperty("qM5aHeadaches6")]
        public BeijingPigeon QM5AHeadaches6 { get; set; }

        [JsonProperty("qM5aOther1")]
        public HammerfestPonies QM5AOther1 { get; set; }

        [JsonProperty("qM5aOther2")]
        public HammerfestPonies QM5AOther2 { get; set; }

        [JsonProperty("qM5aOther3")]
        public HammerfestPonies QM5AOther3 { get; set; }

        [JsonProperty("qM5aOther4")]
        public HammerfestPonies QM5AOther4 { get; set; }

        [JsonProperty("qM5b")]
        public ArakGroundhog QM5B { get; set; }

        [JsonProperty("qM5bType")]
        public BeijingPigeon QM5BType { get; set; }

        [JsonProperty("qM5bChestpain1")]
        public HammerfestPonies QM5BChestpain1 { get; set; }

        [JsonProperty("qM5bChestpain2")]
        public ArakGroundhog QM5BChestpain2 { get; set; }

        [JsonProperty("qM5bChestpain3")]
        public HammerfestPonies QM5BChestpain3 { get; set; }

        [JsonProperty("qM5bChestpain4")]
        public ArakGroundhog QM5BChestpain4 { get; set; }

        [JsonProperty("qM5bChestpain5")]
        public ArakGroundhog QM5BChestpain5 { get; set; }

        [JsonProperty("qM5bChestpain6")]
        public BeijingPigeon QM5BChestpain6 { get; set; }

        [JsonProperty("qM5bChestpain7")]
        public ArakGroundhog QM5BChestpain7 { get; set; }

        [JsonProperty("qM5bBp0")]
        public ArakGroundhog QM5BBp0 { get; set; }

        [JsonProperty("qM5bBp1")]
        public ArakGroundhog QM5BBp1 { get; set; }

        [JsonProperty("qM5bBp2")]
        public HammerfestPonies QM5BBp2 { get; set; }

        [JsonProperty("qM5bBp2s")]
        public QM5BBp2D QM5BBp2S { get; set; }

        [JsonProperty("qM5bBp2d")]
        public QM5BBp2D QM5BBp2D { get; set; }

        [JsonProperty("qM5bBp2idk")]
        public ArakGroundhog QM5BBp2Idk { get; set; }

        [JsonProperty("qM5bBp3")]
        public BeijingPigeon QM5BBp3 { get; set; }

        [JsonProperty("qM5bHc1")]
        public HammerfestPonies QM5BHc1 { get; set; }

        [JsonProperty("qM5bHc2")]
        public BeijingPigeon QM5BHc2 { get; set; }

        [JsonProperty("qM5bHc3")]
        public HammerfestPonies QM5BHc3 { get; set; }

        [JsonProperty("qM5bHc4")]
        public HammerfestPonies QM5BHc4 { get; set; }

        [JsonProperty("qM5bHcHR")]
        public HammerfestPonies QM5BHcHr { get; set; }

        [JsonProperty("qM5bMurmur1")]
        public ArakGroundhog QM5BMurmur1 { get; set; }

        [JsonProperty("qM5bMurmur2")]
        public ArakGroundhog QM5BMurmur2 { get; set; }

        [JsonProperty("qM5bMurmur3")]
        public ArakGroundhog QM5BMurmur3 { get; set; }

        [JsonProperty("qM5bStroke1")]
        public ArakGroundhog QM5BStroke1 { get; set; }

        [JsonProperty("qM5bStroke2")]
        public HammerfestPonies QM5BStroke2 { get; set; }

        [JsonProperty("qM5bStroke3")]
        public ArakGroundhog QM5BStroke3 { get; set; }

        [JsonProperty("qM5bStroke4")]
        public HammerfestPonies QM5BStroke4 { get; set; }

        [JsonProperty("qM5bStrokeHR")]
        public HammerfestPonies QM5BStrokeHr { get; set; }

        [JsonProperty("qM5bOther1")]
        public HammerfestPonies QM5BOther1 { get; set; }

        [JsonProperty("qM5bOther2")]
        public HammerfestPonies QM5BOther2 { get; set; }

        [JsonProperty("qM5bOther3")]
        public HammerfestPonies QM5BOther3 { get; set; }

        [JsonProperty("qM5bOther4")]
        public ArakGroundhog QM5BOther4 { get; set; }

        [JsonProperty("qM5c")]
        public ArakGroundhog QM5C { get; set; }

        [JsonProperty("qM5c1")]
        public HammerfestPonies QM5C1 { get; set; }

        [JsonProperty("qM5c2")]
        public HammerfestPonies QM5C2 { get; set; }

        [JsonProperty("qM5c3")]
        public HammerfestPonies QM5C3 { get; set; }

        [JsonProperty("qM5c4")]
        public ArakGroundhog QM5C4 { get; set; }

        [JsonProperty("qM5c5")]
        public HammerfestPonies QM5C5 { get; set; }

        [JsonProperty("qM5c6")]
        public HammerfestPonies QM5C6 { get; set; }

        [JsonProperty("qM5c7")]
        public HammerfestPonies QM5C7 { get; set; }

        [JsonProperty("qM5d")]
        public ArakGroundhog QM5D { get; set; }

        [JsonProperty("qM5dType")]
        public BeijingPigeon QM5DType { get; set; }

        [JsonProperty("qM5dDiabetes1")]
        public HammerfestPonies QM5DDiabetes1 { get; set; }

        [JsonProperty("qM5dDiabetes2")]
        public TartuGecko QM5DDiabetes2 { get; set; }

        [JsonProperty("qM5dDiabetes3")]
        public LivingstoneSouthernWhiteFacedOwl QM5DDiabetes3 { get; set; }

        [JsonProperty("qM5dDiabetes4")]
        public HammerfestPonies QM5DDiabetes4 { get; set; }

        [JsonProperty("qM5dDiabetes5")]
        public HammerfestPonies QM5DDiabetes5 { get; set; }

        [JsonProperty("qM5dDiabetes6")]
        public LivingstoneSouthernWhiteFacedOwl QM5DDiabetes6 { get; set; }

        [JsonProperty("qM5dDiabetes7")]
        public LivingstoneSouthernWhiteFacedOwl QM5DDiabetes7 { get; set; }

        [JsonProperty("qM5dOtherEndocrine1")]
        public TartuGecko QM5DOtherEndocrine1 { get; set; }

        [JsonProperty("qM5dOtherEndocrine2")]
        public TartuGecko QM5DOtherEndocrine2 { get; set; }

        [JsonProperty("qM5dOtherEndocrine3")]
        public BeijingPigeon QM5DOtherEndocrine3 { get; set; }

        [JsonProperty("qM5dOtherEndocrine4")]
        public TartuGecko QM5DOtherEndocrine4 { get; set; }

        [JsonProperty("qM5dBladder1")]
        public HammerfestPonies QM5DBladder1 { get; set; }

        [JsonProperty("qM5dBladder2")]
        public HammerfestPonies QM5DBladder2 { get; set; }

        [JsonProperty("qM5dBladder3")]
        public BeijingPigeon QM5DBladder3 { get; set; }

        [JsonProperty("qM5dBladder4")]
        public HammerfestPonies QM5DBladder4 { get; set; }

        [JsonProperty("qM5dThyroid1")]
        public HammerfestPonies QM5DThyroid1 { get; set; }

        [JsonProperty("qM5dThyroid2")]
        public ArakGroundhog QM5DThyroid2 { get; set; }

        [JsonProperty("qM5dThyroid3")]
        public HammerfestPonies QM5DThyroid3 { get; set; }

        [JsonProperty("qM5dThyroid4")]
        public HammerfestPonies QM5DThyroid4 { get; set; }

        [JsonProperty("qM5dThyroid5")]
        public HammerfestPonies QM5DThyroid5 { get; set; }

        [JsonProperty("qM5dThyroid6")]
        public BeijingPigeon QM5DThyroid6 { get; set; }

        [JsonProperty("qM5dProstate1")]
        public HammerfestPonies QM5DProstate1 { get; set; }

        [JsonProperty("qM5dProstate2")]
        public HammerfestPonies QM5DProstate2 { get; set; }

        [JsonProperty("qM5dProstate3")]
        public HammerfestPonies QM5DProstate3 { get; set; }

        [JsonProperty("qM5dProstate4")]
        public HammerfestPonies QM5DProstate4 { get; set; }

        [JsonProperty("qM5dProstate5")]
        public ArakGroundhog QM5DProstate5 { get; set; }

        [JsonProperty("qM5dProstate6")]
        public ArakGroundhog QM5DProstate6 { get; set; }

        [JsonProperty("qM5dProstate7")]
        public ArakGroundhog QM5DProstate7 { get; set; }

        [JsonProperty("qM5dProstate8")]
        public HammerfestPonies QM5DProstate8 { get; set; }

        [JsonProperty("qM5dProstate9")]
        public HammerfestPonies QM5DProstate9 { get; set; }

        [JsonProperty("qM5dOtherReproductive1")]
        public HammerfestPonies QM5DOtherReproductive1 { get; set; }

        [JsonProperty("qM5dOtherReproductive2")]
        public HammerfestPonies QM5DOtherReproductive2 { get; set; }

        [JsonProperty("qM5dOtherReproductive3")]
        public HammerfestPonies QM5DOtherReproductive3 { get; set; }

        [JsonProperty("qM5dOtherReproductive4")]
        public HammerfestPonies QM5DOtherReproductive4 { get; set; }

        [JsonProperty("qM5e")]
        public LivingstoneSouthernWhiteFacedOwl QM5E { get; set; }

        [JsonProperty("qM5eType")]
        public BeijingPigeon QM5EType { get; set; }

        [JsonProperty("qM5eEmphysema1")]
        public TartuGecko QM5EEmphysema1 { get; set; }

        [JsonProperty("qM5eEmphysema2")]
        public HammerfestPonies QM5EEmphysema2 { get; set; }

        [JsonProperty("qM5eEmphysema3")]
        public LivingstoneSouthernWhiteFacedOwl QM5EEmphysema3 { get; set; }

        [JsonProperty("qM5eEmphysema4")]
        public HammerfestPonies QM5EEmphysema4 { get; set; }

        [JsonProperty("qM5eEmphysema5")]
        public LivingstoneSouthernWhiteFacedOwl QM5EEmphysema5 { get; set; }

        [JsonProperty("qM5eEmphysema6")]
        public LivingstoneSouthernWhiteFacedOwl QM5EEmphysema6 { get; set; }

        [JsonProperty("qM5eCopd1")]
        public HammerfestPonies QM5ECopd1 { get; set; }

        [JsonProperty("qM5eCopd2")]
        public HammerfestPonies QM5ECopd2 { get; set; }

        [JsonProperty("qM5eCopd3")]
        public LivingstoneSouthernWhiteFacedOwl QM5ECopd3 { get; set; }

        [JsonProperty("qM5eCopd4")]
        public HammerfestPonies QM5ECopd4 { get; set; }

        [JsonProperty("qM5eCopd5")]
        public LivingstoneSouthernWhiteFacedOwl QM5ECopd5 { get; set; }

        [JsonProperty("qM5eCopd6")]
        public LivingstoneSouthernWhiteFacedOwl QM5ECopd6 { get; set; }

        [JsonProperty("qM5eAsthma1")]
        public TartuGecko QM5EAsthma1 { get; set; }

        [JsonProperty("qM5eAsthma2")]
        public LivingstoneSouthernWhiteFacedOwl QM5EAsthma2 { get; set; }

        [JsonProperty("qM5eAsthma3")]
        public LivingstoneSouthernWhiteFacedOwl QM5EAsthma3 { get; set; }

        [JsonProperty("qM5eAsthma4")]
        public HammerfestPonies QM5EAsthma4 { get; set; }

        [JsonProperty("qM5eAsthma5")]
        public LivingstoneSouthernWhiteFacedOwl QM5EAsthma5 { get; set; }

        [JsonProperty("qM5eAsthma6")]
        public HammerfestPonies QM5EAsthma6 { get; set; }

        [JsonProperty("qM5eAsthma7")]
        public LivingstoneSouthernWhiteFacedOwl QM5EAsthma7 { get; set; }

        [JsonProperty("qM5eAsthma8")]
        public HammerfestPonies QM5EAsthma8 { get; set; }

        [JsonProperty("qM5eAsthmaHR")]
        public HammerfestPonies QM5EAsthmaHr { get; set; }

        [JsonProperty("qM5eSleepapnea1")]
        public LivingstoneSouthernWhiteFacedOwl QM5ESleepapnea1 { get; set; }

        [JsonProperty("qM5eSleepapnea2")]
        public TartuGecko QM5ESleepapnea2 { get; set; }

        [JsonProperty("qM5eSleepapnea3")]
        public LivingstoneSouthernWhiteFacedOwl QM5ESleepapnea3 { get; set; }

        [JsonProperty("qM5eSleepapnea4")]
        public HammerfestPonies QM5ESleepapnea4 { get; set; }

        [JsonProperty("qM5eSleepapnea5")]
        public LivingstoneSouthernWhiteFacedOwl QM5ESleepapnea5 { get; set; }

        [JsonProperty("qM5eSleepapnea6")]
        public LivingstoneSouthernWhiteFacedOwl QM5ESleepapnea6 { get; set; }

        [JsonProperty("qM5eSleepapnea7")]
        public ArakGroundhog QM5ESleepapnea7 { get; set; }

        [JsonProperty("qM5eSleepapnea8")]
        public ArakGroundhog QM5ESleepapnea8 { get; set; }

        [JsonProperty("qM5eOther1")]
        public BeijingPigeon QM5EOther1 { get; set; }

        [JsonProperty("qM5eOther2")]
        public HammerfestPonies QM5EOther2 { get; set; }

        [JsonProperty("qM5eOther3")]
        public TartuGecko QM5EOther3 { get; set; }

        [JsonProperty("qM5eOther4")]
        public TartuGecko QM5EOther4 { get; set; }

        [JsonProperty("qM5eOther5")]
        public LivingstoneSouthernWhiteFacedOwl QM5EOther5 { get; set; }

        [JsonProperty("qM5eOtherHR")]
        public TartuGecko QM5EOtherHr { get; set; }

        [JsonProperty("qM5f")]
        public ArakGroundhog QM5F { get; set; }

        [JsonProperty("qM5fType")]
        public BeijingPigeon QM5FType { get; set; }

        [JsonProperty("qM5fRa1")]
        public HammerfestPonies QM5FRa1 { get; set; }

        [JsonProperty("qM5fRa2")]
        public ArakGroundhog QM5FRa2 { get; set; }

        [JsonProperty("qM5fRa3")]
        public HammerfestPonies QM5FRa3 { get; set; }

        [JsonProperty("qM5fRa4")]
        public HammerfestPonies QM5FRa4 { get; set; }

        [JsonProperty("qM5fRa5")]
        public HammerfestPonies QM5FRa5 { get; set; }

        [JsonProperty("qM5fRa6")]
        public BeijingPigeon QM5FRa6 { get; set; }

        [JsonProperty("qM5fRa7")]
        public BeijingPigeon QM5FRa7 { get; set; }

        [JsonProperty("qM5fRa8")]
        public ArakGroundhog QM5FRa8 { get; set; }

        [JsonProperty("qM5fRa9")]
        public ArakGroundhog QM5FRa9 { get; set; }

        [JsonProperty("qM5fRa10")]
        public ArakGroundhog QM5FRa10 { get; set; }

        [JsonProperty("qM5fRa11")]
        public ArakGroundhog QM5FRa11 { get; set; }

        [JsonProperty("qM5fPsoriasis1")]
        public HammerfestPonies QM5FPsoriasis1 { get; set; }

        [JsonProperty("qM5fPsoriasis2")]
        public BeijingPigeon QM5FPsoriasis2 { get; set; }

        [JsonProperty("qM5fPsoriasis3")]
        public ArakGroundhog QM5FPsoriasis3 { get; set; }

        [JsonProperty("qM5fAutoimmune1")]
        public HammerfestPonies QM5FAutoimmune1 { get; set; }

        [JsonProperty("qM5fAutoimmune2")]
        public TartuGecko QM5FAutoimmune2 { get; set; }

        [JsonProperty("qM5fAutoimmune3")]
        public TartuGecko QM5FAutoimmune3 { get; set; }

        [JsonProperty("qM5fAutoimmune4")]
        public ArakGroundhog QM5FAutoimmune4 { get; set; }

        [JsonProperty("qM5fHepb1")]
        public HammerfestPonies QM5FHepb1 { get; set; }

        [JsonProperty("qM5fHepb2")]
        public ArakGroundhog QM5FHepb2 { get; set; }

        [JsonProperty("qM5fKidney1")]
        public HammerfestPonies QM5FKidney1 { get; set; }

        [JsonProperty("qM5fKidney2")]
        public HammerfestPonies QM5FKidney2 { get; set; }

        [JsonProperty("qM5fKidney3")]
        public HammerfestPonies QM5FKidney3 { get; set; }

        [JsonProperty("qM5fKidney4")]
        public ArakGroundhog QM5FKidney4 { get; set; }

        [JsonProperty("qM5fKidney5")]
        public ArakGroundhog QM5FKidney5 { get; set; }

        [JsonProperty("qM5fGerd1")]
        public HammerfestPonies QM5FGerd1 { get; set; }

        [JsonProperty("qM5fGerd2")]
        public HammerfestPonies QM5FGerd2 { get; set; }

        [JsonProperty("qM5fGerd3")]
        public BeijingPigeon QM5FGerd3 { get; set; }

        [JsonProperty("qM5fGerd4")]
        public ArakGroundhog QM5FGerd4 { get; set; }

        [JsonProperty("qM5fGerd5")]
        public BeijingPigeon QM5FGerd5 { get; set; }

        [JsonProperty("qM5fGerd6")]
        public ArakGroundhog QM5FGerd6 { get; set; }

        [JsonProperty("qM5fIbs1")]
        public HammerfestPonies QM5FIbs1 { get; set; }

        [JsonProperty("qM5fIbs2")]
        public BeijingPigeon QM5FIbs2 { get; set; }

        [JsonProperty("qM5fIbs3")]
        public HammerfestPonies QM5FIbs3 { get; set; }

        [JsonProperty("qM5fColitis1")]
        public TartuGecko QM5FColitis1 { get; set; }

        [JsonProperty("qM5fColitis2")]
        public BeijingPigeon QM5FColitis2 { get; set; }

        [JsonProperty("qM5fColitis3")]
        public HammerfestPonies QM5FColitis3 { get; set; }

        [JsonProperty("qM5fColitis4")]
        public ArakGroundhog QM5FColitis4 { get; set; }

        [JsonProperty("qM5fSpondylitis1")]
        public HammerfestPonies QM5FSpondylitis1 { get; set; }

        [JsonProperty("qM5fSpondylitis2")]
        public BeijingPigeon QM5FSpondylitis2 { get; set; }

        [JsonProperty("qM5fSpondylitis3")]
        public ArakGroundhog QM5FSpondylitis3 { get; set; }

        [JsonProperty("qM5fSpondylitis4")]
        public ArakGroundhog QM5FSpondylitis4 { get; set; }

        [JsonProperty("qM5fDigestive1")]
        public HammerfestPonies QM5FDigestive1 { get; set; }

        [JsonProperty("qM5fDigestive2")]
        public HammerfestPonies QM5FDigestive2 { get; set; }

        [JsonProperty("qM5fDigestive3")]
        public HammerfestPonies QM5FDigestive3 { get; set; }

        [JsonProperty("qM5fDigestive4")]
        public ArakGroundhog QM5FDigestive4 { get; set; }

        [JsonProperty("qM5fUrinary1")]
        public HammerfestPonies QM5FUrinary1 { get; set; }

        [JsonProperty("qM5fUrinary2")]
        public HammerfestPonies QM5FUrinary2 { get; set; }

        [JsonProperty("qM5fUrinary3")]
        public HammerfestPonies QM5FUrinary3 { get; set; }

        [JsonProperty("qM5fUrinary4")]
        public ArakGroundhog QM5FUrinary4 { get; set; }

        [JsonProperty("qM5fBone1")]
        public TartuGecko QM5FBone1 { get; set; }

        [JsonProperty("qM5fBone2")]
        public TartuGecko QM5FBone2 { get; set; }

        [JsonProperty("qM5fBone3")]
        public TartuGecko QM5FBone3 { get; set; }

        [JsonProperty("qM5fBone4")]
        public ArakGroundhog QM5FBone4 { get; set; }

        [JsonProperty("qM5fLupus1")]
        public HammerfestPonies QM5FLupus1 { get; set; }

        [JsonProperty("qM5fLupus2")]
        public ArakGroundhog QM5FLupus2 { get; set; }

        [JsonProperty("qM5fConnective1")]
        public HammerfestPonies QM5FConnective1 { get; set; }

        [JsonProperty("qM5fConnective2")]
        public HammerfestPonies QM5FConnective2 { get; set; }

        [JsonProperty("qM5fConnective3")]
        public HammerfestPonies QM5FConnective3 { get; set; }

        [JsonProperty("qM5fConnective4")]
        public ArakGroundhog QM5FConnective4 { get; set; }

        [JsonProperty("qM5fOther1")]
        public HammerfestPonies QM5FOther1 { get; set; }

        [JsonProperty("qM5fOther2")]
        public HammerfestPonies QM5FOther2 { get; set; }

        [JsonProperty("qM5fOther3")]
        public HammerfestPonies QM5FOther3 { get; set; }

        [JsonProperty("qM5fOther4")]
        public ArakGroundhog QM5FOther4 { get; set; }

        [JsonProperty("qM5g")]
        public ArakGroundhog QM5G { get; set; }

        [JsonProperty("qM5g1")]
        public HammerfestPonies QM5G1 { get; set; }

        [JsonProperty("qM5g2")]
        public HammerfestPonies QM5G2 { get; set; }

        [JsonProperty("qM5g3")]
        public HammerfestPonies QM5G3 { get; set; }

        [JsonProperty("qM5g4")]
        public ArakGroundhog QM5G4 { get; set; }

        [JsonProperty("qM5None")]
        public HammerfestPonies QM5None { get; set; }
    }

    public partial class ArakGroundhog
    {
        [JsonProperty("qIndex")]
        public long QIndex { get; set; }

        [JsonProperty("qLabel")]
        public string QLabel { get; set; }

        [JsonProperty("qQuestionType")]
        public FluffyQQuestionType QQuestionType { get; set; }

        [JsonProperty("qAnswerPresentation")]
        public FluffyQAnswerPresentation QAnswerPresentation { get; set; }

        [JsonProperty("qIsHidden", NullValueHandling = NullValueHandling.Ignore)]
        public bool? QIsHidden { get; set; }

        [JsonProperty("qAnswer")]
        public PurpleQAnswer QAnswer { get; set; }

        [JsonProperty("qPresentationRules", NullValueHandling = NullValueHandling.Ignore)]
        public FluffyQPresentationRule[] QPresentationRules { get; set; }

        [JsonProperty("qDescription", NullValueHandling = NullValueHandling.Ignore)]
        public QDescription? QDescription { get; set; }

        [JsonProperty("qIsAnswerMultivalued", NullValueHandling = NullValueHandling.Ignore)]
        public bool? QIsAnswerMultivalued { get; set; }

        [JsonProperty("qSelectAnswerFromAllowedAnswers", NullValueHandling = NullValueHandling.Ignore)]
        public bool? QSelectAnswerFromAllowedAnswers { get; set; }

        [JsonProperty("qAllowedAnswers", NullValueHandling = NullValueHandling.Ignore)]
        public object[] QAllowedAnswers { get; set; }
    }

    public partial class FluffyQPresentationRule
    {
        [JsonProperty("condition")]
        public Condition[] Condition { get; set; }

        [JsonProperty("action")]
        public FluffyAction[] Action { get; set; }
    }

    public partial class FluffyAction
    {
        [JsonProperty("actionType")]
        public ActionType ActionType { get; set; }

        [JsonProperty("actionValue")]
        public ActionValue ActionValue { get; set; }

        [JsonProperty("itemName", NullValueHandling = NullValueHandling.Ignore)]
        public string ItemName { get; set; }
    }

    public partial class HammerfestPonies
    {
        [JsonProperty("qIndex")]
        public long QIndex { get; set; }

        [JsonProperty("qLabel")]
        public string QLabel { get; set; }

        [JsonProperty("qAnswerPresentation")]
        public PurpleQAnswerPresentation QAnswerPresentation { get; set; }

        [JsonProperty("qIsHidden", NullValueHandling = NullValueHandling.Ignore)]
        public bool? QIsHidden { get; set; }

        [JsonProperty("qQuestionType", NullValueHandling = NullValueHandling.Ignore)]
        public PurpleQQuestionType? QQuestionType { get; set; }

        [JsonProperty("qDescription", NullValueHandling = NullValueHandling.Ignore)]
        public string QDescription { get; set; }

        [JsonProperty("qAnswer")]
        public QAAnswer QAnswer { get; set; }

        [JsonProperty("qPresentationRules", NullValueHandling = NullValueHandling.Ignore)]
        public FluffyQPresentationRule[] QPresentationRules { get; set; }

        [JsonProperty("qSelectAnswerFromAllowedAnswers", NullValueHandling = NullValueHandling.Ignore)]
        public bool? QSelectAnswerFromAllowedAnswers { get; set; }

        [JsonProperty("qAllowedAnswers", NullValueHandling = NullValueHandling.Ignore)]
        public QAllowedAnswer[] QAllowedAnswers { get; set; }

        [JsonProperty("qIsAnswerMultivalued", NullValueHandling = NullValueHandling.Ignore)]
        public bool? QIsAnswerMultivalued { get; set; }

        [JsonProperty("qValidations", NullValueHandling = NullValueHandling.Ignore)]
        public object[] QValidations { get; set; }
    }

    public partial class BeijingPigeon
    {
        [JsonProperty("qIndex")]
        public long QIndex { get; set; }

        [JsonProperty("qLabel")]
        public string QLabel { get; set; }

        [JsonProperty("qIsAnswerMultivalued")]
        public bool QIsAnswerMultivalued { get; set; }

        [JsonProperty("qAnswerPresentation")]
        public FluffyQAnswerPresentation QAnswerPresentation { get; set; }

        [JsonProperty("qAnswer")]
        public FluffyQAnswer QAnswer { get; set; }

        [JsonProperty("qIsHidden")]
        public bool QIsHidden { get; set; }

        [JsonProperty("qPresentationRules", NullValueHandling = NullValueHandling.Ignore)]
        public FluffyQPresentationRule[] QPresentationRules { get; set; }

        [JsonProperty("qSelectAnswerFromAllowedAnswers", NullValueHandling = NullValueHandling.Ignore)]
        public bool? QSelectAnswerFromAllowedAnswers { get; set; }

        [JsonProperty("qAllowedAnswers", NullValueHandling = NullValueHandling.Ignore)]
        public QAllowedAnswer[] QAllowedAnswers { get; set; }

        [JsonProperty("qDescription", NullValueHandling = NullValueHandling.Ignore)]
        public QDescription? QDescription { get; set; }

        [JsonProperty("qQuestionType", NullValueHandling = NullValueHandling.Ignore)]
        public PurpleQQuestionType? QQuestionType { get; set; }

        [JsonProperty("qAcceptsRepeatedAnswerValues", NullValueHandling = NullValueHandling.Ignore)]
        public bool? QAcceptsRepeatedAnswerValues { get; set; }
    }

    public partial class FluffyQAnswer
    {
        [JsonProperty("value")]
        public object[] Value { get; set; }
    }

    public partial class QM5BBp2D
    {
        [JsonProperty("qIndex")]
        public long QIndex { get; set; }

        [JsonProperty("qLabel")]
        public string QLabel { get; set; }

        [JsonProperty("qAnswerPresentation")]
        public string QAnswerPresentation { get; set; }

        [JsonProperty("qIsHidden")]
        public bool QIsHidden { get; set; }

        [JsonProperty("qDescription", NullValueHandling = NullValueHandling.Ignore)]
        public string QDescription { get; set; }

        [JsonProperty("qQuestionType")]
        public string QQuestionType { get; set; }

        [JsonProperty("qAnswer")]
        public QM5BBp2DQAnswer QAnswer { get; set; }

        [JsonProperty("qPresentationRules", NullValueHandling = NullValueHandling.Ignore)]
        public PurpleQPresentationRule[] QPresentationRules { get; set; }
    }

    public partial class QM5BBp2DQAnswer
    {
        [JsonProperty("value")]
        public long Value { get; set; }
    }

    public partial class Page12Rx
    {
        [JsonProperty("qIndex")]
        public long QIndex { get; set; }

        [JsonProperty("GroupRX")]
        public Group GroupRx { get; set; }
    }

    public partial class Page14Mib
    {
        [JsonProperty("qIndex")]
        public long QIndex { get; set; }

        [JsonProperty("GroupMIB")]
        public Group GroupMib { get; set; }
    }

    public partial class Page2
    {
        [JsonProperty("qIndex")]
        public long QIndex { get; set; }

        [JsonProperty("GroupBMI")]
        public GroupBmi GroupBmi { get; set; }

        [JsonProperty("GroupCitizenship")]
        public GroupCitizenship GroupCitizenship { get; set; }

        [JsonProperty("GroupDL")]
        public GroupDl GroupDl { get; set; }

        [JsonProperty("GroupNoDL")]
        public GroupNoDl GroupNoDl { get; set; }

        [JsonProperty("GroupOccupation")]
        public GroupOccupation GroupOccupation { get; set; }

        [JsonProperty("GroupAdditionalInfo")]
        public GroupAdditionalInfo GroupAdditionalInfo { get; set; }

        [JsonProperty("GroupContactInfo")]
        public GroupContactInfo GroupContactInfo { get; set; }
    }

    public partial class GroupAdditionalInfo
    {
        [JsonProperty("qIndex")]
        public long QIndex { get; set; }

        [JsonProperty("qDescription")]
        public string QDescription { get; set; }

        [JsonProperty("qGender")]
        public QGender QGender { get; set; }

        [JsonProperty("qFamilyStatus")]
        public HammerfestPonies QFamilyStatus { get; set; }
    }

    public partial class QGender
    {
        [JsonProperty("qIndex")]
        public long QIndex { get; set; }

        [JsonProperty("qLabel")]
        public string QLabel { get; set; }

        [JsonProperty("qSelectAnswerFromAllowedAnswers", NullValueHandling = NullValueHandling.Ignore)]
        public bool? QSelectAnswerFromAllowedAnswers { get; set; }

        [JsonProperty("qAnswerPresentation")]
        public PurpleQAnswerPresentation QAnswerPresentation { get; set; }

        [JsonProperty("qAnswer")]
        public QAAnswer QAnswer { get; set; }

        [JsonProperty("qAllowedAnswers", NullValueHandling = NullValueHandling.Ignore)]
        public QAllowedAnswer[] QAllowedAnswers { get; set; }

        [JsonProperty("qPresentationRules", NullValueHandling = NullValueHandling.Ignore)]
        public FluffyQPresentationRule[] QPresentationRules { get; set; }

        [JsonProperty("qIsHidden", NullValueHandling = NullValueHandling.Ignore)]
        public bool? QIsHidden { get; set; }

        [JsonProperty("qQuestionType", NullValueHandling = NullValueHandling.Ignore)]
        public PurpleQQuestionType? QQuestionType { get; set; }
    }

    public partial class GroupBmi
    {
        [JsonProperty("qIndex")]
        public long QIndex { get; set; }

        [JsonProperty("qDescription")]
        public string QDescription { get; set; }

        [JsonProperty("qWeight")]
        public QHeightFt QWeight { get; set; }

        [JsonProperty("qHeightFt")]
        public QHeightFt QHeightFt { get; set; }

        [JsonProperty("qHeightInches")]
        public QHeightFt QHeightInches { get; set; }
    }

    public partial class QHeightFt
    {
        [JsonProperty("qLabel")]
        public string QLabel { get; set; }

        [JsonProperty("qQuestionType")]
        public string QQuestionType { get; set; }

        [JsonProperty("qAnswerPresentation")]
        public string QAnswerPresentation { get; set; }

        [JsonProperty("qAnswer")]
        public QM5BBp2DQAnswer QAnswer { get; set; }

        [JsonProperty("qIndex")]
        public long QIndex { get; set; }
    }

    public partial class GroupCitizenship
    {
        [JsonProperty("qIndex")]
        public long QIndex { get; set; }

        [JsonProperty("qDescription")]
        public string QDescription { get; set; }

        [JsonProperty("qQuestionsLayout")]
        public string QQuestionsLayout { get; set; }

        [JsonProperty("qBirthCountry")]
        public HammerfestPonies QBirthCountry { get; set; }

        [JsonProperty("qBirthState")]
        public TartuGecko QBirthState { get; set; }

        [JsonProperty("qUSCitizen")]
        public LivingstoneSouthernWhiteFacedOwl QUsCitizen { get; set; }

        [JsonProperty("qGreenCard")]
        public LivingstoneSouthernWhiteFacedOwl QGreenCard { get; set; }
    }

    public partial class GroupContactInfo
    {
        [JsonProperty("qIndex")]
        public long QIndex { get; set; }

        [JsonProperty("qDescription")]
        public string QDescription { get; set; }

        [JsonProperty("qSameAsResidenceAddress")]
        public ArakGroundhog QSameAsResidenceAddress { get; set; }

        [JsonProperty("qMAddress")]
        public TartuGecko QMAddress { get; set; }

        [JsonProperty("qMCity")]
        public TartuGecko QMCity { get; set; }

        [JsonProperty("qMState")]
        public TartuGecko QMState { get; set; }

        [JsonProperty("qMZipcode")]
        public TartuGecko QMZipcode { get; set; }

        [JsonProperty("qEmail")]
        public TartuGecko QEmail { get; set; }

        [JsonProperty("qPhoneNumber")]
        public TartuGecko QPhoneNumber { get; set; }
    }

    public partial class GroupDl
    {
        [JsonProperty("qIndex")]
        public long QIndex { get; set; }

        [JsonProperty("qDescription")]
        public string QDescription { get; set; }

        [JsonProperty("qDriverLicenseNumber")]
        public TartuGecko QDriverLicenseNumber { get; set; }

        [JsonProperty("qDLState")]
        public TartuGecko QDlState { get; set; }
    }

    public partial class GroupNoDl
    {
        [JsonProperty("qIndex")]
        public long QIndex { get; set; }

        [JsonProperty("qQuestionsLayout")]
        public string QQuestionsLayout { get; set; }

        [JsonProperty("qNoDL")]
        public LivingstoneSouthernWhiteFacedOwl QNoDl { get; set; }

        [JsonProperty("qNoDLReason")]
        public QGender QNoDlReason { get; set; }
    }

    public partial class GroupOccupation
    {
        [JsonProperty("qIndex")]
        public long QIndex { get; set; }

        [JsonProperty("qDescription")]
        public string QDescription { get; set; }

        [JsonProperty("qQuestionsLayout")]
        public string QQuestionsLayout { get; set; }

        [JsonProperty("qOccupation")]
        public QGender QOccupation { get; set; }

        [JsonProperty("qOccupationEmployed")]
        public BeijingPigeon QOccupationEmployed { get; set; }

        [JsonProperty("qOccupationMilitary1")]
        public BeijingPigeon QOccupationMilitary1 { get; set; }

        [JsonProperty("qOccupationMilitary2")]
        public LivingstoneSouthernWhiteFacedOwl QOccupationMilitary2 { get; set; }

        [JsonProperty("qOccupationUnemployed")]
        public LivingstoneSouthernWhiteFacedOwl QOccupationUnemployed { get; set; }

        [JsonProperty("qOccupationStayAtHome")]
        public LivingstoneSouthernWhiteFacedOwl QOccupationStayAtHome { get; set; }

        [JsonProperty("qAnnualIncome")]
        public QHeightFt QAnnualIncome { get; set; }
    }

    public partial class Page4
    {
        [JsonProperty("qIndex")]
        public long QIndex { get; set; }

        [JsonProperty("GroupLabel")]
        public GroupLabel GroupLabel { get; set; }

        [JsonProperty("GroupPrimaryBeneficiaries")]
        public GroupPrimaryBeneficiaries GroupPrimaryBeneficiaries { get; set; }
    }

    public partial class GroupLabel
    {
        [JsonProperty("qIndex")]
        public long QIndex { get; set; }

        [JsonProperty("qDescription")]
        public string QDescription { get; set; }
    }

    public partial class GroupPrimaryBeneficiaries
    {
        [JsonProperty("qQuestionsLayout")]
        public string QQuestionsLayout { get; set; }

        [JsonProperty("qGroupMayBeRepeated")]
        public bool QGroupMayBeRepeated { get; set; }

        [JsonProperty("qIndex")]
        public long QIndex { get; set; }

        [JsonProperty("qDescription")]
        public string QDescription { get; set; }

        [JsonProperty("qPBRelationshipToInsured")]
        public QPbRelationshipToInsured QPbRelationshipToInsured { get; set; }

        [JsonProperty("qPBFirstName")]
        public QPbAddress QPbFirstName { get; set; }

        [JsonProperty("qPBLastName")]
        public QPbAddress QPbLastName { get; set; }

        [JsonProperty("qPBDOB")]
        public QPbAddress QPbdob { get; set; }

        [JsonProperty("qPBAddress")]
        public QPbAddress QPbAddress { get; set; }

        [JsonProperty("qPBCity")]
        public QPbAddress QPbCity { get; set; }

        [JsonProperty("qPBState")]
        public QPbAddress QPbState { get; set; }

        [JsonProperty("qPBZipcode")]
        public QPbAddress QPbZipcode { get; set; }

        [JsonProperty("qPBShare")]
        public BShare QPbShare { get; set; }
    }

    public partial class QPbAddress
    {
        [JsonProperty("qIndex")]
        public long QIndex { get; set; }

        [JsonProperty("qLabel")]
        public string QLabel { get; set; }

        [JsonProperty("qAnswerPresentation")]
        public PurpleQAnswerPresentation QAnswerPresentation { get; set; }

        [JsonProperty("qAnswer")]
        public QAAnswer[] QAnswer { get; set; }

        [JsonProperty("qQuestionType", NullValueHandling = NullValueHandling.Ignore)]
        public PurpleQQuestionType? QQuestionType { get; set; }

        [JsonProperty("qIsHidden", NullValueHandling = NullValueHandling.Ignore)]
        public bool? QIsHidden { get; set; }
    }

    public partial class QPbRelationshipToInsured
    {
        [JsonProperty("qIndex")]
        public long QIndex { get; set; }

        [JsonProperty("qLabel")]
        public string QLabel { get; set; }

        [JsonProperty("qSelectAnswerFromAllowedAnswers", NullValueHandling = NullValueHandling.Ignore)]
        public bool? QSelectAnswerFromAllowedAnswers { get; set; }

        [JsonProperty("qAnswerPresentation")]
        public PurpleQAnswerPresentation QAnswerPresentation { get; set; }

        [JsonProperty("qAnswer")]
        public QAAnswer[] QAnswer { get; set; }

        [JsonProperty("qAllowedAnswers", NullValueHandling = NullValueHandling.Ignore)]
        public QAAnswer[] QAllowedAnswers { get; set; }

        [JsonProperty("qIsHidden", NullValueHandling = NullValueHandling.Ignore)]
        public bool? QIsHidden { get; set; }

        [JsonProperty("qPresentationRules", NullValueHandling = NullValueHandling.Ignore)]
        public FluffyQPresentationRule[] QPresentationRules { get; set; }

        [JsonProperty("qQuestionType", NullValueHandling = NullValueHandling.Ignore)]
        public PurpleQQuestionType? QQuestionType { get; set; }
    }

    public partial class BShare
    {
        [JsonProperty("qIndex")]
        public long QIndex { get; set; }

        [JsonProperty("qLabel")]
        public string QLabel { get; set; }

        [JsonProperty("qQuestionType")]
        public string QQuestionType { get; set; }

        [JsonProperty("qAnswerFormat")]
        public string QAnswerFormat { get; set; }

        [JsonProperty("qAnswerPresentation")]
        public string QAnswerPresentation { get; set; }

        [JsonProperty("qIsMandatory", NullValueHandling = NullValueHandling.Ignore)]
        public bool? QIsMandatory { get; set; }

        [JsonProperty("qAnswer")]
        public object[] QAnswer { get; set; }

        [JsonProperty("qValidations")]
        public object[] QValidations { get; set; }
    }

    public partial class Page6
    {
        [JsonProperty("qIndex")]
        public long QIndex { get; set; }

        [JsonProperty("GroupLabel")]
        public GroupLabel GroupLabel { get; set; }

        [JsonProperty("GroupContingentBeneficiaries")]
        public GroupContingentBeneficiaries GroupContingentBeneficiaries { get; set; }
    }

    public partial class GroupContingentBeneficiaries
    {
        [JsonProperty("qQuestionsLayout")]
        public string QQuestionsLayout { get; set; }

        [JsonProperty("qIndex")]
        public long QIndex { get; set; }

        [JsonProperty("qDescription")]
        public string QDescription { get; set; }

        [JsonProperty("qGroupMayBeRepeated")]
        public bool QGroupMayBeRepeated { get; set; }

        [JsonProperty("qCBRelationshipToInsured")]
        public QPbRelationshipToInsured QCbRelationshipToInsured { get; set; }

        [JsonProperty("qCBFirstName")]
        public QPbAddress QCbFirstName { get; set; }

        [JsonProperty("qCBLastName")]
        public QPbAddress QCbLastName { get; set; }

        [JsonProperty("qCBDOB")]
        public QPbAddress QCbdob { get; set; }

        [JsonProperty("qCBAddress")]
        public QPbAddress QCbAddress { get; set; }

        [JsonProperty("qCBCity")]
        public QPbAddress QCbCity { get; set; }

        [JsonProperty("qCBState")]
        public QPbAddress QCbState { get; set; }

        [JsonProperty("qCBZipcode")]
        public QPbAddress QCbZipcode { get; set; }

        [JsonProperty("qCBShare")]
        public BShare QCbShare { get; set; }
    }

    public partial class Page8
    {
        [JsonProperty("qIndex")]
        public long QIndex { get; set; }

        [JsonProperty("GroupHonestyStatement")]
        public Group GroupHonestyStatement { get; set; }

        [JsonProperty("GroupInsuranceHistory")]
        public GroupInsuranceHistory GroupInsuranceHistory { get; set; }

        [JsonProperty("GroupM4Confinement")]
        public GroupM4Confinement GroupM4Confinement { get; set; }

        [JsonProperty("GroupP4Conviction")]
        public GroupP4Conviction GroupP4Conviction { get; set; }

        [JsonProperty("GroupP4ConvictionFelony")]
        public GroupP4ConvictionFelony GroupP4ConvictionFelony { get; set; }

        [JsonProperty("GroupP4ConvictionMisdemeanor")]
        public GroupP4ConvictionMisdemeanor GroupP4ConvictionMisdemeanor { get; set; }

        [JsonProperty("GroupHIV")]
        public GroupHiv GroupHiv { get; set; }
    }

    public partial class GroupHiv
    {
        [JsonProperty("qIndex")]
        public long QIndex { get; set; }

        [JsonProperty("qDescription")]
        public string QDescription { get; set; }

        [JsonProperty("qQuestionsLayout")]
        public string QQuestionsLayout { get; set; }

        [JsonProperty("qHIV")]
        public ArakGroundhog QHiv { get; set; }

        [JsonProperty("qHIVType")]
        public TartuGecko QHivType { get; set; }

        [JsonProperty("qHIVDate")]
        public TartuGecko QHivDate { get; set; }
    }

    public partial class GroupInsuranceHistory
    {
        [JsonProperty("qIndex")]
        public long QIndex { get; set; }

        [JsonProperty("qDescription")]
        public string QDescription { get; set; }

        [JsonProperty("qQuestionsLayout")]
        public string QQuestionsLayout { get; set; }

        [JsonProperty("qPastDeclinesPostpones")]
        public ArakGroundhog QPastDeclinesPostpones { get; set; }

        [JsonProperty("qPreExistingPolicy")]
        public ArakGroundhog QPreExistingPolicy { get; set; }

        [JsonProperty("qReplaceContract")]
        public ArakGroundhog QReplaceContract { get; set; }

        [JsonProperty("qCombinedAmount")]
        public QM5BBp2D QCombinedAmount { get; set; }
    }

    public partial class GroupM4Confinement
    {
        [JsonProperty("qIndex")]
        public long QIndex { get; set; }

        [JsonProperty("qDescription")]
        public string QDescription { get; set; }

        [JsonProperty("qQuestionsLayout")]
        public string QQuestionsLayout { get; set; }

        [JsonProperty("qM4")]
        public ArakGroundhog QM4 { get; set; }

        [JsonProperty("qM4Type")]
        public HammerfestPonies QM4Type { get; set; }

        [JsonProperty("qM4Confinement0")]
        public QM5BBp2D QM4Confinement0 { get; set; }

        [JsonProperty("qM4Confinement1")]
        public ArakGroundhog QM4Confinement1 { get; set; }

        [JsonProperty("qM4Confinement2")]
        public TartuGecko QM4Confinement2 { get; set; }

        [JsonProperty("qM4Confinement3")]
        public TartuGecko QM4Confinement3 { get; set; }

        [JsonProperty("qM4Confinement4")]
        public HammerfestPonies QM4Confinement4 { get; set; }

        [JsonProperty("qM4Confinement5")]
        public ArakGroundhog QM4Confinement5 { get; set; }
    }

    public partial class GroupP4Conviction
    {
        [JsonProperty("qIndex")]
        public long QIndex { get; set; }

        [JsonProperty("qDescription")]
        public string QDescription { get; set; }

        [JsonProperty("qQuestionsLayout")]
        public string QQuestionsLayout { get; set; }

        [JsonProperty("qP4")]
        public ArakGroundhog QP4 { get; set; }

        [JsonProperty("qP4Type")]
        public BeijingPigeon QP4Type { get; set; }
    }

    public partial class GroupP4ConvictionFelony
    {
        [JsonProperty("qIndex")]
        public long QIndex { get; set; }

        [JsonProperty("qGroupMayBeRepeated")]
        public bool QGroupMayBeRepeated { get; set; }

        [JsonProperty("qQuestionsLayout")]
        public string QQuestionsLayout { get; set; }

        [JsonProperty("qIsHidden")]
        public bool QIsHidden { get; set; }

        [JsonProperty("qDescription")]
        public string QDescription { get; set; }

        [JsonProperty("qP4Felony1")]
        public QPbRelationshipToInsured QP4Felony1 { get; set; }

        [JsonProperty("qP4Felony2")]
        public QPbAddress QP4Felony2 { get; set; }

        [JsonProperty("qP4Felony3")]
        public QPbRelationshipToInsured QP4Felony3 { get; set; }

        [JsonProperty("qP4Felony4")]
        public QPbAddress QP4Felony4 { get; set; }

        [JsonProperty("qP4Felony5")]
        public QP QP4Felony5 { get; set; }

        [JsonProperty("qP4Felony6")]
        public QPbRelationshipToInsured QP4Felony6 { get; set; }

        [JsonProperty("qP4Felony7")]
        public QP QP4Felony7 { get; set; }

        [JsonProperty("qP4Felony8")]
        public QPbRelationshipToInsured QP4Felony8 { get; set; }
    }

    public partial class QP
    {
        [JsonProperty("qIndex")]
        public long QIndex { get; set; }

        [JsonProperty("qLabel")]
        public string QLabel { get; set; }

        [JsonProperty("qQuestionType", NullValueHandling = NullValueHandling.Ignore)]
        public string QQuestionType { get; set; }

        [JsonProperty("qAnswerPresentation")]
        public string QAnswerPresentation { get; set; }

        [JsonProperty("qAnswer")]
        public QAnswerElement[] QAnswer { get; set; }

        [JsonProperty("qIsHidden", NullValueHandling = NullValueHandling.Ignore)]
        public bool? QIsHidden { get; set; }

        [JsonProperty("qPresentationRules", NullValueHandling = NullValueHandling.Ignore)]
        public FluffyQPresentationRule[] QPresentationRules { get; set; }

        [JsonProperty("qSelectAnswerFromAllowedAnswers", NullValueHandling = NullValueHandling.Ignore)]
        public bool? QSelectAnswerFromAllowedAnswers { get; set; }

        [JsonProperty("qAllowedAnswers", NullValueHandling = NullValueHandling.Ignore)]
        public QAAnswer[] QAllowedAnswers { get; set; }
    }

    public partial class QAnswerElement
    {
        [JsonProperty("value")]
        public Value Value { get; set; }
    }

    public partial class GroupP4ConvictionMisdemeanor
    {
        [JsonProperty("qIndex")]
        public long QIndex { get; set; }

        [JsonProperty("qQuestionsLayout")]
        public string QQuestionsLayout { get; set; }

        [JsonProperty("qGroupMayBeRepeated")]
        public bool QGroupMayBeRepeated { get; set; }

        [JsonProperty("qDescription")]
        public string QDescription { get; set; }

        [JsonProperty("qIsHidden")]
        public bool QIsHidden { get; set; }

        [JsonProperty("qP4Misdemeanor1")]
        public QPbRelationshipToInsured QP4Misdemeanor1 { get; set; }

        [JsonProperty("qP4Misdemeanor2")]
        public QP QP4Misdemeanor2 { get; set; }

        [JsonProperty("qP4Misdemeanor3")]
        public QP QP4Misdemeanor3 { get; set; }

        [JsonProperty("qP4Misdemeanor4")]
        public QP QP4Misdemeanor4 { get; set; }

        [JsonProperty("qP4Misdemeanor5")]
        public QP QP4Misdemeanor5 { get; set; }

        [JsonProperty("qP4Misdemeanor6")]
        public QP QP4Misdemeanor6 { get; set; }

        [JsonProperty("qP4Misdemeanor7")]
        public QPbRelationshipToInsured QP4Misdemeanor7 { get; set; }
    }

    public partial class Page9
    {
        [JsonProperty("qIndex")]
        public long QIndex { get; set; }

        [JsonProperty("GroupP1Avocation")]
        public GroupP1Avocation GroupP1Avocation { get; set; }

        [JsonProperty("GroupP2Tobacco")]
        public GroupP2Tobacco GroupP2Tobacco { get; set; }

        [JsonProperty("GroupP3MotorVehicle")]
        public GroupP3MotorVehicle GroupP3MotorVehicle { get; set; }

        [JsonProperty("GroupP3MotorVehicleViolation")]
        public GroupP3MotorVehicleViolation GroupP3MotorVehicleViolation { get; set; }

        [JsonProperty("GroupP5DrugsAlcohol")]
        public GroupP5DrugsAlcohol GroupP5DrugsAlcohol { get; set; }
    }

    public partial class GroupP1Avocation
    {
        [JsonProperty("qDescription")]
        public string QDescription { get; set; }

        [JsonProperty("qIndex")]
        public long QIndex { get; set; }

        [JsonProperty("qQuestionsLayout")]
        public string QQuestionsLayout { get; set; }

        [JsonProperty("qP1")]
        public ArakGroundhog QP1 { get; set; }

        [JsonProperty("qP1Type")]
        public BeijingPigeon QP1Type { get; set; }

        [JsonProperty("qP1Climbing1")]
        public ArakGroundhog QP1Climbing1 { get; set; }

        [JsonProperty("qP1Extreme1")]
        public BeijingPigeon QP1Extreme1 { get; set; }

        [JsonProperty("qP1Scuba1")]
        public ArakGroundhog QP1Scuba1 { get; set; }

        [JsonProperty("qP1Pilot1")]
        public BeijingPigeon QP1Pilot1 { get; set; }

        [JsonProperty("qP1Pilot2")]
        public ArakGroundhog QP1Pilot2 { get; set; }

        [JsonProperty("qP1Pilot3")]
        public ArakGroundhog QP1Pilot3 { get; set; }

        [JsonProperty("qP1Pilot4")]
        public HammerfestPonies QP1Pilot4 { get; set; }

        [JsonProperty("qP1Pilot5")]
        public ArakGroundhog QP1Pilot5 { get; set; }

        [JsonProperty("qP1Pilot6")]
        public ArakGroundhog QP1Pilot6 { get; set; }

        [JsonProperty("qP1Pilot7")]
        public ArakGroundhog QP1Pilot7 { get; set; }

        [JsonProperty("qP1Pilot8")]
        public ArakGroundhog QP1Pilot8 { get; set; }

        [JsonProperty("qP1Pilot9")]
        public ArakGroundhog QP1Pilot9 { get; set; }

        [JsonProperty("qP1Pilot10")]
        public ArakGroundhog QP1Pilot10 { get; set; }
    }

    public partial class GroupP2Tobacco
    {
        [JsonProperty("qDescription")]
        public string QDescription { get; set; }

        [JsonProperty("qQuestionsLayout")]
        public string QQuestionsLayout { get; set; }

        [JsonProperty("qIndex")]
        public long QIndex { get; set; }

        [JsonProperty("qTobacco")]
        public QGender QTobacco { get; set; }

        [JsonProperty("qTobaccoType")]
        public BeijingPigeon QTobaccoType { get; set; }

        [JsonProperty("qTobaccoCigarettes1")]
        public TartuGecko QTobaccoCigarettes1 { get; set; }

        [JsonProperty("qTobaccoCigar1")]
        public TartuGecko QTobaccoCigar1 { get; set; }

        [JsonProperty("qTobaccoPipe1")]
        public TartuGecko QTobaccoPipe1 { get; set; }

        [JsonProperty("qTobaccoHookah1")]
        public TartuGecko QTobaccoHookah1 { get; set; }
    }

    public partial class GroupP3MotorVehicle
    {
        [JsonProperty("qQuestionsLayout")]
        public string QQuestionsLayout { get; set; }

        [JsonProperty("qIndex")]
        public long QIndex { get; set; }

        [JsonProperty("qDescription")]
        public string QDescription { get; set; }

        [JsonProperty("qP3")]
        public LivingstoneSouthernWhiteFacedOwl QP3 { get; set; }

        [JsonProperty("qP3Type")]
        public BeijingPigeon QP3Type { get; set; }

        [JsonProperty("qP3Dui1")]
        public BeijingPigeon QP3Dui1 { get; set; }

        [JsonProperty("qP3Reckless1")]
        public BeijingPigeon QP3Reckless1 { get; set; }

        [JsonProperty("qP3Suspension1")]
        public TartuGecko QP3Suspension1 { get; set; }
    }

    public partial class GroupP3MotorVehicleViolation
    {
        [JsonProperty("qIndex")]
        public long QIndex { get; set; }

        [JsonProperty("qLabel")]
        public string QLabel { get; set; }

        [JsonProperty("qIsHidden")]
        public bool QIsHidden { get; set; }

        [JsonProperty("qGroupMayBeRepeated")]
        public bool QGroupMayBeRepeated { get; set; }

        [JsonProperty("qQuestionsLayout")]
        public string QQuestionsLayout { get; set; }

        [JsonProperty("qP3Violations1")]
        public QP QP3Violations1 { get; set; }

        [JsonProperty("qP3Violations2")]
        public QP QP3Violations2 { get; set; }
    }

    public partial class GroupP5DrugsAlcohol
    {
        [JsonProperty("qIndex")]
        public long QIndex { get; set; }

        [JsonProperty("qDescription")]
        public string QDescription { get; set; }

        [JsonProperty("qQuestionsLayout")]
        public string QQuestionsLayout { get; set; }

        [JsonProperty("qP5")]
        public LivingstoneSouthernWhiteFacedOwl QP5 { get; set; }

        [JsonProperty("qP5Type")]
        public BeijingPigeon QP5Type { get; set; }

        [JsonProperty("qP5Drugs1")]
        public QGender QP5Drugs1 { get; set; }

        [JsonProperty("qP5Drugs2")]
        public ArakGroundhog QP5Drugs2 { get; set; }

        [JsonProperty("qP5Drugs3")]
        public QGender QP5Drugs3 { get; set; }

        [JsonProperty("qP5Alcohol1")]
        public HammerfestPonies QP5Alcohol1 { get; set; }

        [JsonProperty("qP5Alcohol2")]
        public ArakGroundhog QP5Alcohol2 { get; set; }

        [JsonProperty("qP5Alcohol3")]
        public QGender QP5Alcohol3 { get; set; }
    }

    public partial class QDefaultBooleanAnswerDisplayValues
    {
        [JsonProperty("trueDisplayValue")]
        public string TrueDisplayValue { get; set; }

        [JsonProperty("falseDisplayValue")]
        public string FalseDisplayValue { get; set; }
    }

    public partial class QuestionnaireState
    {
        [JsonProperty("sCurrentState")]
        public string SCurrentState { get; set; }

        [JsonProperty("sStateTrace")]
        public string[] SStateTrace { get; set; }

        [JsonProperty("sIsFinalState")]
        public bool SIsFinalState { get; set; }

        [JsonProperty("sForceNonInteractive")]
        public bool SForceNonInteractive { get; set; }
    }

    public enum PurpleQAnswerPresentation { Dropdown, Html, Picker, Text };

    public enum ActionType { SetHidden };

    public enum ActionValue { False };

    public enum ItemAttribute { AnswerValue, IsHidden };

    public enum QOperator { Contains, Equals, NotEqual };

    public enum PurpleQQuestionType { Date, Markdown, String };

    public enum FluffyQAnswerPresentation { Checkbox, Picker, Text };

    public enum QDescription { Empty, Hr };

    public enum FluffyQQuestionType { Boolean };

    public partial struct Value
    {
        public bool? Bool;
        public string String;

        public static implicit operator Value(bool Bool) => new Value { Bool = Bool };
        public static implicit operator Value(string String) => new Value { String = String };
    }

    public partial class Welcome
    {
        public static Welcome FromJson(string json) => JsonConvert.DeserializeObject<Welcome>(json, QuickType.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Welcome self) => JsonConvert.SerializeObject(self, QuickType.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                PurpleQAnswerPresentationConverter.Singleton,
                ActionTypeConverter.Singleton,
                ActionValueConverter.Singleton,
                ItemAttributeConverter.Singleton,
                QOperatorConverter.Singleton,
                PurpleQQuestionTypeConverter.Singleton,
                FluffyQAnswerPresentationConverter.Singleton,
                QDescriptionConverter.Singleton,
                FluffyQQuestionTypeConverter.Singleton,
                ValueConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class PurpleQAnswerPresentationConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PurpleQAnswerPresentation) || t == typeof(PurpleQAnswerPresentation?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Dropdown":
                    return PurpleQAnswerPresentation.Dropdown;
                case "Html":
                    return PurpleQAnswerPresentation.Html;
                case "Picker":
                    return PurpleQAnswerPresentation.Picker;
                case "Text":
                    return PurpleQAnswerPresentation.Text;
            }
            throw new Exception("Cannot unmarshal type PurpleQAnswerPresentation");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (PurpleQAnswerPresentation)untypedValue;
            switch (value)
            {
                case PurpleQAnswerPresentation.Dropdown:
                    serializer.Serialize(writer, "Dropdown");
                    return;
                case PurpleQAnswerPresentation.Html:
                    serializer.Serialize(writer, "Html");
                    return;
                case PurpleQAnswerPresentation.Picker:
                    serializer.Serialize(writer, "Picker");
                    return;
                case PurpleQAnswerPresentation.Text:
                    serializer.Serialize(writer, "Text");
                    return;
            }
            throw new Exception("Cannot marshal type PurpleQAnswerPresentation");
        }

        public static readonly PurpleQAnswerPresentationConverter Singleton = new PurpleQAnswerPresentationConverter();
    }

    internal class ActionTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ActionType) || t == typeof(ActionType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "SetHidden")
            {
                return ActionType.SetHidden;
            }
            throw new Exception("Cannot unmarshal type ActionType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ActionType)untypedValue;
            if (value == ActionType.SetHidden)
            {
                serializer.Serialize(writer, "SetHidden");
                return;
            }
            throw new Exception("Cannot marshal type ActionType");
        }

        public static readonly ActionTypeConverter Singleton = new ActionTypeConverter();
    }

    internal class ActionValueConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ActionValue) || t == typeof(ActionValue?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "False")
            {
                return ActionValue.False;
            }
            throw new Exception("Cannot unmarshal type ActionValue");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ActionValue)untypedValue;
            if (value == ActionValue.False)
            {
                serializer.Serialize(writer, "False");
                return;
            }
            throw new Exception("Cannot marshal type ActionValue");
        }

        public static readonly ActionValueConverter Singleton = new ActionValueConverter();
    }

    internal class ItemAttributeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ItemAttribute) || t == typeof(ItemAttribute?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "AnswerValue":
                    return ItemAttribute.AnswerValue;
                case "IsHidden":
                    return ItemAttribute.IsHidden;
            }
            throw new Exception("Cannot unmarshal type ItemAttribute");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ItemAttribute)untypedValue;
            switch (value)
            {
                case ItemAttribute.AnswerValue:
                    serializer.Serialize(writer, "AnswerValue");
                    return;
                case ItemAttribute.IsHidden:
                    serializer.Serialize(writer, "IsHidden");
                    return;
            }
            throw new Exception("Cannot marshal type ItemAttribute");
        }

        public static readonly ItemAttributeConverter Singleton = new ItemAttributeConverter();
    }

    internal class QOperatorConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(QOperator) || t == typeof(QOperator?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Contains":
                    return QOperator.Contains;
                case "Equals":
                    return QOperator.Equals;
                case "NotEqual":
                    return QOperator.NotEqual;
            }
            throw new Exception("Cannot unmarshal type QOperator");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (QOperator)untypedValue;
            switch (value)
            {
                case QOperator.Contains:
                    serializer.Serialize(writer, "Contains");
                    return;
                case QOperator.Equals:
                    serializer.Serialize(writer, "Equals");
                    return;
                case QOperator.NotEqual:
                    serializer.Serialize(writer, "NotEqual");
                    return;
            }
            throw new Exception("Cannot marshal type QOperator");
        }

        public static readonly QOperatorConverter Singleton = new QOperatorConverter();
    }

    internal class PurpleQQuestionTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PurpleQQuestionType) || t == typeof(PurpleQQuestionType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Date":
                    return PurpleQQuestionType.Date;
                case "Markdown":
                    return PurpleQQuestionType.Markdown;
                case "String":
                    return PurpleQQuestionType.String;
            }
            throw new Exception("Cannot unmarshal type PurpleQQuestionType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (PurpleQQuestionType)untypedValue;
            switch (value)
            {
                case PurpleQQuestionType.Date:
                    serializer.Serialize(writer, "Date");
                    return;
                case PurpleQQuestionType.Markdown:
                    serializer.Serialize(writer, "Markdown");
                    return;
                case PurpleQQuestionType.String:
                    serializer.Serialize(writer, "String");
                    return;
            }
            throw new Exception("Cannot marshal type PurpleQQuestionType");
        }

        public static readonly PurpleQQuestionTypeConverter Singleton = new PurpleQQuestionTypeConverter();
    }

    internal class FluffyQAnswerPresentationConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(FluffyQAnswerPresentation) || t == typeof(FluffyQAnswerPresentation?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Checkbox":
                    return FluffyQAnswerPresentation.Checkbox;
                case "Picker":
                    return FluffyQAnswerPresentation.Picker;
                case "Text":
                    return FluffyQAnswerPresentation.Text;
            }
            throw new Exception("Cannot unmarshal type FluffyQAnswerPresentation");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (FluffyQAnswerPresentation)untypedValue;
            switch (value)
            {
                case FluffyQAnswerPresentation.Checkbox:
                    serializer.Serialize(writer, "Checkbox");
                    return;
                case FluffyQAnswerPresentation.Picker:
                    serializer.Serialize(writer, "Picker");
                    return;
                case FluffyQAnswerPresentation.Text:
                    serializer.Serialize(writer, "Text");
                    return;
            }
            throw new Exception("Cannot marshal type FluffyQAnswerPresentation");
        }

        public static readonly FluffyQAnswerPresentationConverter Singleton = new FluffyQAnswerPresentationConverter();
    }

    internal class QDescriptionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(QDescription) || t == typeof(QDescription?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "":
                    return QDescription.Empty;
                case "<hr/>":
                    return QDescription.Hr;
            }
            throw new Exception("Cannot unmarshal type QDescription");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (QDescription)untypedValue;
            switch (value)
            {
                case QDescription.Empty:
                    serializer.Serialize(writer, "");
                    return;
                case QDescription.Hr:
                    serializer.Serialize(writer, "<hr/>");
                    return;
            }
            throw new Exception("Cannot marshal type QDescription");
        }

        public static readonly QDescriptionConverter Singleton = new QDescriptionConverter();
    }

    internal class FluffyQQuestionTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(FluffyQQuestionType) || t == typeof(FluffyQQuestionType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "Boolean")
            {
                return FluffyQQuestionType.Boolean;
            }
            throw new Exception("Cannot unmarshal type FluffyQQuestionType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (FluffyQQuestionType)untypedValue;
            if (value == FluffyQQuestionType.Boolean)
            {
                serializer.Serialize(writer, "Boolean");
                return;
            }
            throw new Exception("Cannot marshal type FluffyQQuestionType");
        }

        public static readonly FluffyQQuestionTypeConverter Singleton = new FluffyQQuestionTypeConverter();
    }

    internal class ValueConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Value) || t == typeof(Value?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new Value { Bool = boolValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new Value { String = stringValue };
            }
            throw new Exception("Cannot unmarshal type Value");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Value)untypedValue;
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            throw new Exception("Cannot marshal type Value");
        }

        public static readonly ValueConverter Singleton = new ValueConverter();
    }
}
