// ***********************************
// ** Azure OpenAI Demo             **
// ***********************************
// ** Created: September 2023       **
// ** Guillermo Musumeci            **
// ***********************************
// ** Updated: October 2023         **
// ** Guillermo Musumeci            **
// ***********************************

using Azure;
using Azure.AI.OpenAI;
using System;
using System.Net.Http;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace OpenAIDemo
{
    public partial class frmOpenAI : Form
    {
        #region "Form Init"
        public frmOpenAI()
        {
            InitializeComponent();
        }

        private void frmOpenAI_Load(object sender, EventArgs e)
        {
            listLog.Items.Clear();

            textQuestion.Text = "How many countries in Europe?";

            textEndpoint1.Text = "https://kopicloud-openai-dev-we.openai.azure.com/";
            textCredentialKey1.Text = "2b023a84771c44edb55accda0b29f800";
            textModelName1.Text = "kopicloud-openai-dev-we-acd";

            textEndpoint2.Text = "https://kopicloud-openai-dev-eus.openai.azure.com/";
            textCredentialKey2.Text = "76e78017668d49af974e2c4f55bf17ee";
            textModelName2.Text = "kopicloud-openai-dev-eus-acd";
        }
        #endregion

        #region "BUTTON Clear"
        private void btnClear_Click(object sender, EventArgs e)
        {
            textQuestion.Text = "";
            textResponse.Text = "";
        }
        #endregion

        #region "BUTTON Question"
        private void btnQuestion_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            listLog.Items.Add("Querying the Main Azure OpenAI Instance");

            bool ResultMain = ExecuteOpenAI(textEndpoint1.Text.Trim(), textCredentialKey1.Text.Trim(), textModelName1.Text.Trim(), "Main");

            if (ResultMain)
            {
                listLog.Items.Add("Main Azure OpenAI Instance OK");
            }
            else
            {
                Cursor.Current = Cursors.WaitCursor;
                if ((textEndpoint2.Text.Trim().Length > 0) && (textCredentialKey2.Text.Trim().Length > 0) && (textModelName2.Text.Trim().Length > 0))
                {
                    RotateOrder();
                    listLog.Items.Add("Querying the DR Azure OpenAI Instance");
                    bool ResultDR = ExecuteOpenAI(textEndpoint1.Text.Trim(), textCredentialKey1.Text.Trim(), textModelName1.Text.Trim(), "DR");
                }
                else
                {
                    listLog.Items.Add("No Valid DR Azure OpenAI Instance Information");
                }
            }
        }
        #endregion

        #region "BUTTON Rotate Order"
        private void btnRotate_Click(object sender, EventArgs e)
        {
            RotateOrder();
        }
        #endregion

        #region "BUTTON Clear Settings"
        private void btnClearSettings_Click(object sender, EventArgs e)
        {
            textCredentialKey1.Text = "";
            textCredentialKey2.Text = "";

            textEndpoint1.Text = "";
            textEndpoint2.Text = "";

            textModelName1.Text = "";
            textModelName2.Text = "";
        }
        #endregion

        #region "Execute OpenAI Question"
        private bool ExecuteOpenAI(string Endpoint, string Credential, string OpenAIModelName, string InstanceType)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                OpenAIClient client = new OpenAIClient(
                    new Uri(Endpoint),
                    new AzureKeyCredential(Credential)
                );

                Response<ChatCompletions> responseWithoutStream = client.GetChatCompletions(
                    OpenAIModelName,
                    new ChatCompletionsOptions()
                    {
                        Messages =
                        {
                            new ChatMessage(ChatRole.System, @"You are an AI assistant that helps people find information."),
                            new ChatMessage(ChatRole.User, textQuestion.Text),
                        },
                        Temperature = (float)0.7,
                        MaxTokens = 2500,
                        NucleusSamplingFactor = (float)0.95,
                        FrequencyPenalty = 0,
                        PresencePenalty = 0,
                    });

                ChatCompletions completions = responseWithoutStream.Value;

                textResponse.Text = completions.Choices[0].Message.Content.ToString();

                Cursor.Current = Cursors.Default;
                return true;
            }
            catch (Exception ex)
            {
                listLog.Items.Add(InstanceType + " Azure Open AI Error " + ex.Message);

                Cursor.Current = Cursors.Default;
                return false;
            }
        }
        #endregion

        #region "Rotate Order"
        private void RotateOrder()
        {
            listLog.Items.Add("Rotating the Order of the Azure OpenAI Instances");

            string Endpoint = textEndpoint1.Text.Trim();
            string CredentialKey = textCredentialKey1.Text.Trim();
            string ModelName = textModelName1.Text.Trim();

            textEndpoint1.Text = textEndpoint2.Text.Trim();
            textCredentialKey1.Text = textCredentialKey2.Text.Trim();
            textModelName1.Text = textModelName2.Text.Trim();

            textEndpoint2.Text = Endpoint;
            textCredentialKey2.Text = CredentialKey;
            textModelName2.Text = ModelName;
        }
        #endregion
    }
}