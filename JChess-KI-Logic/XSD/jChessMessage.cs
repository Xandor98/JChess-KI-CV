//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// Dieser Quellcode wurde automatisch generiert von xsd, Version=4.8.3928.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class JChessMessage {
    
    private object itemField;
    
    private JChessMessageType messageTypeField;
    
    private string playerIdField;
    
    private string schemaVersionField;
    
    public JChessMessage() {
        this.schemaVersionField = "0.1.1";
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Accept", typeof(AcceptMessage), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlElementAttribute("AwaitMove", typeof(AwaitMoveMessage), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlElementAttribute("Disconnect", typeof(DisconnectMessage), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlElementAttribute("DrawResponse", typeof(DrawResponseMessage), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlElementAttribute("GameOver", typeof(GameOverMessage), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlElementAttribute("GameStart", typeof(GameStartMessage), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlElementAttribute("HeartBeat", typeof(HeartBeatMessage), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlElementAttribute("Login", typeof(LoginMessage), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlElementAttribute("LoginReply", typeof(LoginReplyMessage), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlElementAttribute("MatchFound", typeof(MatchFoundMessage), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlElementAttribute("MatchOver", typeof(MatchOverMessage), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlElementAttribute("MatchStatus", typeof(MatchStatusMessage), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlElementAttribute("Move", typeof(MoveMessage), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlElementAttribute("RequestDraw", typeof(RequestDrawMessage), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public object Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public JChessMessageType messageType {
        get {
            return this.messageTypeField;
        }
        set {
            this.messageTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string playerId {
        get {
            return this.playerIdField;
        }
        set {
            this.playerIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string schemaVersion {
        get {
            return this.schemaVersionField;
        }
        set {
            this.schemaVersionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class AcceptMessage {
    
    private bool acceptField;
    
    private ErrorType errorTypeCodeField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public bool accept {
        get {
            return this.acceptField;
        }
        set {
            this.acceptField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public ErrorType errorTypeCode {
        get {
            return this.errorTypeCodeField;
        }
        set {
            this.errorTypeCodeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
public enum ErrorType {
    
    /// <remarks/>
    NO_ERROR,
    
    /// <remarks/>
    ERROR,
    
    /// <remarks/>
    AWAIT_LOGIN,
    
    /// <remarks/>
    TIMEOUT,
    
    /// <remarks/>
    TOO_MANY_TRIES,
    
    /// <remarks/>
    UNSUPPORTED_OPERATION,
    
    /// <remarks/>
    DUPLICATE_NAME,
    
    /// <remarks/>
    VERSION_MISMATCH,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class DrawResponseMessage {
    
    private bool acceptField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public bool accept {
        get {
            return this.acceptField;
        }
        set {
            this.acceptField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class RequestDrawMessage {
    
    private RequestDrawType reasonField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public RequestDrawType reason {
        get {
            return this.reasonField;
        }
        set {
            this.reasonField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
public enum RequestDrawType {
    
    /// <remarks/>
    OFFER,
    
    /// <remarks/>
    FIFTY_MOVE_RULE,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class MoveMessage {
    
    private MoveData moveField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public MoveData move {
        get {
            return this.moveField;
        }
        set {
            this.moveField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class MoveData {
    
    private string fromField;
    
    private string toField;
    
    private string promotionUnitField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string from {
        get {
            return this.fromField;
        }
        set {
            this.fromField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string to {
        get {
            return this.toField;
        }
        set {
            this.toField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string promotionUnit {
        get {
            return this.promotionUnitField;
        }
        set {
            this.promotionUnitField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class TimeControlData {
    
    private uint yourTimeInMsField;
    
    private uint enemyTimeInMsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public uint yourTimeInMs {
        get {
            return this.yourTimeInMsField;
        }
        set {
            this.yourTimeInMsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public uint enemyTimeInMs {
        get {
            return this.enemyTimeInMsField;
        }
        set {
            this.enemyTimeInMsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class AwaitMoveMessage {
    
    private string positionField;
    
    private MoveData lastMoveField;
    
    private TimeControlData timeControlField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string position {
        get {
            return this.positionField;
        }
        set {
            this.positionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public MoveData lastMove {
        get {
            return this.lastMoveField;
        }
        set {
            this.lastMoveField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public TimeControlData timeControl {
        get {
            return this.timeControlField;
        }
        set {
            this.timeControlField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class GameOverMessage {
    
    private string winnerField;
    
    private bool isDrawField;
    
    private string pgnField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string winner {
        get {
            return this.winnerField;
        }
        set {
            this.winnerField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public bool isDraw {
        get {
            return this.isDrawField;
        }
        set {
            this.isDrawField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string pgn {
        get {
            return this.pgnField;
        }
        set {
            this.pgnField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class GameStartMessage {
    
    private string nameWhiteField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string nameWhite {
        get {
            return this.nameWhiteField;
        }
        set {
            this.nameWhiteField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class MatchStatusMessage {
    
    private MatchStatusData matchStatusField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public MatchStatusData matchStatus {
        get {
            return this.matchStatusField;
        }
        set {
            this.matchStatusField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class MatchStatusData {
    
    private string namePlayer1Field;
    
    private string namePlayer2Field;
    
    private uint scorePlayer1Field;
    
    private uint scorePlayer2Field;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string namePlayer1 {
        get {
            return this.namePlayer1Field;
        }
        set {
            this.namePlayer1Field = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string namePlayer2 {
        get {
            return this.namePlayer2Field;
        }
        set {
            this.namePlayer2Field = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public uint scorePlayer1 {
        get {
            return this.scorePlayer1Field;
        }
        set {
            this.scorePlayer1Field = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public uint scorePlayer2 {
        get {
            return this.scorePlayer2Field;
        }
        set {
            this.scorePlayer2Field = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class MatchOverMessage {
    
    private MatchStatusData matchStatusField;
    
    private MatchFormatData matchFormatField;
    
    private string statisticsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public MatchStatusData matchStatus {
        get {
            return this.matchStatusField;
        }
        set {
            this.matchStatusField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public MatchFormatData matchFormat {
        get {
            return this.matchFormatField;
        }
        set {
            this.matchFormatField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string statistics {
        get {
            return this.statisticsField;
        }
        set {
            this.statisticsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class MatchFormatData {
    
    private MatchTypeValue matchTypeValueField;
    
    private MatchTypeData matchTypeDataField;
    
    private uint timePerSideField;
    
    private uint timePerSideIncrementField;
    
    private uint timePerSidePerMoveField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public MatchTypeValue matchTypeValue {
        get {
            return this.matchTypeValueField;
        }
        set {
            this.matchTypeValueField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public MatchTypeData matchTypeData {
        get {
            return this.matchTypeDataField;
        }
        set {
            this.matchTypeDataField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public uint timePerSide {
        get {
            return this.timePerSideField;
        }
        set {
            this.timePerSideField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public uint timePerSideIncrement {
        get {
            return this.timePerSideIncrementField;
        }
        set {
            this.timePerSideIncrementField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public uint timePerSidePerMove {
        get {
            return this.timePerSidePerMoveField;
        }
        set {
            this.timePerSidePerMoveField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
public enum MatchTypeValue {
    
    /// <remarks/>
    WIN_X,
    
    /// <remarks/>
    SCORE,
}

/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(MatchTypeScore))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(MatchTypeWinX))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class MatchTypeData {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class MatchTypeScore : MatchTypeData {
    
    private uint amountToPlayField;
    
    private uint pointsPerWinField;
    
    private uint pointsPerDrawField;
    
    public MatchTypeScore() {
        this.pointsPerWinField = ((uint)(2));
        this.pointsPerDrawField = ((uint)(1));
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public uint amountToPlay {
        get {
            return this.amountToPlayField;
        }
        set {
            this.amountToPlayField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public uint pointsPerWin {
        get {
            return this.pointsPerWinField;
        }
        set {
            this.pointsPerWinField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public uint pointsPerDraw {
        get {
            return this.pointsPerDrawField;
        }
        set {
            this.pointsPerDrawField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class MatchTypeWinX : MatchTypeData {
    
    private uint amountToWinField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public uint amountToWin {
        get {
            return this.amountToWinField;
        }
        set {
            this.amountToWinField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class MatchFoundMessage {
    
    private string matchIdField;
    
    private string enemyNameField;
    
    private MatchFormatData matchFormatField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string matchId {
        get {
            return this.matchIdField;
        }
        set {
            this.matchIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string enemyName {
        get {
            return this.enemyNameField;
        }
        set {
            this.enemyNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public MatchFormatData matchFormat {
        get {
            return this.matchFormatField;
        }
        set {
            this.matchFormatField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class DisconnectMessage {
    
    private ErrorType errorTypeCodeField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public ErrorType errorTypeCode {
        get {
            return this.errorTypeCodeField;
        }
        set {
            this.errorTypeCodeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class HeartBeatMessage {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class LoginReplyMessage {
    
    private string newIdField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string newId {
        get {
            return this.newIdField;
        }
        set {
            this.newIdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class LoginMessage {
    
    private string nameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
public enum JChessMessageType {
    
    /// <remarks/>
    Accept,
    
    /// <remarks/>
    Login,
    
    /// <remarks/>
    LoginReply,
    
    /// <remarks/>
    HeartBeat,
    
    /// <remarks/>
    Disconnect,
    
    /// <remarks/>
    MatchFound,
    
    /// <remarks/>
    MatchOver,
    
    /// <remarks/>
    MatchStatus,
    
    /// <remarks/>
    GameStart,
    
    /// <remarks/>
    GameOver,
    
    /// <remarks/>
    AwaitMove,
    
    /// <remarks/>
    Move,
    
    /// <remarks/>
    RequestDraw,
    
    /// <remarks/>
    DrawResponse,
}
