﻿

namespace inventory {
    
    
   
    [global::System.Serializable()]
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedDataSetSchema")]
    [global::System.Xml.Serialization.XmlRootAttribute("supermartDataSet1")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.DataSet")]
    public partial class supermartDataSet1 : global::System.Data.DataSet {
        
        private customerDataTable tablecustomer;
        
        private itemDataTable tableitem;
        
        private purchaseDataTable tablepurchase;
        
        private saleDataTable tablesale;
        
        private supplierDataTable tablesupplier;
        
        private global::System.Data.DataRelation relationFK_purchase_item;
        
        private global::System.Data.DataRelation relationFK_sale_customer;
        
        private global::System.Data.DataRelation relationFK_sale_item;
        
        private global::System.Data.SchemaSerializationMode _schemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        public supermartDataSet1() {
            this.BeginInit();
            this.InitClass();
            global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            base.Tables.CollectionChanged += schemaChangedHandler;
            base.Relations.CollectionChanged += schemaChangedHandler;
            this.EndInit();
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        protected supermartDataSet1(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                base(info, context, false) {
            if ((this.IsBinarySerialized(info, context) == true)) {
                this.InitVars(false);
                global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler1 = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
                this.Tables.CollectionChanged += schemaChangedHandler1;
                this.Relations.CollectionChanged += schemaChangedHandler1;
                return;
            }
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((this.DetermineSchemaSerializationMode(info, context) == global::System.Data.SchemaSerializationMode.IncludeSchema)) {
                global::System.Data.DataSet ds = new global::System.Data.DataSet();
                ds.ReadXmlSchema(new global::System.Xml.XmlTextReader(new global::System.IO.StringReader(strSchema)));
                if ((ds.Tables["customer"] != null)) {
                    base.Tables.Add(new customerDataTable(ds.Tables["customer"]));
                }
                if ((ds.Tables["item"] != null)) {
                    base.Tables.Add(new itemDataTable(ds.Tables["item"]));
                }
                if ((ds.Tables["purchase"] != null)) {
                    base.Tables.Add(new purchaseDataTable(ds.Tables["purchase"]));
                }
                if ((ds.Tables["sale"] != null)) {
                    base.Tables.Add(new saleDataTable(ds.Tables["sale"]));
                }
                if ((ds.Tables["supplier"] != null)) {
                    base.Tables.Add(new supplierDataTable(ds.Tables["supplier"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, global::System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.ReadXmlSchema(new global::System.Xml.XmlTextReader(new global::System.IO.StringReader(strSchema)));
            }
            this.GetSerializationData(info, context);
            global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            base.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public customerDataTable customer {
            get {
                return this.tablecustomer;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public itemDataTable item {
            get {
                return this.tableitem;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public purchaseDataTable purchase {
            get {
                return this.tablepurchase;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public saleDataTable sale {
            get {
                return this.tablesale;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public supplierDataTable supplier {
            get {
                return this.tablesupplier;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.BrowsableAttribute(true)]
        [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Visible)]
        public override global::System.Data.SchemaSerializationMode SchemaSerializationMode {
            get {
                return this._schemaSerializationMode;
            }
            set {
                this._schemaSerializationMode = value;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public new global::System.Data.DataTableCollection Tables {
            get {
                return base.Tables;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public new global::System.Data.DataRelationCollection Relations {
            get {
                return base.Relations;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        protected override void InitializeDerivedDataSet() {
            this.BeginInit();
            this.InitClass();
            this.EndInit();
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        public override global::System.Data.DataSet Clone() {
            supermartDataSet1 cln = ((supermartDataSet1)(base.Clone()));
            cln.InitVars();
            cln.SchemaSerializationMode = this.SchemaSerializationMode;
            return cln;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        protected override bool ShouldSerializeTables() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        protected override bool ShouldSerializeRelations() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        protected override void ReadXmlSerializable(global::System.Xml.XmlReader reader) {
            if ((this.DetermineSchemaSerializationMode(reader) == global::System.Data.SchemaSerializationMode.IncludeSchema)) {
                this.Reset();
                global::System.Data.DataSet ds = new global::System.Data.DataSet();
                ds.ReadXml(reader);
                if ((ds.Tables["customer"] != null)) {
                    base.Tables.Add(new customerDataTable(ds.Tables["customer"]));
                }
                if ((ds.Tables["item"] != null)) {
                    base.Tables.Add(new itemDataTable(ds.Tables["item"]));
                }
                if ((ds.Tables["purchase"] != null)) {
                    base.Tables.Add(new purchaseDataTable(ds.Tables["purchase"]));
                }
                if ((ds.Tables["sale"] != null)) {
                    base.Tables.Add(new saleDataTable(ds.Tables["sale"]));
                }
                if ((ds.Tables["supplier"] != null)) {
                    base.Tables.Add(new supplierDataTable(ds.Tables["supplier"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, global::System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.ReadXml(reader);
                this.InitVars();
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        protected override global::System.Xml.Schema.XmlSchema GetSchemaSerializable() {
            global::System.IO.MemoryStream stream = new global::System.IO.MemoryStream();
            this.WriteXmlSchema(new global::System.Xml.XmlTextWriter(stream, null));
            stream.Position = 0;
            return global::System.Xml.Schema.XmlSchema.Read(new global::System.Xml.XmlTextReader(stream), null);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        internal void InitVars() {
            this.InitVars(true);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        internal void InitVars(bool initTable) {
            this.tablecustomer = ((customerDataTable)(base.Tables["customer"]));
            if ((initTable == true)) {
                if ((this.tablecustomer != null)) {
                    this.tablecustomer.InitVars();
                }
            }
            this.tableitem = ((itemDataTable)(base.Tables["item"]));
            if ((initTable == true)) {
                if ((this.tableitem != null)) {
                    this.tableitem.InitVars();
                }
            }
            this.tablepurchase = ((purchaseDataTable)(base.Tables["purchase"]));
            if ((initTable == true)) {
                if ((this.tablepurchase != null)) {
                    this.tablepurchase.InitVars();
                }
            }
            this.tablesale = ((saleDataTable)(base.Tables["sale"]));
            if ((initTable == true)) {
                if ((this.tablesale != null)) {
                    this.tablesale.InitVars();
                }
            }
            this.tablesupplier = ((supplierDataTable)(base.Tables["supplier"]));
            if ((initTable == true)) {
                if ((this.tablesupplier != null)) {
                    this.tablesupplier.InitVars();
                }
            }
            this.relationFK_purchase_item = this.Relations["FK_purchase_item"];
            this.relationFK_sale_customer = this.Relations["FK_sale_customer"];
            this.relationFK_sale_item = this.Relations["FK_sale_item"];
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        private void InitClass() {
            this.DataSetName = "supermartDataSet1";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/supermartDataSet1.xsd";
            this.EnforceConstraints = true;
            this.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
            this.tablecustomer = new customerDataTable();
            base.Tables.Add(this.tablecustomer);
            this.tableitem = new itemDataTable();
            base.Tables.Add(this.tableitem);
            this.tablepurchase = new purchaseDataTable();
            base.Tables.Add(this.tablepurchase);
            this.tablesale = new saleDataTable();
            base.Tables.Add(this.tablesale);
            this.tablesupplier = new supplierDataTable();
            base.Tables.Add(this.tablesupplier);
            this.relationFK_purchase_item = new global::System.Data.DataRelation("FK_purchase_item", new global::System.Data.DataColumn[] {
                        this.tableitem.item_idColumn}, new global::System.Data.DataColumn[] {
                        this.tablepurchase.item_idColumn}, false);
            this.Relations.Add(this.relationFK_purchase_item);
            this.relationFK_sale_customer = new global::System.Data.DataRelation("FK_sale_customer", new global::System.Data.DataColumn[] {
                        this.tablecustomer.cus_idColumn}, new global::System.Data.DataColumn[] {
                        this.tablesale.cus_idColumn}, false);
            this.Relations.Add(this.relationFK_sale_customer);
            this.relationFK_sale_item = new global::System.Data.DataRelation("FK_sale_item", new global::System.Data.DataColumn[] {
                        this.tableitem.item_idColumn}, new global::System.Data.DataColumn[] {
                        this.tablesale.item_idColumn}, false);
            this.Relations.Add(this.relationFK_sale_item);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        private bool ShouldSerializecustomer() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        private bool ShouldSerializeitem() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        private bool ShouldSerializepurchase() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        private bool ShouldSerializesale() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        private bool ShouldSerializesupplier() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        private void SchemaChanged(object sender, global::System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == global::System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedDataSetSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
            supermartDataSet1 ds = new supermartDataSet1();
            global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
            global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
            global::System.Xml.Schema.XmlSchemaAny any = new global::System.Xml.Schema.XmlSchemaAny();
            any.Namespace = ds.Namespace;
            sequence.Items.Add(any);
            type.Particle = sequence;
            global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
            if (xs.Contains(dsSchema.TargetNamespace)) {
                global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                try {
                    global::System.Xml.Schema.XmlSchema schema = null;
                    dsSchema.Write(s1);
                    for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                        schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                        s2.SetLength(0);
                        schema.Write(s2);
                        if ((s1.Length == s2.Length)) {
                            s1.Position = 0;
                            s2.Position = 0;
                            for (; ((s1.Position != s1.Length) 
                                        && (s1.ReadByte() == s2.ReadByte())); ) {
                                ;
                            }
                            if ((s1.Position == s1.Length)) {
                                return type;
                            }
                        }
                    }
                }
                finally {
                    if ((s1 != null)) {
                        s1.Close();
                    }
                    if ((s2 != null)) {
                        s2.Close();
                    }
                }
            }
            xs.Add(dsSchema);
            return type;
        }
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        public delegate void customerRowChangeEventHandler(object sender, customerRowChangeEvent e);
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        public delegate void itemRowChangeEventHandler(object sender, itemRowChangeEvent e);
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        public delegate void purchaseRowChangeEventHandler(object sender, purchaseRowChangeEvent e);
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        public delegate void saleRowChangeEventHandler(object sender, saleRowChangeEvent e);
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        public delegate void supplierRowChangeEventHandler(object sender, supplierRowChangeEvent e);
        
      
        [global::System.Serializable()]
        [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
        public partial class customerDataTable : global::System.Data.TypedTableBase<customerRow> {
            
            private global::System.Data.DataColumn columncus_id;
            
            private global::System.Data.DataColumn columncus_name;
            
            private global::System.Data.DataColumn columncus_phone;
            
            private global::System.Data.DataColumn columncus_address;
            
            private global::System.Data.DataColumn columnentry_date;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public customerDataTable() {
                this.TableName = "customer";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            internal customerDataTable(global::System.Data.DataTable table) {
                this.TableName = table.TableName;
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected customerDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                    base(info, context) {
                this.InitVars();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn cus_idColumn {
                get {
                    return this.columncus_id;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn cus_nameColumn {
                get {
                    return this.columncus_name;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn cus_phoneColumn {
                get {
                    return this.columncus_phone;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn cus_addressColumn {
                get {
                    return this.columncus_address;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn entry_dateColumn {
                get {
                    return this.columnentry_date;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            [global::System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public customerRow this[int index] {
                get {
                    return ((customerRow)(this.Rows[index]));
                }
            }
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public event customerRowChangeEventHandler customerRowChanging;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public event customerRowChangeEventHandler customerRowChanged;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public event customerRowChangeEventHandler customerRowDeleting;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public event customerRowChangeEventHandler customerRowDeleted;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public void AddcustomerRow(customerRow row) {
                this.Rows.Add(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public customerRow AddcustomerRow(string cus_name, long cus_phone, string cus_address, System.DateTime entry_date) {
                customerRow rowcustomerRow = ((customerRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        null,
                        cus_name,
                        cus_phone,
                        cus_address,
                        entry_date};
                rowcustomerRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowcustomerRow);
                return rowcustomerRow;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public customerRow FindBycus_id(int cus_id) {
                return ((customerRow)(this.Rows.Find(new object[] {
                            cus_id})));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public override global::System.Data.DataTable Clone() {
                customerDataTable cln = ((customerDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override global::System.Data.DataTable CreateInstance() {
                return new customerDataTable();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            internal void InitVars() {
                this.columncus_id = base.Columns["cus_id"];
                this.columncus_name = base.Columns["cus_name"];
                this.columncus_phone = base.Columns["cus_phone"];
                this.columncus_address = base.Columns["cus_address"];
                this.columnentry_date = base.Columns["entry_date"];
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            private void InitClass() {
                this.columncus_id = new global::System.Data.DataColumn("cus_id", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columncus_id);
                this.columncus_name = new global::System.Data.DataColumn("cus_name", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columncus_name);
                this.columncus_phone = new global::System.Data.DataColumn("cus_phone", typeof(long), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columncus_phone);
                this.columncus_address = new global::System.Data.DataColumn("cus_address", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columncus_address);
                this.columnentry_date = new global::System.Data.DataColumn("entry_date", typeof(global::System.DateTime), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnentry_date);
                this.Constraints.Add(new global::System.Data.UniqueConstraint("Constraint1", new global::System.Data.DataColumn[] {
                                this.columncus_id}, true));
                this.columncus_id.AutoIncrement = true;
                this.columncus_id.AutoIncrementSeed = -1;
                this.columncus_id.AutoIncrementStep = -1;
                this.columncus_id.AllowDBNull = false;
                this.columncus_id.ReadOnly = true;
                this.columncus_id.Unique = true;
                this.columncus_name.AllowDBNull = false;
                this.columncus_name.MaxLength = 25;
                this.columncus_address.MaxLength = 25;
                this.columnentry_date.AllowDBNull = false;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public customerRow NewcustomerRow() {
                return ((customerRow)(this.NewRow()));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder) {
                return new customerRow(builder);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override global::System.Type GetRowType() {
                return typeof(customerRow);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.customerRowChanged != null)) {
                    this.customerRowChanged(this, new customerRowChangeEvent(((customerRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.customerRowChanging != null)) {
                    this.customerRowChanging(this, new customerRowChangeEvent(((customerRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.customerRowDeleted != null)) {
                    this.customerRowDeleted(this, new customerRowChangeEvent(((customerRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.customerRowDeleting != null)) {
                    this.customerRowDeleting(this, new customerRowChangeEvent(((customerRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public void RemovecustomerRow(customerRow row) {
                this.Rows.Remove(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
                global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
                global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
                supermartDataSet1 ds = new supermartDataSet1();
                global::System.Xml.Schema.XmlSchemaAny any1 = new global::System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                global::System.Xml.Schema.XmlSchemaAny any2 = new global::System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                global::System.Xml.Schema.XmlSchemaAttribute attribute1 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                global::System.Xml.Schema.XmlSchemaAttribute attribute2 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "customerDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
                if (xs.Contains(dsSchema.TargetNamespace)) {
                    global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                    global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                    try {
                        global::System.Xml.Schema.XmlSchema schema = null;
                        dsSchema.Write(s1);
                        for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                            schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                            s2.SetLength(0);
                            schema.Write(s2);
                            if ((s1.Length == s2.Length)) {
                                s1.Position = 0;
                                s2.Position = 0;
                                for (; ((s1.Position != s1.Length) 
                                            && (s1.ReadByte() == s2.ReadByte())); ) {
                                    ;
                                }
                                if ((s1.Position == s1.Length)) {
                                    return type;
                                }
                            }
                        }
                    }
                    finally {
                        if ((s1 != null)) {
                            s1.Close();
                        }
                        if ((s2 != null)) {
                            s2.Close();
                        }
                    }
                }
                xs.Add(dsSchema);
                return type;
            }
        }
        
       
        [global::System.Serializable()]
        [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
        public partial class itemDataTable : global::System.Data.TypedTableBase<itemRow> {
            
            private global::System.Data.DataColumn columnitem_id;
            
            private global::System.Data.DataColumn columnitem_name;
            
            private global::System.Data.DataColumn columnquantity;
            
            private global::System.Data.DataColumn columnprice;
            
            private global::System.Data.DataColumn columndate;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public itemDataTable() {
                this.TableName = "item";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            internal itemDataTable(global::System.Data.DataTable table) {
                this.TableName = table.TableName;
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected itemDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                    base(info, context) {
                this.InitVars();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn item_idColumn {
                get {
                    return this.columnitem_id;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn item_nameColumn {
                get {
                    return this.columnitem_name;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn quantityColumn {
                get {
                    return this.columnquantity;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn priceColumn {
                get {
                    return this.columnprice;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn dateColumn {
                get {
                    return this.columndate;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            [global::System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public itemRow this[int index] {
                get {
                    return ((itemRow)(this.Rows[index]));
                }
            }
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public event itemRowChangeEventHandler itemRowChanging;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public event itemRowChangeEventHandler itemRowChanged;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public event itemRowChangeEventHandler itemRowDeleting;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public event itemRowChangeEventHandler itemRowDeleted;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public void AdditemRow(itemRow row) {
                this.Rows.Add(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public itemRow AdditemRow(string item_name, int quantity, int price, System.DateTime date) {
                itemRow rowitemRow = ((itemRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        null,
                        item_name,
                        quantity,
                        price,
                        date};
                rowitemRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowitemRow);
                return rowitemRow;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public itemRow FindByitem_id(int item_id) {
                return ((itemRow)(this.Rows.Find(new object[] {
                            item_id})));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public override global::System.Data.DataTable Clone() {
                itemDataTable cln = ((itemDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override global::System.Data.DataTable CreateInstance() {
                return new itemDataTable();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            internal void InitVars() {
                this.columnitem_id = base.Columns["item_id"];
                this.columnitem_name = base.Columns["item_name"];
                this.columnquantity = base.Columns["quantity"];
                this.columnprice = base.Columns["price"];
                this.columndate = base.Columns["date"];
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            private void InitClass() {
                this.columnitem_id = new global::System.Data.DataColumn("item_id", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnitem_id);
                this.columnitem_name = new global::System.Data.DataColumn("item_name", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnitem_name);
                this.columnquantity = new global::System.Data.DataColumn("quantity", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnquantity);
                this.columnprice = new global::System.Data.DataColumn("price", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnprice);
                this.columndate = new global::System.Data.DataColumn("date", typeof(global::System.DateTime), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columndate);
                this.Constraints.Add(new global::System.Data.UniqueConstraint("Constraint1", new global::System.Data.DataColumn[] {
                                this.columnitem_id}, true));
                this.columnitem_id.AutoIncrement = true;
                this.columnitem_id.AutoIncrementSeed = -1;
                this.columnitem_id.AutoIncrementStep = -1;
                this.columnitem_id.AllowDBNull = false;
                this.columnitem_id.ReadOnly = true;
                this.columnitem_id.Unique = true;
                this.columnitem_name.AllowDBNull = false;
                this.columnitem_name.MaxLength = 25;
                this.columnquantity.AllowDBNull = false;
                this.columnprice.AllowDBNull = false;
                this.columndate.AllowDBNull = false;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public itemRow NewitemRow() {
                return ((itemRow)(this.NewRow()));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder) {
                return new itemRow(builder);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override global::System.Type GetRowType() {
                return typeof(itemRow);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.itemRowChanged != null)) {
                    this.itemRowChanged(this, new itemRowChangeEvent(((itemRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.itemRowChanging != null)) {
                    this.itemRowChanging(this, new itemRowChangeEvent(((itemRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.itemRowDeleted != null)) {
                    this.itemRowDeleted(this, new itemRowChangeEvent(((itemRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.itemRowDeleting != null)) {
                    this.itemRowDeleting(this, new itemRowChangeEvent(((itemRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public void RemoveitemRow(itemRow row) {
                this.Rows.Remove(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
                global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
                global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
                supermartDataSet1 ds = new supermartDataSet1();
                global::System.Xml.Schema.XmlSchemaAny any1 = new global::System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                global::System.Xml.Schema.XmlSchemaAny any2 = new global::System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                global::System.Xml.Schema.XmlSchemaAttribute attribute1 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                global::System.Xml.Schema.XmlSchemaAttribute attribute2 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "itemDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
                if (xs.Contains(dsSchema.TargetNamespace)) {
                    global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                    global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                    try {
                        global::System.Xml.Schema.XmlSchema schema = null;
                        dsSchema.Write(s1);
                        for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                            schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                            s2.SetLength(0);
                            schema.Write(s2);
                            if ((s1.Length == s2.Length)) {
                                s1.Position = 0;
                                s2.Position = 0;
                                for (; ((s1.Position != s1.Length) 
                                            && (s1.ReadByte() == s2.ReadByte())); ) {
                                    ;
                                }
                                if ((s1.Position == s1.Length)) {
                                    return type;
                                }
                            }
                        }
                    }
                    finally {
                        if ((s1 != null)) {
                            s1.Close();
                        }
                        if ((s2 != null)) {
                            s2.Close();
                        }
                    }
                }
                xs.Add(dsSchema);
                return type;
            }
        }
        
       
        [global::System.Serializable()]
        [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
        public partial class purchaseDataTable : global::System.Data.TypedTableBase<purchaseRow> {
            
            private global::System.Data.DataColumn columnpurchase_id;
            
            private global::System.Data.DataColumn columnsup_id;
            
            private global::System.Data.DataColumn columnitem_id;
            
            private global::System.Data.DataColumn columncost_price;
            
            private global::System.Data.DataColumn columnquantity;
            
            private global::System.Data.DataColumn columnunit;
            
            private global::System.Data.DataColumn columnentry_date;
            
            private global::System.Data.DataColumn columnselling_price;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public purchaseDataTable() {
                this.TableName = "purchase";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            internal purchaseDataTable(global::System.Data.DataTable table) {
                this.TableName = table.TableName;
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected purchaseDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                    base(info, context) {
                this.InitVars();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn purchase_idColumn {
                get {
                    return this.columnpurchase_id;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn sup_idColumn {
                get {
                    return this.columnsup_id;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn item_idColumn {
                get {
                    return this.columnitem_id;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn cost_priceColumn {
                get {
                    return this.columncost_price;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn quantityColumn {
                get {
                    return this.columnquantity;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn unitColumn {
                get {
                    return this.columnunit;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn entry_dateColumn {
                get {
                    return this.columnentry_date;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn selling_priceColumn {
                get {
                    return this.columnselling_price;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            [global::System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public purchaseRow this[int index] {
                get {
                    return ((purchaseRow)(this.Rows[index]));
                }
            }
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public event purchaseRowChangeEventHandler purchaseRowChanging;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public event purchaseRowChangeEventHandler purchaseRowChanged;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public event purchaseRowChangeEventHandler purchaseRowDeleting;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public event purchaseRowChangeEventHandler purchaseRowDeleted;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public void AddpurchaseRow(purchaseRow row) {
                this.Rows.Add(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public purchaseRow AddpurchaseRow(int sup_id, itemRow parentitemRowByFK_purchase_item, int cost_price, int quantity, int unit, System.DateTime entry_date, int selling_price) {
                purchaseRow rowpurchaseRow = ((purchaseRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        null,
                        sup_id,
                        null,
                        cost_price,
                        quantity,
                        unit,
                        entry_date,
                        selling_price};
                if ((parentitemRowByFK_purchase_item != null)) {
                    columnValuesArray[2] = parentitemRowByFK_purchase_item[0];
                }
                rowpurchaseRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowpurchaseRow);
                return rowpurchaseRow;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public purchaseRow FindBypurchase_id(int purchase_id) {
                return ((purchaseRow)(this.Rows.Find(new object[] {
                            purchase_id})));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public override global::System.Data.DataTable Clone() {
                purchaseDataTable cln = ((purchaseDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override global::System.Data.DataTable CreateInstance() {
                return new purchaseDataTable();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            internal void InitVars() {
                this.columnpurchase_id = base.Columns["purchase_id"];
                this.columnsup_id = base.Columns["sup_id"];
                this.columnitem_id = base.Columns["item_id"];
                this.columncost_price = base.Columns["cost_price"];
                this.columnquantity = base.Columns["quantity"];
                this.columnunit = base.Columns["unit"];
                this.columnentry_date = base.Columns["entry_date"];
                this.columnselling_price = base.Columns["selling_price"];
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            private void InitClass() {
                this.columnpurchase_id = new global::System.Data.DataColumn("purchase_id", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnpurchase_id);
                this.columnsup_id = new global::System.Data.DataColumn("sup_id", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnsup_id);
                this.columnitem_id = new global::System.Data.DataColumn("item_id", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnitem_id);
                this.columncost_price = new global::System.Data.DataColumn("cost_price", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columncost_price);
                this.columnquantity = new global::System.Data.DataColumn("quantity", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnquantity);
                this.columnunit = new global::System.Data.DataColumn("unit", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnunit);
                this.columnentry_date = new global::System.Data.DataColumn("entry_date", typeof(global::System.DateTime), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnentry_date);
                this.columnselling_price = new global::System.Data.DataColumn("selling_price", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnselling_price);
                this.Constraints.Add(new global::System.Data.UniqueConstraint("Constraint1", new global::System.Data.DataColumn[] {
                                this.columnpurchase_id}, true));
                this.columnpurchase_id.AutoIncrement = true;
                this.columnpurchase_id.AutoIncrementSeed = -1;
                this.columnpurchase_id.AutoIncrementStep = -1;
                this.columnpurchase_id.AllowDBNull = false;
                this.columnpurchase_id.ReadOnly = true;
                this.columnpurchase_id.Unique = true;
                this.columnsup_id.AllowDBNull = false;
                this.columnitem_id.AllowDBNull = false;
                this.columncost_price.AllowDBNull = false;
                this.columnquantity.AllowDBNull = false;
                this.columnunit.AllowDBNull = false;
                this.columnentry_date.AllowDBNull = false;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public purchaseRow NewpurchaseRow() {
                return ((purchaseRow)(this.NewRow()));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder) {
                return new purchaseRow(builder);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override global::System.Type GetRowType() {
                return typeof(purchaseRow);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.purchaseRowChanged != null)) {
                    this.purchaseRowChanged(this, new purchaseRowChangeEvent(((purchaseRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.purchaseRowChanging != null)) {
                    this.purchaseRowChanging(this, new purchaseRowChangeEvent(((purchaseRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.purchaseRowDeleted != null)) {
                    this.purchaseRowDeleted(this, new purchaseRowChangeEvent(((purchaseRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.purchaseRowDeleting != null)) {
                    this.purchaseRowDeleting(this, new purchaseRowChangeEvent(((purchaseRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public void RemovepurchaseRow(purchaseRow row) {
                this.Rows.Remove(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
                global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
                global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
                supermartDataSet1 ds = new supermartDataSet1();
                global::System.Xml.Schema.XmlSchemaAny any1 = new global::System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                global::System.Xml.Schema.XmlSchemaAny any2 = new global::System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                global::System.Xml.Schema.XmlSchemaAttribute attribute1 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                global::System.Xml.Schema.XmlSchemaAttribute attribute2 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "purchaseDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
                if (xs.Contains(dsSchema.TargetNamespace)) {
                    global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                    global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                    try {
                        global::System.Xml.Schema.XmlSchema schema = null;
                        dsSchema.Write(s1);
                        for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                            schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                            s2.SetLength(0);
                            schema.Write(s2);
                            if ((s1.Length == s2.Length)) {
                                s1.Position = 0;
                                s2.Position = 0;
                                for (; ((s1.Position != s1.Length) 
                                            && (s1.ReadByte() == s2.ReadByte())); ) {
                                    ;
                                }
                                if ((s1.Position == s1.Length)) {
                                    return type;
                                }
                            }
                        }
                    }
                    finally {
                        if ((s1 != null)) {
                            s1.Close();
                        }
                        if ((s2 != null)) {
                            s2.Close();
                        }
                    }
                }
                xs.Add(dsSchema);
                return type;
            }
        }
        
      
        [global::System.Serializable()]
        [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
        public partial class saleDataTable : global::System.Data.TypedTableBase<saleRow> {
            
            private global::System.Data.DataColumn columnsale_id;
            
            private global::System.Data.DataColumn columncus_id;
            
            private global::System.Data.DataColumn columnitem_id;
            
            private global::System.Data.DataColumn columnquantity;
            
            private global::System.Data.DataColumn columnselling_price;
            
            private global::System.Data.DataColumn columndate;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public saleDataTable() {
                this.TableName = "sale";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            internal saleDataTable(global::System.Data.DataTable table) {
                this.TableName = table.TableName;
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected saleDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                    base(info, context) {
                this.InitVars();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn sale_idColumn {
                get {
                    return this.columnsale_id;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn cus_idColumn {
                get {
                    return this.columncus_id;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn item_idColumn {
                get {
                    return this.columnitem_id;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn quantityColumn {
                get {
                    return this.columnquantity;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn selling_priceColumn {
                get {
                    return this.columnselling_price;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn dateColumn {
                get {
                    return this.columndate;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            [global::System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public saleRow this[int index] {
                get {
                    return ((saleRow)(this.Rows[index]));
                }
            }
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public event saleRowChangeEventHandler saleRowChanging;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public event saleRowChangeEventHandler saleRowChanged;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public event saleRowChangeEventHandler saleRowDeleting;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public event saleRowChangeEventHandler saleRowDeleted;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public void AddsaleRow(saleRow row) {
                this.Rows.Add(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public saleRow AddsaleRow(customerRow parentcustomerRowByFK_sale_customer, itemRow parentitemRowByFK_sale_item, int quantity, int selling_price, System.DateTime date) {
                saleRow rowsaleRow = ((saleRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        null,
                        null,
                        null,
                        quantity,
                        selling_price,
                        date};
                if ((parentcustomerRowByFK_sale_customer != null)) {
                    columnValuesArray[1] = parentcustomerRowByFK_sale_customer[0];
                }
                if ((parentitemRowByFK_sale_item != null)) {
                    columnValuesArray[2] = parentitemRowByFK_sale_item[0];
                }
                rowsaleRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowsaleRow);
                return rowsaleRow;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public saleRow FindBysale_id(int sale_id) {
                return ((saleRow)(this.Rows.Find(new object[] {
                            sale_id})));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public override global::System.Data.DataTable Clone() {
                saleDataTable cln = ((saleDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override global::System.Data.DataTable CreateInstance() {
                return new saleDataTable();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            internal void InitVars() {
                this.columnsale_id = base.Columns["sale_id"];
                this.columncus_id = base.Columns["cus_id"];
                this.columnitem_id = base.Columns["item_id"];
                this.columnquantity = base.Columns["quantity"];
                this.columnselling_price = base.Columns["selling_price"];
                this.columndate = base.Columns["date"];
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            private void InitClass() {
                this.columnsale_id = new global::System.Data.DataColumn("sale_id", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnsale_id);
                this.columncus_id = new global::System.Data.DataColumn("cus_id", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columncus_id);
                this.columnitem_id = new global::System.Data.DataColumn("item_id", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnitem_id);
                this.columnquantity = new global::System.Data.DataColumn("quantity", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnquantity);
                this.columnselling_price = new global::System.Data.DataColumn("selling_price", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnselling_price);
                this.columndate = new global::System.Data.DataColumn("date", typeof(global::System.DateTime), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columndate);
                this.Constraints.Add(new global::System.Data.UniqueConstraint("Constraint1", new global::System.Data.DataColumn[] {
                                this.columnsale_id}, true));
                this.columnsale_id.AutoIncrement = true;
                this.columnsale_id.AutoIncrementSeed = -1;
                this.columnsale_id.AutoIncrementStep = -1;
                this.columnsale_id.AllowDBNull = false;
                this.columnsale_id.ReadOnly = true;
                this.columnsale_id.Unique = true;
                this.columncus_id.AllowDBNull = false;
                this.columnitem_id.AllowDBNull = false;
                this.columnquantity.AllowDBNull = false;
                this.columnselling_price.AllowDBNull = false;
                this.columndate.AllowDBNull = false;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public saleRow NewsaleRow() {
                return ((saleRow)(this.NewRow()));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder) {
                return new saleRow(builder);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override global::System.Type GetRowType() {
                return typeof(saleRow);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.saleRowChanged != null)) {
                    this.saleRowChanged(this, new saleRowChangeEvent(((saleRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.saleRowChanging != null)) {
                    this.saleRowChanging(this, new saleRowChangeEvent(((saleRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.saleRowDeleted != null)) {
                    this.saleRowDeleted(this, new saleRowChangeEvent(((saleRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.saleRowDeleting != null)) {
                    this.saleRowDeleting(this, new saleRowChangeEvent(((saleRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public void RemovesaleRow(saleRow row) {
                this.Rows.Remove(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
                global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
                global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
                supermartDataSet1 ds = new supermartDataSet1();
                global::System.Xml.Schema.XmlSchemaAny any1 = new global::System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                global::System.Xml.Schema.XmlSchemaAny any2 = new global::System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                global::System.Xml.Schema.XmlSchemaAttribute attribute1 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                global::System.Xml.Schema.XmlSchemaAttribute attribute2 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "saleDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
                if (xs.Contains(dsSchema.TargetNamespace)) {
                    global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                    global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                    try {
                        global::System.Xml.Schema.XmlSchema schema = null;
                        dsSchema.Write(s1);
                        for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                            schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                            s2.SetLength(0);
                            schema.Write(s2);
                            if ((s1.Length == s2.Length)) {
                                s1.Position = 0;
                                s2.Position = 0;
                                for (; ((s1.Position != s1.Length) 
                                            && (s1.ReadByte() == s2.ReadByte())); ) {
                                    ;
                                }
                                if ((s1.Position == s1.Length)) {
                                    return type;
                                }
                            }
                        }
                    }
                    finally {
                        if ((s1 != null)) {
                            s1.Close();
                        }
                        if ((s2 != null)) {
                            s2.Close();
                        }
                    }
                }
                xs.Add(dsSchema);
                return type;
            }
        }
        
      
        [global::System.Serializable()]
        [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
        public partial class supplierDataTable : global::System.Data.TypedTableBase<supplierRow> {
            
            private global::System.Data.DataColumn columnsup_id;
            
            private global::System.Data.DataColumn columnsup_address;
            
            private global::System.Data.DataColumn columnsup_phone;
            
            private global::System.Data.DataColumn columnentry_date;
            
            private global::System.Data.DataColumn columnsup_name;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public supplierDataTable() {
                this.TableName = "supplier";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            internal supplierDataTable(global::System.Data.DataTable table) {
                this.TableName = table.TableName;
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected supplierDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                    base(info, context) {
                this.InitVars();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn sup_idColumn {
                get {
                    return this.columnsup_id;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn sup_addressColumn {
                get {
                    return this.columnsup_address;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn sup_phoneColumn {
                get {
                    return this.columnsup_phone;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn entry_dateColumn {
                get {
                    return this.columnentry_date;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn sup_nameColumn {
                get {
                    return this.columnsup_name;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            [global::System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public supplierRow this[int index] {
                get {
                    return ((supplierRow)(this.Rows[index]));
                }
            }
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public event supplierRowChangeEventHandler supplierRowChanging;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public event supplierRowChangeEventHandler supplierRowChanged;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public event supplierRowChangeEventHandler supplierRowDeleting;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public event supplierRowChangeEventHandler supplierRowDeleted;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public void AddsupplierRow(supplierRow row) {
                this.Rows.Add(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public supplierRow AddsupplierRow(string sup_address, string sup_phone, System.DateTime entry_date, string sup_name) {
                supplierRow rowsupplierRow = ((supplierRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        null,
                        sup_address,
                        sup_phone,
                        entry_date,
                        sup_name};
                rowsupplierRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowsupplierRow);
                return rowsupplierRow;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public supplierRow FindBysup_id(int sup_id) {
                return ((supplierRow)(this.Rows.Find(new object[] {
                            sup_id})));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public override global::System.Data.DataTable Clone() {
                supplierDataTable cln = ((supplierDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override global::System.Data.DataTable CreateInstance() {
                return new supplierDataTable();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            internal void InitVars() {
                this.columnsup_id = base.Columns["sup_id"];
                this.columnsup_address = base.Columns["sup_address"];
                this.columnsup_phone = base.Columns["sup_phone"];
                this.columnentry_date = base.Columns["entry_date"];
                this.columnsup_name = base.Columns["sup_name"];
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            private void InitClass() {
                this.columnsup_id = new global::System.Data.DataColumn("sup_id", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnsup_id);
                this.columnsup_address = new global::System.Data.DataColumn("sup_address", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnsup_address);
                this.columnsup_phone = new global::System.Data.DataColumn("sup_phone", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnsup_phone);
                this.columnentry_date = new global::System.Data.DataColumn("entry_date", typeof(global::System.DateTime), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnentry_date);
                this.columnsup_name = new global::System.Data.DataColumn("sup_name", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnsup_name);
                this.Constraints.Add(new global::System.Data.UniqueConstraint("Constraint1", new global::System.Data.DataColumn[] {
                                this.columnsup_id}, true));
                this.columnsup_id.AutoIncrement = true;
                this.columnsup_id.AutoIncrementSeed = -1;
                this.columnsup_id.AutoIncrementStep = -1;
                this.columnsup_id.AllowDBNull = false;
                this.columnsup_id.ReadOnly = true;
                this.columnsup_id.Unique = true;
                this.columnsup_address.MaxLength = 25;
                this.columnsup_phone.MaxLength = 25;
                this.columnentry_date.AllowDBNull = false;
                this.columnsup_name.MaxLength = 25;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public supplierRow NewsupplierRow() {
                return ((supplierRow)(this.NewRow()));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder) {
                return new supplierRow(builder);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override global::System.Type GetRowType() {
                return typeof(supplierRow);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.supplierRowChanged != null)) {
                    this.supplierRowChanged(this, new supplierRowChangeEvent(((supplierRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.supplierRowChanging != null)) {
                    this.supplierRowChanging(this, new supplierRowChangeEvent(((supplierRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.supplierRowDeleted != null)) {
                    this.supplierRowDeleted(this, new supplierRowChangeEvent(((supplierRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.supplierRowDeleting != null)) {
                    this.supplierRowDeleting(this, new supplierRowChangeEvent(((supplierRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public void RemovesupplierRow(supplierRow row) {
                this.Rows.Remove(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
                global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
                global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
                supermartDataSet1 ds = new supermartDataSet1();
                global::System.Xml.Schema.XmlSchemaAny any1 = new global::System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                global::System.Xml.Schema.XmlSchemaAny any2 = new global::System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                global::System.Xml.Schema.XmlSchemaAttribute attribute1 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                global::System.Xml.Schema.XmlSchemaAttribute attribute2 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "supplierDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
                if (xs.Contains(dsSchema.TargetNamespace)) {
                    global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                    global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                    try {
                        global::System.Xml.Schema.XmlSchema schema = null;
                        dsSchema.Write(s1);
                        for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                            schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                            s2.SetLength(0);
                            schema.Write(s2);
                            if ((s1.Length == s2.Length)) {
                                s1.Position = 0;
                                s2.Position = 0;
                                for (; ((s1.Position != s1.Length) 
                                            && (s1.ReadByte() == s2.ReadByte())); ) {
                                    ;
                                }
                                if ((s1.Position == s1.Length)) {
                                    return type;
                                }
                            }
                        }
                    }
                    finally {
                        if ((s1 != null)) {
                            s1.Close();
                        }
                        if ((s2 != null)) {
                            s2.Close();
                        }
                    }
                }
                xs.Add(dsSchema);
                return type;
            }
        }
        
      
        public partial class customerRow : global::System.Data.DataRow {
            
            private customerDataTable tablecustomer;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            internal customerRow(global::System.Data.DataRowBuilder rb) : 
                    base(rb) {
                this.tablecustomer = ((customerDataTable)(this.Table));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public int cus_id {
                get {
                    return ((int)(this[this.tablecustomer.cus_idColumn]));
                }
                set {
                    this[this.tablecustomer.cus_idColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public string cus_name {
                get {
                    return ((string)(this[this.tablecustomer.cus_nameColumn]));
                }
                set {
                    this[this.tablecustomer.cus_nameColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public long cus_phone {
                get {
                    try {
                        return ((long)(this[this.tablecustomer.cus_phoneColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'cus_phone\' in table \'customer\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tablecustomer.cus_phoneColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public string cus_address {
                get {
                    try {
                        return ((string)(this[this.tablecustomer.cus_addressColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'cus_address\' in table \'customer\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tablecustomer.cus_addressColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public System.DateTime entry_date {
                get {
                    return ((global::System.DateTime)(this[this.tablecustomer.entry_dateColumn]));
                }
                set {
                    this[this.tablecustomer.entry_dateColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public bool Iscus_phoneNull() {
                return this.IsNull(this.tablecustomer.cus_phoneColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public void Setcus_phoneNull() {
                this[this.tablecustomer.cus_phoneColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public bool Iscus_addressNull() {
                return this.IsNull(this.tablecustomer.cus_addressColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public void Setcus_addressNull() {
                this[this.tablecustomer.cus_addressColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public saleRow[] GetsaleRows() {
                if ((this.Table.ChildRelations["FK_sale_customer"] == null)) {
                    return new saleRow[0];
                }
                else {
                    return ((saleRow[])(base.GetChildRows(this.Table.ChildRelations["FK_sale_customer"])));
                }
            }
        }
        
      
        public partial class itemRow : global::System.Data.DataRow {
            
            private itemDataTable tableitem;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            internal itemRow(global::System.Data.DataRowBuilder rb) : 
                    base(rb) {
                this.tableitem = ((itemDataTable)(this.Table));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public int item_id {
                get {
                    return ((int)(this[this.tableitem.item_idColumn]));
                }
                set {
                    this[this.tableitem.item_idColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public string item_name {
                get {
                    return ((string)(this[this.tableitem.item_nameColumn]));
                }
                set {
                    this[this.tableitem.item_nameColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public int quantity {
                get {
                    return ((int)(this[this.tableitem.quantityColumn]));
                }
                set {
                    this[this.tableitem.quantityColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public int price {
                get {
                    return ((int)(this[this.tableitem.priceColumn]));
                }
                set {
                    this[this.tableitem.priceColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public System.DateTime date {
                get {
                    return ((global::System.DateTime)(this[this.tableitem.dateColumn]));
                }
                set {
                    this[this.tableitem.dateColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public purchaseRow[] GetpurchaseRows() {
                if ((this.Table.ChildRelations["FK_purchase_item"] == null)) {
                    return new purchaseRow[0];
                }
                else {
                    return ((purchaseRow[])(base.GetChildRows(this.Table.ChildRelations["FK_purchase_item"])));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public saleRow[] GetsaleRows() {
                if ((this.Table.ChildRelations["FK_sale_item"] == null)) {
                    return new saleRow[0];
                }
                else {
                    return ((saleRow[])(base.GetChildRows(this.Table.ChildRelations["FK_sale_item"])));
                }
            }
        }
        
       
        public partial class purchaseRow : global::System.Data.DataRow {
            
            private purchaseDataTable tablepurchase;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            internal purchaseRow(global::System.Data.DataRowBuilder rb) : 
                    base(rb) {
                this.tablepurchase = ((purchaseDataTable)(this.Table));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public int purchase_id {
                get {
                    return ((int)(this[this.tablepurchase.purchase_idColumn]));
                }
                set {
                    this[this.tablepurchase.purchase_idColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public int sup_id {
                get {
                    return ((int)(this[this.tablepurchase.sup_idColumn]));
                }
                set {
                    this[this.tablepurchase.sup_idColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public int item_id {
                get {
                    return ((int)(this[this.tablepurchase.item_idColumn]));
                }
                set {
                    this[this.tablepurchase.item_idColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public int cost_price {
                get {
                    return ((int)(this[this.tablepurchase.cost_priceColumn]));
                }
                set {
                    this[this.tablepurchase.cost_priceColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public int quantity {
                get {
                    return ((int)(this[this.tablepurchase.quantityColumn]));
                }
                set {
                    this[this.tablepurchase.quantityColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public int unit {
                get {
                    return ((int)(this[this.tablepurchase.unitColumn]));
                }
                set {
                    this[this.tablepurchase.unitColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public System.DateTime entry_date {
                get {
                    return ((global::System.DateTime)(this[this.tablepurchase.entry_dateColumn]));
                }
                set {
                    this[this.tablepurchase.entry_dateColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public int selling_price {
                get {
                    try {
                        return ((int)(this[this.tablepurchase.selling_priceColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'selling_price\' in table \'purchase\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tablepurchase.selling_priceColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public itemRow itemRow {
                get {
                    return ((itemRow)(this.GetParentRow(this.Table.ParentRelations["FK_purchase_item"])));
                }
                set {
                    this.SetParentRow(value, this.Table.ParentRelations["FK_purchase_item"]);
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public bool Isselling_priceNull() {
                return this.IsNull(this.tablepurchase.selling_priceColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public void Setselling_priceNull() {
                this[this.tablepurchase.selling_priceColumn] = global::System.Convert.DBNull;
            }
        }
       
        public partial class saleRow : global::System.Data.DataRow {
            
            private saleDataTable tablesale;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            internal saleRow(global::System.Data.DataRowBuilder rb) : 
                    base(rb) {
                this.tablesale = ((saleDataTable)(this.Table));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public int sale_id {
                get {
                    return ((int)(this[this.tablesale.sale_idColumn]));
                }
                set {
                    this[this.tablesale.sale_idColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public int cus_id {
                get {
                    return ((int)(this[this.tablesale.cus_idColumn]));
                }
                set {
                    this[this.tablesale.cus_idColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public int item_id {
                get {
                    return ((int)(this[this.tablesale.item_idColumn]));
                }
                set {
                    this[this.tablesale.item_idColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public int quantity {
                get {
                    return ((int)(this[this.tablesale.quantityColumn]));
                }
                set {
                    this[this.tablesale.quantityColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public int selling_price {
                get {
                    return ((int)(this[this.tablesale.selling_priceColumn]));
                }
                set {
                    this[this.tablesale.selling_priceColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public System.DateTime date {
                get {
                    return ((global::System.DateTime)(this[this.tablesale.dateColumn]));
                }
                set {
                    this[this.tablesale.dateColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public customerRow customerRow {
                get {
                    return ((customerRow)(this.GetParentRow(this.Table.ParentRelations["FK_sale_customer"])));
                }
                set {
                    this.SetParentRow(value, this.Table.ParentRelations["FK_sale_customer"]);
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public itemRow itemRow {
                get {
                    return ((itemRow)(this.GetParentRow(this.Table.ParentRelations["FK_sale_item"])));
                }
                set {
                    this.SetParentRow(value, this.Table.ParentRelations["FK_sale_item"]);
                }
            }
        }
      
        public partial class supplierRow : global::System.Data.DataRow {
            
            private supplierDataTable tablesupplier;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            internal supplierRow(global::System.Data.DataRowBuilder rb) : 
                    base(rb) {
                this.tablesupplier = ((supplierDataTable)(this.Table));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public int sup_id {
                get {
                    return ((int)(this[this.tablesupplier.sup_idColumn]));
                }
                set {
                    this[this.tablesupplier.sup_idColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public string sup_address {
                get {
                    try {
                        return ((string)(this[this.tablesupplier.sup_addressColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'sup_address\' in table \'supplier\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tablesupplier.sup_addressColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public string sup_phone {
                get {
                    try {
                        return ((string)(this[this.tablesupplier.sup_phoneColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'sup_phone\' in table \'supplier\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tablesupplier.sup_phoneColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public System.DateTime entry_date {
                get {
                    return ((global::System.DateTime)(this[this.tablesupplier.entry_dateColumn]));
                }
                set {
                    this[this.tablesupplier.entry_dateColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public string sup_name {
                get {
                    try {
                        return ((string)(this[this.tablesupplier.sup_nameColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'sup_name\' in table \'supplier\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tablesupplier.sup_nameColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public bool Issup_addressNull() {
                return this.IsNull(this.tablesupplier.sup_addressColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public void Setsup_addressNull() {
                this[this.tablesupplier.sup_addressColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public bool Issup_phoneNull() {
                return this.IsNull(this.tablesupplier.sup_phoneColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public void Setsup_phoneNull() {
                this[this.tablesupplier.sup_phoneColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public bool Issup_nameNull() {
                return this.IsNull(this.tablesupplier.sup_nameColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public void Setsup_nameNull() {
                this[this.tablesupplier.sup_nameColumn] = global::System.Convert.DBNull;
            }
        }
       
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        public class customerRowChangeEvent : global::System.EventArgs {
            
            private customerRow eventRow;
            
            private global::System.Data.DataRowAction eventAction;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public customerRowChangeEvent(customerRow row, global::System.Data.DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public customerRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
        
     
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        public class itemRowChangeEvent : global::System.EventArgs {
            
            private itemRow eventRow;
            
            private global::System.Data.DataRowAction eventAction;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public itemRowChangeEvent(itemRow row, global::System.Data.DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public itemRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
        
      
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        public class purchaseRowChangeEvent : global::System.EventArgs {
            
            private purchaseRow eventRow;
            
            private global::System.Data.DataRowAction eventAction;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public purchaseRowChangeEvent(purchaseRow row, global::System.Data.DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public purchaseRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
        
       
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        public class saleRowChangeEvent : global::System.EventArgs {
            
            private saleRow eventRow;
            
            private global::System.Data.DataRowAction eventAction;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public saleRowChangeEvent(saleRow row, global::System.Data.DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public saleRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
        
       
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        public class supplierRowChangeEvent : global::System.EventArgs {
            
            private supplierRow eventRow;
            
            private global::System.Data.DataRowAction eventAction;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public supplierRowChangeEvent(supplierRow row, global::System.Data.DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public supplierRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
    }
}
namespace inventory.supermartDataSet1TableAdapters {
    
    
 
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.ComponentModel.DataObjectAttribute(true)]
    [global::System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" +
        ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
    public partial class customerTableAdapter : global::System.ComponentModel.Component {
        
        private global::System.Data.SqlClient.SqlDataAdapter _adapter;
        
        private global::System.Data.SqlClient.SqlConnection _connection;
        
        private global::System.Data.SqlClient.SqlTransaction _transaction;
        
        private global::System.Data.SqlClient.SqlCommand[] _commandCollection;
        
        private bool _clearBeforeFill;
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        public customerTableAdapter() {
            this.ClearBeforeFill = true;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        protected internal global::System.Data.SqlClient.SqlDataAdapter Adapter {
            get {
                if ((this._adapter == null)) {
                    this.InitAdapter();
                }
                return this._adapter;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        internal global::System.Data.SqlClient.SqlConnection Connection {
            get {
                if ((this._connection == null)) {
                    this.InitConnection();
                }
                return this._connection;
            }
            set {
                this._connection = value;
                if ((this.Adapter.InsertCommand != null)) {
                    this.Adapter.InsertCommand.Connection = value;
                }
                if ((this.Adapter.DeleteCommand != null)) {
                    this.Adapter.DeleteCommand.Connection = value;
                }
                if ((this.Adapter.UpdateCommand != null)) {
                    this.Adapter.UpdateCommand.Connection = value;
                }
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1)) {
                    if ((this.CommandCollection[i] != null)) {
                        ((global::System.Data.SqlClient.SqlCommand)(this.CommandCollection[i])).Connection = value;
                    }
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        internal global::System.Data.SqlClient.SqlTransaction Transaction {
            get {
                return this._transaction;
            }
            set {
                this._transaction = value;
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1)) {
                    this.CommandCollection[i].Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.DeleteCommand != null))) {
                    this.Adapter.DeleteCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.InsertCommand != null))) {
                    this.Adapter.InsertCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.UpdateCommand != null))) {
                    this.Adapter.UpdateCommand.Transaction = this._transaction;
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        protected global::System.Data.SqlClient.SqlCommand[] CommandCollection {
            get {
                if ((this._commandCollection == null)) {
                    this.InitCommandCollection();
                }
                return this._commandCollection;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        public bool ClearBeforeFill {
            get {
                return this._clearBeforeFill;
            }
            set {
                this._clearBeforeFill = value;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        private void InitAdapter() {
            this._adapter = new global::System.Data.SqlClient.SqlDataAdapter();
            global::System.Data.Common.DataTableMapping tableMapping = new global::System.Data.Common.DataTableMapping();
            tableMapping.SourceTable = "Table";
            tableMapping.DataSetTable = "customer";
            tableMapping.ColumnMappings.Add("cus_id", "cus_id");
            tableMapping.ColumnMappings.Add("cus_name", "cus_name");
            tableMapping.ColumnMappings.Add("cus_phone", "cus_phone");
            tableMapping.ColumnMappings.Add("cus_address", "cus_address");
            tableMapping.ColumnMappings.Add("entry_date", "entry_date");
            this._adapter.TableMappings.Add(tableMapping);
            this._adapter.DeleteCommand = new global::System.Data.SqlClient.SqlCommand();
            this._adapter.DeleteCommand.Connection = this.Connection;
            this._adapter.DeleteCommand.CommandText = @"DELETE FROM [dbo].[customer] WHERE (([cus_id] = @Original_cus_id) AND ([cus_name] = @Original_cus_name) AND ((@IsNull_cus_phone = 1 AND [cus_phone] IS NULL) OR ([cus_phone] = @Original_cus_phone)) AND ((@IsNull_cus_address = 1 AND [cus_address] IS NULL) OR ([cus_address] = @Original_cus_address)) AND ([entry_date] = @Original_entry_date))";
            this._adapter.DeleteCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_cus_id", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "cus_id", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_cus_name", global::System.Data.SqlDbType.VarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "cus_name", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_cus_phone", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "cus_phone", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_cus_phone", global::System.Data.SqlDbType.BigInt, 0, global::System.Data.ParameterDirection.Input, 0, 0, "cus_phone", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_cus_address", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "cus_address", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_cus_address", global::System.Data.SqlDbType.VarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "cus_address", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_entry_date", global::System.Data.SqlDbType.Date, 0, global::System.Data.ParameterDirection.Input, 0, 0, "entry_date", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.InsertCommand = new global::System.Data.SqlClient.SqlCommand();
            this._adapter.InsertCommand.Connection = this.Connection;
            this._adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[customer] ([cus_name], [cus_phone], [cus_address], [entry_date" +
                "]) VALUES (@cus_name, @cus_phone, @cus_address, @entry_date);\r\nSELECT cus_id, cu" +
                "s_name, cus_phone, cus_address, entry_date FROM customer WHERE (cus_id = SCOPE_I" +
                "DENTITY())";
            this._adapter.InsertCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@cus_name", global::System.Data.SqlDbType.VarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "cus_name", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@cus_phone", global::System.Data.SqlDbType.BigInt, 0, global::System.Data.ParameterDirection.Input, 0, 0, "cus_phone", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@cus_address", global::System.Data.SqlDbType.VarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "cus_address", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@entry_date", global::System.Data.SqlDbType.Date, 0, global::System.Data.ParameterDirection.Input, 0, 0, "entry_date", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand = new global::System.Data.SqlClient.SqlCommand();
            this._adapter.UpdateCommand.Connection = this.Connection;
            this._adapter.UpdateCommand.CommandText = @"UPDATE [dbo].[customer] SET [cus_name] = @cus_name, [cus_phone] = @cus_phone, [cus_address] = @cus_address, [entry_date] = @entry_date WHERE (([cus_id] = @Original_cus_id) AND ([cus_name] = @Original_cus_name) AND ((@IsNull_cus_phone = 1 AND [cus_phone] IS NULL) OR ([cus_phone] = @Original_cus_phone)) AND ((@IsNull_cus_address = 1 AND [cus_address] IS NULL) OR ([cus_address] = @Original_cus_address)) AND ([entry_date] = @Original_entry_date));
SELECT cus_id, cus_name, cus_phone, cus_address, entry_date FROM customer WHERE (cus_id = @cus_id)";
            this._adapter.UpdateCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@cus_name", global::System.Data.SqlDbType.VarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "cus_name", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@cus_phone", global::System.Data.SqlDbType.BigInt, 0, global::System.Data.ParameterDirection.Input, 0, 0, "cus_phone", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@cus_address", global::System.Data.SqlDbType.VarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "cus_address", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@entry_date", global::System.Data.SqlDbType.Date, 0, global::System.Data.ParameterDirection.Input, 0, 0, "entry_date", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_cus_id", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "cus_id", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_cus_name", global::System.Data.SqlDbType.VarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "cus_name", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_cus_phone", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "cus_phone", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_cus_phone", global::System.Data.SqlDbType.BigInt, 0, global::System.Data.ParameterDirection.Input, 0, 0, "cus_phone", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_cus_address", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "cus_address", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_cus_address", global::System.Data.SqlDbType.VarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "cus_address", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_entry_date", global::System.Data.SqlDbType.Date, 0, global::System.Data.ParameterDirection.Input, 0, 0, "entry_date", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@cus_id", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.Input, 0, 0, "cus_id", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        private void InitConnection() {
            this._connection = new global::System.Data.SqlClient.SqlConnection();
            this._connection.ConnectionString = global::inventory.Properties.Settings.Default.supermartConnectionString;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        private void InitCommandCollection() {
            this._commandCollection = new global::System.Data.SqlClient.SqlCommand[1];
            this._commandCollection[0] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[0].Connection = this.Connection;
            this._commandCollection[0].CommandText = "SELECT cus_id, cus_name, cus_phone, cus_address, entry_date FROM dbo.customer";
            this._commandCollection[0].CommandType = global::System.Data.CommandType.Text;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Fill, true)]
        public virtual int Fill(supermartDataSet1.customerDataTable dataTable) {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            if ((this.ClearBeforeFill == true)) {
                dataTable.Clear();
            }
            int returnValue = this.Adapter.Fill(dataTable);
            return returnValue;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Select, true)]
        public virtual supermartDataSet1.customerDataTable GetData() {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            supermartDataSet1.customerDataTable dataTable = new supermartDataSet1.customerDataTable();
            this.Adapter.Fill(dataTable);
            return dataTable;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(supermartDataSet1.customerDataTable dataTable) {
            return this.Adapter.Update(dataTable);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(supermartDataSet1 dataSet) {
            return this.Adapter.Update(dataSet, "customer");
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow dataRow) {
            return this.Adapter.Update(new global::System.Data.DataRow[] {
                        dataRow});
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow[] dataRows) {
            return this.Adapter.Update(dataRows);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(int Original_cus_id, string Original_cus_name, global::System.Nullable<long> Original_cus_phone, string Original_cus_address, System.DateTime Original_entry_date) {
            this.Adapter.DeleteCommand.Parameters[0].Value = ((int)(Original_cus_id));
            if ((Original_cus_name == null)) {
                throw new global::System.ArgumentNullException("Original_cus_name");
            }
            else {
                this.Adapter.DeleteCommand.Parameters[1].Value = ((string)(Original_cus_name));
            }
            if ((Original_cus_phone.HasValue == true)) {
                this.Adapter.DeleteCommand.Parameters[2].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[3].Value = ((long)(Original_cus_phone.Value));
            }
            else {
                this.Adapter.DeleteCommand.Parameters[2].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[3].Value = global::System.DBNull.Value;
            }
            if ((Original_cus_address == null)) {
                this.Adapter.DeleteCommand.Parameters[4].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[5].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.DeleteCommand.Parameters[4].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[5].Value = ((string)(Original_cus_address));
            }
            this.Adapter.DeleteCommand.Parameters[6].Value = ((System.DateTime)(Original_entry_date));
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.DeleteCommand.Connection.State;
            if (((this.Adapter.DeleteCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.DeleteCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.DeleteCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.DeleteCommand.Connection.Close();
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(string cus_name, global::System.Nullable<long> cus_phone, string cus_address, System.DateTime entry_date) {
            if ((cus_name == null)) {
                throw new global::System.ArgumentNullException("cus_name");
            }
            else {
                this.Adapter.InsertCommand.Parameters[0].Value = ((string)(cus_name));
            }
            if ((cus_phone.HasValue == true)) {
                this.Adapter.InsertCommand.Parameters[1].Value = ((long)(cus_phone.Value));
            }
            else {
                this.Adapter.InsertCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            if ((cus_address == null)) {
                this.Adapter.InsertCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.InsertCommand.Parameters[2].Value = ((string)(cus_address));
            }
            this.Adapter.InsertCommand.Parameters[3].Value = ((System.DateTime)(entry_date));
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.InsertCommand.Connection.State;
            if (((this.Adapter.InsertCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.InsertCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.InsertCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.InsertCommand.Connection.Close();
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(string cus_name, global::System.Nullable<long> cus_phone, string cus_address, System.DateTime entry_date, int Original_cus_id, string Original_cus_name, global::System.Nullable<long> Original_cus_phone, string Original_cus_address, System.DateTime Original_entry_date, int cus_id) {
            if ((cus_name == null)) {
                throw new global::System.ArgumentNullException("cus_name");
            }
            else {
                this.Adapter.UpdateCommand.Parameters[0].Value = ((string)(cus_name));
            }
            if ((cus_phone.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[1].Value = ((long)(cus_phone.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            if ((cus_address == null)) {
                this.Adapter.UpdateCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[2].Value = ((string)(cus_address));
            }
            this.Adapter.UpdateCommand.Parameters[3].Value = ((System.DateTime)(entry_date));
            this.Adapter.UpdateCommand.Parameters[4].Value = ((int)(Original_cus_id));
            if ((Original_cus_name == null)) {
                throw new global::System.ArgumentNullException("Original_cus_name");
            }
            else {
                this.Adapter.UpdateCommand.Parameters[5].Value = ((string)(Original_cus_name));
            }
            if ((Original_cus_phone.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[6].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[7].Value = ((long)(Original_cus_phone.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[6].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[7].Value = global::System.DBNull.Value;
            }
            if ((Original_cus_address == null)) {
                this.Adapter.UpdateCommand.Parameters[8].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[9].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[8].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[9].Value = ((string)(Original_cus_address));
            }
            this.Adapter.UpdateCommand.Parameters[10].Value = ((System.DateTime)(Original_entry_date));
            this.Adapter.UpdateCommand.Parameters[11].Value = ((int)(cus_id));
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.UpdateCommand.Connection.State;
            if (((this.Adapter.UpdateCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.UpdateCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.UpdateCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.UpdateCommand.Connection.Close();
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(string cus_name, global::System.Nullable<long> cus_phone, string cus_address, System.DateTime entry_date, int Original_cus_id, string Original_cus_name, global::System.Nullable<long> Original_cus_phone, string Original_cus_address, System.DateTime Original_entry_date) {
            return this.Update(cus_name, cus_phone, cus_address, entry_date, Original_cus_id, Original_cus_name, Original_cus_phone, Original_cus_address, Original_entry_date, Original_cus_id);
        }
    }
   
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.ComponentModel.DataObjectAttribute(true)]
    [global::System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" +
        ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
    public partial class itemTableAdapter : global::System.ComponentModel.Component {
        
        private global::System.Data.SqlClient.SqlDataAdapter _adapter;
        
        private global::System.Data.SqlClient.SqlConnection _connection;
        
        private global::System.Data.SqlClient.SqlTransaction _transaction;
        
        private global::System.Data.SqlClient.SqlCommand[] _commandCollection;
        
        private bool _clearBeforeFill;
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        public itemTableAdapter() {
            this.ClearBeforeFill = true;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        protected internal global::System.Data.SqlClient.SqlDataAdapter Adapter {
            get {
                if ((this._adapter == null)) {
                    this.InitAdapter();
                }
                return this._adapter;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        internal global::System.Data.SqlClient.SqlConnection Connection {
            get {
                if ((this._connection == null)) {
                    this.InitConnection();
                }
                return this._connection;
            }
            set {
                this._connection = value;
                if ((this.Adapter.InsertCommand != null)) {
                    this.Adapter.InsertCommand.Connection = value;
                }
                if ((this.Adapter.DeleteCommand != null)) {
                    this.Adapter.DeleteCommand.Connection = value;
                }
                if ((this.Adapter.UpdateCommand != null)) {
                    this.Adapter.UpdateCommand.Connection = value;
                }
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1)) {
                    if ((this.CommandCollection[i] != null)) {
                        ((global::System.Data.SqlClient.SqlCommand)(this.CommandCollection[i])).Connection = value;
                    }
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        internal global::System.Data.SqlClient.SqlTransaction Transaction {
            get {
                return this._transaction;
            }
            set {
                this._transaction = value;
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1)) {
                    this.CommandCollection[i].Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.DeleteCommand != null))) {
                    this.Adapter.DeleteCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.InsertCommand != null))) {
                    this.Adapter.InsertCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.UpdateCommand != null))) {
                    this.Adapter.UpdateCommand.Transaction = this._transaction;
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        protected global::System.Data.SqlClient.SqlCommand[] CommandCollection {
            get {
                if ((this._commandCollection == null)) {
                    this.InitCommandCollection();
                }
                return this._commandCollection;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        public bool ClearBeforeFill {
            get {
                return this._clearBeforeFill;
            }
            set {
                this._clearBeforeFill = value;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        private void InitAdapter() {
            this._adapter = new global::System.Data.SqlClient.SqlDataAdapter();
            global::System.Data.Common.DataTableMapping tableMapping = new global::System.Data.Common.DataTableMapping();
            tableMapping.SourceTable = "Table";
            tableMapping.DataSetTable = "item";
            tableMapping.ColumnMappings.Add("item_id", "item_id");
            tableMapping.ColumnMappings.Add("item_name", "item_name");
            tableMapping.ColumnMappings.Add("quantity", "quantity");
            tableMapping.ColumnMappings.Add("price", "price");
            tableMapping.ColumnMappings.Add("date", "date");
            this._adapter.TableMappings.Add(tableMapping);
            this._adapter.DeleteCommand = new global::System.Data.SqlClient.SqlCommand();
            this._adapter.DeleteCommand.Connection = this.Connection;
            this._adapter.DeleteCommand.CommandText = "DELETE FROM [dbo].[item] WHERE (([item_id] = @Original_item_id) AND ([item_name] " +
                "= @Original_item_name) AND ([quantity] = @Original_quantity) AND ([price] = @Ori" +
                "ginal_price) AND ([date] = @Original_date))";
            this._adapter.DeleteCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_item_id", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "item_id", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_item_name", global::System.Data.SqlDbType.VarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "item_name", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_quantity", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "quantity", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_price", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "price", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_date", global::System.Data.SqlDbType.Date, 0, global::System.Data.ParameterDirection.Input, 0, 0, "date", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.InsertCommand = new global::System.Data.SqlClient.SqlCommand();
            this._adapter.InsertCommand.Connection = this.Connection;
            this._adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[item] ([item_name], [quantity], [price], [date]) VALUES (@item" +
                "_name, @quantity, @price, @date);\r\nSELECT item_id, item_name, quantity, price, d" +
                "ate FROM item WHERE (item_id = SCOPE_IDENTITY())";
            this._adapter.InsertCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@item_name", global::System.Data.SqlDbType.VarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "item_name", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@quantity", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "quantity", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@price", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "price", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@date", global::System.Data.SqlDbType.Date, 0, global::System.Data.ParameterDirection.Input, 0, 0, "date", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand = new global::System.Data.SqlClient.SqlCommand();
            this._adapter.UpdateCommand.Connection = this.Connection;
            this._adapter.UpdateCommand.CommandText = @"UPDATE [dbo].[item] SET [item_name] = @item_name, [quantity] = @quantity, [price] = @price, [date] = @date WHERE (([item_id] = @Original_item_id) AND ([item_name] = @Original_item_name) AND ([quantity] = @Original_quantity) AND ([price] = @Original_price) AND ([date] = @Original_date));
SELECT item_id, item_name, quantity, price, date FROM item WHERE (item_id = @item_id)";
            this._adapter.UpdateCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@item_name", global::System.Data.SqlDbType.VarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "item_name", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@quantity", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "quantity", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@price", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "price", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@date", global::System.Data.SqlDbType.Date, 0, global::System.Data.ParameterDirection.Input, 0, 0, "date", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_item_id", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "item_id", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_item_name", global::System.Data.SqlDbType.VarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "item_name", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_quantity", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "quantity", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_price", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "price", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_date", global::System.Data.SqlDbType.Date, 0, global::System.Data.ParameterDirection.Input, 0, 0, "date", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@item_id", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.Input, 0, 0, "item_id", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        private void InitConnection() {
            this._connection = new global::System.Data.SqlClient.SqlConnection();
            this._connection.ConnectionString = global::inventory.Properties.Settings.Default.supermartConnectionString;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        private void InitCommandCollection() {
            this._commandCollection = new global::System.Data.SqlClient.SqlCommand[1];
            this._commandCollection[0] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[0].Connection = this.Connection;
            this._commandCollection[0].CommandText = "SELECT item_id, item_name, quantity, price, date FROM dbo.item";
            this._commandCollection[0].CommandType = global::System.Data.CommandType.Text;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Fill, true)]
        public virtual int Fill(supermartDataSet1.itemDataTable dataTable) {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            if ((this.ClearBeforeFill == true)) {
                dataTable.Clear();
            }
            int returnValue = this.Adapter.Fill(dataTable);
            return returnValue;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Select, true)]
        public virtual supermartDataSet1.itemDataTable GetData() {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            supermartDataSet1.itemDataTable dataTable = new supermartDataSet1.itemDataTable();
            this.Adapter.Fill(dataTable);
            return dataTable;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(supermartDataSet1.itemDataTable dataTable) {
            return this.Adapter.Update(dataTable);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(supermartDataSet1 dataSet) {
            return this.Adapter.Update(dataSet, "item");
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow dataRow) {
            return this.Adapter.Update(new global::System.Data.DataRow[] {
                        dataRow});
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow[] dataRows) {
            return this.Adapter.Update(dataRows);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(int Original_item_id, string Original_item_name, int Original_quantity, int Original_price, System.DateTime Original_date) {
            this.Adapter.DeleteCommand.Parameters[0].Value = ((int)(Original_item_id));
            if ((Original_item_name == null)) {
                throw new global::System.ArgumentNullException("Original_item_name");
            }
            else {
                this.Adapter.DeleteCommand.Parameters[1].Value = ((string)(Original_item_name));
            }
            this.Adapter.DeleteCommand.Parameters[2].Value = ((int)(Original_quantity));
            this.Adapter.DeleteCommand.Parameters[3].Value = ((int)(Original_price));
            this.Adapter.DeleteCommand.Parameters[4].Value = ((System.DateTime)(Original_date));
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.DeleteCommand.Connection.State;
            if (((this.Adapter.DeleteCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.DeleteCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.DeleteCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.DeleteCommand.Connection.Close();
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(string item_name, int quantity, int price, System.DateTime date) {
            if ((item_name == null)) {
                throw new global::System.ArgumentNullException("item_name");
            }
            else {
                this.Adapter.InsertCommand.Parameters[0].Value = ((string)(item_name));
            }
            this.Adapter.InsertCommand.Parameters[1].Value = ((int)(quantity));
            this.Adapter.InsertCommand.Parameters[2].Value = ((int)(price));
            this.Adapter.InsertCommand.Parameters[3].Value = ((System.DateTime)(date));
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.InsertCommand.Connection.State;
            if (((this.Adapter.InsertCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.InsertCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.InsertCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.InsertCommand.Connection.Close();
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(string item_name, int quantity, int price, System.DateTime date, int Original_item_id, string Original_item_name, int Original_quantity, int Original_price, System.DateTime Original_date, int item_id) {
            if ((item_name == null)) {
                throw new global::System.ArgumentNullException("item_name");
            }
            else {
                this.Adapter.UpdateCommand.Parameters[0].Value = ((string)(item_name));
            }
            this.Adapter.UpdateCommand.Parameters[1].Value = ((int)(quantity));
            this.Adapter.UpdateCommand.Parameters[2].Value = ((int)(price));
            this.Adapter.UpdateCommand.Parameters[3].Value = ((System.DateTime)(date));
            this.Adapter.UpdateCommand.Parameters[4].Value = ((int)(Original_item_id));
            if ((Original_item_name == null)) {
                throw new global::System.ArgumentNullException("Original_item_name");
            }
            else {
                this.Adapter.UpdateCommand.Parameters[5].Value = ((string)(Original_item_name));
            }
            this.Adapter.UpdateCommand.Parameters[6].Value = ((int)(Original_quantity));
            this.Adapter.UpdateCommand.Parameters[7].Value = ((int)(Original_price));
            this.Adapter.UpdateCommand.Parameters[8].Value = ((System.DateTime)(Original_date));
            this.Adapter.UpdateCommand.Parameters[9].Value = ((int)(item_id));
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.UpdateCommand.Connection.State;
            if (((this.Adapter.UpdateCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.UpdateCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.UpdateCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.UpdateCommand.Connection.Close();
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(string item_name, int quantity, int price, System.DateTime date, int Original_item_id, string Original_item_name, int Original_quantity, int Original_price, System.DateTime Original_date) {
            return this.Update(item_name, quantity, price, date, Original_item_id, Original_item_name, Original_quantity, Original_price, Original_date, Original_item_id);
        }
    }
   
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.ComponentModel.DataObjectAttribute(true)]
    [global::System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" +
        ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
    public partial class purchaseTableAdapter : global::System.ComponentModel.Component {
        
        private global::System.Data.SqlClient.SqlDataAdapter _adapter;
        
        private global::System.Data.SqlClient.SqlConnection _connection;
        
        private global::System.Data.SqlClient.SqlTransaction _transaction;
        
        private global::System.Data.SqlClient.SqlCommand[] _commandCollection;
        
        private bool _clearBeforeFill;
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        public purchaseTableAdapter() {
            this.ClearBeforeFill = true;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        protected internal global::System.Data.SqlClient.SqlDataAdapter Adapter {
            get {
                if ((this._adapter == null)) {
                    this.InitAdapter();
                }
                return this._adapter;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        internal global::System.Data.SqlClient.SqlConnection Connection {
            get {
                if ((this._connection == null)) {
                    this.InitConnection();
                }
                return this._connection;
            }
            set {
                this._connection = value;
                if ((this.Adapter.InsertCommand != null)) {
                    this.Adapter.InsertCommand.Connection = value;
                }
                if ((this.Adapter.DeleteCommand != null)) {
                    this.Adapter.DeleteCommand.Connection = value;
                }
                if ((this.Adapter.UpdateCommand != null)) {
                    this.Adapter.UpdateCommand.Connection = value;
                }
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1)) {
                    if ((this.CommandCollection[i] != null)) {
                        ((global::System.Data.SqlClient.SqlCommand)(this.CommandCollection[i])).Connection = value;
                    }
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        internal global::System.Data.SqlClient.SqlTransaction Transaction {
            get {
                return this._transaction;
            }
            set {
                this._transaction = value;
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1)) {
                    this.CommandCollection[i].Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.DeleteCommand != null))) {
                    this.Adapter.DeleteCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.InsertCommand != null))) {
                    this.Adapter.InsertCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.UpdateCommand != null))) {
                    this.Adapter.UpdateCommand.Transaction = this._transaction;
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        protected global::System.Data.SqlClient.SqlCommand[] CommandCollection {
            get {
                if ((this._commandCollection == null)) {
                    this.InitCommandCollection();
                }
                return this._commandCollection;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        public bool ClearBeforeFill {
            get {
                return this._clearBeforeFill;
            }
            set {
                this._clearBeforeFill = value;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        private void InitAdapter() {
            this._adapter = new global::System.Data.SqlClient.SqlDataAdapter();
            global::System.Data.Common.DataTableMapping tableMapping = new global::System.Data.Common.DataTableMapping();
            tableMapping.SourceTable = "Table";
            tableMapping.DataSetTable = "purchase";
            tableMapping.ColumnMappings.Add("purchase_id", "purchase_id");
            tableMapping.ColumnMappings.Add("sup_id", "sup_id");
            tableMapping.ColumnMappings.Add("item_id", "item_id");
            tableMapping.ColumnMappings.Add("cost_price", "cost_price");
            tableMapping.ColumnMappings.Add("quantity", "quantity");
            tableMapping.ColumnMappings.Add("unit", "unit");
            tableMapping.ColumnMappings.Add("entry_date", "entry_date");
            tableMapping.ColumnMappings.Add("selling_price", "selling_price");
            this._adapter.TableMappings.Add(tableMapping);
            this._adapter.DeleteCommand = new global::System.Data.SqlClient.SqlCommand();
            this._adapter.DeleteCommand.Connection = this.Connection;
            this._adapter.DeleteCommand.CommandText = @"DELETE FROM [dbo].[purchase] WHERE (([purchase_id] = @Original_purchase_id) AND ([sup_id] = @Original_sup_id) AND ([item_id] = @Original_item_id) AND ([cost_price] = @Original_cost_price) AND ([quantity] = @Original_quantity) AND ([unit] = @Original_unit) AND ([entry_date] = @Original_entry_date) AND ((@IsNull_selling_price = 1 AND [selling_price] IS NULL) OR ([selling_price] = @Original_selling_price)))";
            this._adapter.DeleteCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_purchase_id", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "purchase_id", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_sup_id", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "sup_id", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_item_id", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "item_id", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_cost_price", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "cost_price", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_quantity", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "quantity", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_unit", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "unit", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_entry_date", global::System.Data.SqlDbType.Date, 0, global::System.Data.ParameterDirection.Input, 0, 0, "entry_date", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_selling_price", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "selling_price", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_selling_price", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "selling_price", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.InsertCommand = new global::System.Data.SqlClient.SqlCommand();
            this._adapter.InsertCommand.Connection = this.Connection;
            this._adapter.InsertCommand.CommandText = @"INSERT INTO [dbo].[purchase] ([sup_id], [item_id], [cost_price], [quantity], [unit], [entry_date], [selling_price]) VALUES (@sup_id, @item_id, @cost_price, @quantity, @unit, @entry_date, @selling_price);
SELECT purchase_id, sup_id, item_id, cost_price, quantity, unit, entry_date, selling_price FROM purchase WHERE (purchase_id = SCOPE_IDENTITY())";
            this._adapter.InsertCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@sup_id", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "sup_id", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@item_id", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "item_id", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@cost_price", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "cost_price", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@quantity", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "quantity", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@unit", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "unit", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@entry_date", global::System.Data.SqlDbType.Date, 0, global::System.Data.ParameterDirection.Input, 0, 0, "entry_date", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@selling_price", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "selling_price", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand = new global::System.Data.SqlClient.SqlCommand();
            this._adapter.UpdateCommand.Connection = this.Connection;
            this._adapter.UpdateCommand.CommandText = @"UPDATE [dbo].[purchase] SET [sup_id] = @sup_id, [item_id] = @item_id, [cost_price] = @cost_price, [quantity] = @quantity, [unit] = @unit, [entry_date] = @entry_date, [selling_price] = @selling_price WHERE (([purchase_id] = @Original_purchase_id) AND ([sup_id] = @Original_sup_id) AND ([item_id] = @Original_item_id) AND ([cost_price] = @Original_cost_price) AND ([quantity] = @Original_quantity) AND ([unit] = @Original_unit) AND ([entry_date] = @Original_entry_date) AND ((@IsNull_selling_price = 1 AND [selling_price] IS NULL) OR ([selling_price] = @Original_selling_price)));
SELECT purchase_id, sup_id, item_id, cost_price, quantity, unit, entry_date, selling_price FROM purchase WHERE (purchase_id = @purchase_id)";
            this._adapter.UpdateCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@sup_id", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "sup_id", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@item_id", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "item_id", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@cost_price", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "cost_price", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@quantity", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "quantity", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@unit", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "unit", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@entry_date", global::System.Data.SqlDbType.Date, 0, global::System.Data.ParameterDirection.Input, 0, 0, "entry_date", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@selling_price", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "selling_price", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_purchase_id", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "purchase_id", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_sup_id", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "sup_id", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_item_id", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "item_id", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_cost_price", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "cost_price", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_quantity", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "quantity", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_unit", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "unit", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_entry_date", global::System.Data.SqlDbType.Date, 0, global::System.Data.ParameterDirection.Input, 0, 0, "entry_date", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_selling_price", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "selling_price", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_selling_price", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "selling_price", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@purchase_id", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.Input, 0, 0, "purchase_id", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        private void InitConnection() {
            this._connection = new global::System.Data.SqlClient.SqlConnection();
            this._connection.ConnectionString = global::inventory.Properties.Settings.Default.supermartConnectionString;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        private void InitCommandCollection() {
            this._commandCollection = new global::System.Data.SqlClient.SqlCommand[1];
            this._commandCollection[0] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[0].Connection = this.Connection;
            this._commandCollection[0].CommandText = "SELECT purchase_id, sup_id, item_id, cost_price, quantity, unit, entry_date, sell" +
                "ing_price FROM dbo.purchase";
            this._commandCollection[0].CommandType = global::System.Data.CommandType.Text;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Fill, true)]
        public virtual int Fill(supermartDataSet1.purchaseDataTable dataTable) {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            if ((this.ClearBeforeFill == true)) {
                dataTable.Clear();
            }
            int returnValue = this.Adapter.Fill(dataTable);
            return returnValue;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Select, true)]
        public virtual supermartDataSet1.purchaseDataTable GetData() {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            supermartDataSet1.purchaseDataTable dataTable = new supermartDataSet1.purchaseDataTable();
            this.Adapter.Fill(dataTable);
            return dataTable;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(supermartDataSet1.purchaseDataTable dataTable) {
            return this.Adapter.Update(dataTable);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(supermartDataSet1 dataSet) {
            return this.Adapter.Update(dataSet, "purchase");
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow dataRow) {
            return this.Adapter.Update(new global::System.Data.DataRow[] {
                        dataRow});
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow[] dataRows) {
            return this.Adapter.Update(dataRows);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(int Original_purchase_id, int Original_sup_id, int Original_item_id, int Original_cost_price, int Original_quantity, int Original_unit, System.DateTime Original_entry_date, global::System.Nullable<int> Original_selling_price) {
            this.Adapter.DeleteCommand.Parameters[0].Value = ((int)(Original_purchase_id));
            this.Adapter.DeleteCommand.Parameters[1].Value = ((int)(Original_sup_id));
            this.Adapter.DeleteCommand.Parameters[2].Value = ((int)(Original_item_id));
            this.Adapter.DeleteCommand.Parameters[3].Value = ((int)(Original_cost_price));
            this.Adapter.DeleteCommand.Parameters[4].Value = ((int)(Original_quantity));
            this.Adapter.DeleteCommand.Parameters[5].Value = ((int)(Original_unit));
            this.Adapter.DeleteCommand.Parameters[6].Value = ((System.DateTime)(Original_entry_date));
            if ((Original_selling_price.HasValue == true)) {
                this.Adapter.DeleteCommand.Parameters[7].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[8].Value = ((int)(Original_selling_price.Value));
            }
            else {
                this.Adapter.DeleteCommand.Parameters[7].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[8].Value = global::System.DBNull.Value;
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.DeleteCommand.Connection.State;
            if (((this.Adapter.DeleteCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.DeleteCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.DeleteCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.DeleteCommand.Connection.Close();
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(int sup_id, int item_id, int cost_price, int quantity, int unit, System.DateTime entry_date, global::System.Nullable<int> selling_price) {
            this.Adapter.InsertCommand.Parameters[0].Value = ((int)(sup_id));
            this.Adapter.InsertCommand.Parameters[1].Value = ((int)(item_id));
            this.Adapter.InsertCommand.Parameters[2].Value = ((int)(cost_price));
            this.Adapter.InsertCommand.Parameters[3].Value = ((int)(quantity));
            this.Adapter.InsertCommand.Parameters[4].Value = ((int)(unit));
            this.Adapter.InsertCommand.Parameters[5].Value = ((System.DateTime)(entry_date));
            if ((selling_price.HasValue == true)) {
                this.Adapter.InsertCommand.Parameters[6].Value = ((int)(selling_price.Value));
            }
            else {
                this.Adapter.InsertCommand.Parameters[6].Value = global::System.DBNull.Value;
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.InsertCommand.Connection.State;
            if (((this.Adapter.InsertCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.InsertCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.InsertCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.InsertCommand.Connection.Close();
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(
                    int sup_id, 
                    int item_id, 
                    int cost_price, 
                    int quantity, 
                    int unit, 
                    System.DateTime entry_date, 
                    global::System.Nullable<int> selling_price, 
                    int Original_purchase_id, 
                    int Original_sup_id, 
                    int Original_item_id, 
                    int Original_cost_price, 
                    int Original_quantity, 
                    int Original_unit, 
                    System.DateTime Original_entry_date, 
                    global::System.Nullable<int> Original_selling_price, 
                    int purchase_id) {
            this.Adapter.UpdateCommand.Parameters[0].Value = ((int)(sup_id));
            this.Adapter.UpdateCommand.Parameters[1].Value = ((int)(item_id));
            this.Adapter.UpdateCommand.Parameters[2].Value = ((int)(cost_price));
            this.Adapter.UpdateCommand.Parameters[3].Value = ((int)(quantity));
            this.Adapter.UpdateCommand.Parameters[4].Value = ((int)(unit));
            this.Adapter.UpdateCommand.Parameters[5].Value = ((System.DateTime)(entry_date));
            if ((selling_price.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[6].Value = ((int)(selling_price.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[6].Value = global::System.DBNull.Value;
            }
            this.Adapter.UpdateCommand.Parameters[7].Value = ((int)(Original_purchase_id));
            this.Adapter.UpdateCommand.Parameters[8].Value = ((int)(Original_sup_id));
            this.Adapter.UpdateCommand.Parameters[9].Value = ((int)(Original_item_id));
            this.Adapter.UpdateCommand.Parameters[10].Value = ((int)(Original_cost_price));
            this.Adapter.UpdateCommand.Parameters[11].Value = ((int)(Original_quantity));
            this.Adapter.UpdateCommand.Parameters[12].Value = ((int)(Original_unit));
            this.Adapter.UpdateCommand.Parameters[13].Value = ((System.DateTime)(Original_entry_date));
            if ((Original_selling_price.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[14].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[15].Value = ((int)(Original_selling_price.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[14].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[15].Value = global::System.DBNull.Value;
            }
            this.Adapter.UpdateCommand.Parameters[16].Value = ((int)(purchase_id));
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.UpdateCommand.Connection.State;
            if (((this.Adapter.UpdateCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.UpdateCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.UpdateCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.UpdateCommand.Connection.Close();
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(int sup_id, int item_id, int cost_price, int quantity, int unit, System.DateTime entry_date, global::System.Nullable<int> selling_price, int Original_purchase_id, int Original_sup_id, int Original_item_id, int Original_cost_price, int Original_quantity, int Original_unit, System.DateTime Original_entry_date, global::System.Nullable<int> Original_selling_price) {
            return this.Update(sup_id, item_id, cost_price, quantity, unit, entry_date, selling_price, Original_purchase_id, Original_sup_id, Original_item_id, Original_cost_price, Original_quantity, Original_unit, Original_entry_date, Original_selling_price, Original_purchase_id);
        }
    }
    
    
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.ComponentModel.DataObjectAttribute(true)]
    [global::System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" +
        ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
    public partial class saleTableAdapter : global::System.ComponentModel.Component {
        
        private global::System.Data.SqlClient.SqlDataAdapter _adapter;
        
        private global::System.Data.SqlClient.SqlConnection _connection;
        
        private global::System.Data.SqlClient.SqlTransaction _transaction;
        
        private global::System.Data.SqlClient.SqlCommand[] _commandCollection;
        
        private bool _clearBeforeFill;
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        public saleTableAdapter() {
            this.ClearBeforeFill = true;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        protected internal global::System.Data.SqlClient.SqlDataAdapter Adapter {
            get {
                if ((this._adapter == null)) {
                    this.InitAdapter();
                }
                return this._adapter;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        internal global::System.Data.SqlClient.SqlConnection Connection {
            get {
                if ((this._connection == null)) {
                    this.InitConnection();
                }
                return this._connection;
            }
            set {
                this._connection = value;
                if ((this.Adapter.InsertCommand != null)) {
                    this.Adapter.InsertCommand.Connection = value;
                }
                if ((this.Adapter.DeleteCommand != null)) {
                    this.Adapter.DeleteCommand.Connection = value;
                }
                if ((this.Adapter.UpdateCommand != null)) {
                    this.Adapter.UpdateCommand.Connection = value;
                }
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1)) {
                    if ((this.CommandCollection[i] != null)) {
                        ((global::System.Data.SqlClient.SqlCommand)(this.CommandCollection[i])).Connection = value;
                    }
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        internal global::System.Data.SqlClient.SqlTransaction Transaction {
            get {
                return this._transaction;
            }
            set {
                this._transaction = value;
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1)) {
                    this.CommandCollection[i].Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.DeleteCommand != null))) {
                    this.Adapter.DeleteCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.InsertCommand != null))) {
                    this.Adapter.InsertCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.UpdateCommand != null))) {
                    this.Adapter.UpdateCommand.Transaction = this._transaction;
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        protected global::System.Data.SqlClient.SqlCommand[] CommandCollection {
            get {
                if ((this._commandCollection == null)) {
                    this.InitCommandCollection();
                }
                return this._commandCollection;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        public bool ClearBeforeFill {
            get {
                return this._clearBeforeFill;
            }
            set {
                this._clearBeforeFill = value;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        private void InitAdapter() {
            this._adapter = new global::System.Data.SqlClient.SqlDataAdapter();
            global::System.Data.Common.DataTableMapping tableMapping = new global::System.Data.Common.DataTableMapping();
            tableMapping.SourceTable = "Table";
            tableMapping.DataSetTable = "sale";
            tableMapping.ColumnMappings.Add("sale_id", "sale_id");
            tableMapping.ColumnMappings.Add("cus_id", "cus_id");
            tableMapping.ColumnMappings.Add("item_id", "item_id");
            tableMapping.ColumnMappings.Add("quantity", "quantity");
            tableMapping.ColumnMappings.Add("selling_price", "selling_price");
            tableMapping.ColumnMappings.Add("date", "date");
            this._adapter.TableMappings.Add(tableMapping);
            this._adapter.DeleteCommand = new global::System.Data.SqlClient.SqlCommand();
            this._adapter.DeleteCommand.Connection = this.Connection;
            this._adapter.DeleteCommand.CommandText = "DELETE FROM [dbo].[sale] WHERE (([sale_id] = @Original_sale_id) AND ([cus_id] = @" +
                "Original_cus_id) AND ([item_id] = @Original_item_id) AND ([quantity] = @Original" +
                "_quantity) AND ([selling_price] = @Original_selling_price) AND ([date] = @Origin" +
                "al_date))";
            this._adapter.DeleteCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_sale_id", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "sale_id", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_cus_id", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "cus_id", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_item_id", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "item_id", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_quantity", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "quantity", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_selling_price", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "selling_price", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_date", global::System.Data.SqlDbType.Date, 0, global::System.Data.ParameterDirection.Input, 0, 0, "date", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.InsertCommand = new global::System.Data.SqlClient.SqlCommand();
            this._adapter.InsertCommand.Connection = this.Connection;
            this._adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[sale] ([cus_id], [item_id], [quantity], [selling_price], [date" +
                "]) VALUES (@cus_id, @item_id, @quantity, @selling_price, @date);\r\nSELECT sale_id" +
                ", cus_id, item_id, quantity, selling_price, date FROM sale WHERE (sale_id = SCOP" +
                "E_IDENTITY())";
            this._adapter.InsertCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@cus_id", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "cus_id", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@item_id", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "item_id", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@quantity", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "quantity", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@selling_price", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "selling_price", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@date", global::System.Data.SqlDbType.Date, 0, global::System.Data.ParameterDirection.Input, 0, 0, "date", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand = new global::System.Data.SqlClient.SqlCommand();
            this._adapter.UpdateCommand.Connection = this.Connection;
            this._adapter.UpdateCommand.CommandText = @"UPDATE [dbo].[sale] SET [cus_id] = @cus_id, [item_id] = @item_id, [quantity] = @quantity, [selling_price] = @selling_price, [date] = @date WHERE (([sale_id] = @Original_sale_id) AND ([cus_id] = @Original_cus_id) AND ([item_id] = @Original_item_id) AND ([quantity] = @Original_quantity) AND ([selling_price] = @Original_selling_price) AND ([date] = @Original_date));
SELECT sale_id, cus_id, item_id, quantity, selling_price, date FROM sale WHERE (sale_id = @sale_id)";
            this._adapter.UpdateCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@cus_id", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "cus_id", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@item_id", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "item_id", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@quantity", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "quantity", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@selling_price", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "selling_price", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@date", global::System.Data.SqlDbType.Date, 0, global::System.Data.ParameterDirection.Input, 0, 0, "date", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_sale_id", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "sale_id", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_cus_id", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "cus_id", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_item_id", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "item_id", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_quantity", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "quantity", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_selling_price", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "selling_price", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_date", global::System.Data.SqlDbType.Date, 0, global::System.Data.ParameterDirection.Input, 0, 0, "date", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@sale_id", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.Input, 0, 0, "sale_id", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        private void InitConnection() {
            this._connection = new global::System.Data.SqlClient.SqlConnection();
            this._connection.ConnectionString = global::inventory.Properties.Settings.Default.supermartConnectionString;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        private void InitCommandCollection() {
            this._commandCollection = new global::System.Data.SqlClient.SqlCommand[1];
            this._commandCollection[0] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[0].Connection = this.Connection;
            this._commandCollection[0].CommandText = "SELECT sale_id, cus_id, item_id, quantity, selling_price, date FROM dbo.sale";
            this._commandCollection[0].CommandType = global::System.Data.CommandType.Text;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Fill, true)]
        public virtual int Fill(supermartDataSet1.saleDataTable dataTable) {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            if ((this.ClearBeforeFill == true)) {
                dataTable.Clear();
            }
            int returnValue = this.Adapter.Fill(dataTable);
            return returnValue;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Select, true)]
        public virtual supermartDataSet1.saleDataTable GetData() {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            supermartDataSet1.saleDataTable dataTable = new supermartDataSet1.saleDataTable();
            this.Adapter.Fill(dataTable);
            return dataTable;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(supermartDataSet1.saleDataTable dataTable) {
            return this.Adapter.Update(dataTable);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(supermartDataSet1 dataSet) {
            return this.Adapter.Update(dataSet, "sale");
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow dataRow) {
            return this.Adapter.Update(new global::System.Data.DataRow[] {
                        dataRow});
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow[] dataRows) {
            return this.Adapter.Update(dataRows);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(int Original_sale_id, int Original_cus_id, int Original_item_id, int Original_quantity, int Original_selling_price, System.DateTime Original_date) {
            this.Adapter.DeleteCommand.Parameters[0].Value = ((int)(Original_sale_id));
            this.Adapter.DeleteCommand.Parameters[1].Value = ((int)(Original_cus_id));
            this.Adapter.DeleteCommand.Parameters[2].Value = ((int)(Original_item_id));
            this.Adapter.DeleteCommand.Parameters[3].Value = ((int)(Original_quantity));
            this.Adapter.DeleteCommand.Parameters[4].Value = ((int)(Original_selling_price));
            this.Adapter.DeleteCommand.Parameters[5].Value = ((System.DateTime)(Original_date));
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.DeleteCommand.Connection.State;
            if (((this.Adapter.DeleteCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.DeleteCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.DeleteCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.DeleteCommand.Connection.Close();
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(int cus_id, int item_id, int quantity, int selling_price, System.DateTime date) {
            this.Adapter.InsertCommand.Parameters[0].Value = ((int)(cus_id));
            this.Adapter.InsertCommand.Parameters[1].Value = ((int)(item_id));
            this.Adapter.InsertCommand.Parameters[2].Value = ((int)(quantity));
            this.Adapter.InsertCommand.Parameters[3].Value = ((int)(selling_price));
            this.Adapter.InsertCommand.Parameters[4].Value = ((System.DateTime)(date));
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.InsertCommand.Connection.State;
            if (((this.Adapter.InsertCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.InsertCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.InsertCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.InsertCommand.Connection.Close();
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(int cus_id, int item_id, int quantity, int selling_price, System.DateTime date, int Original_sale_id, int Original_cus_id, int Original_item_id, int Original_quantity, int Original_selling_price, System.DateTime Original_date, int sale_id) {
            this.Adapter.UpdateCommand.Parameters[0].Value = ((int)(cus_id));
            this.Adapter.UpdateCommand.Parameters[1].Value = ((int)(item_id));
            this.Adapter.UpdateCommand.Parameters[2].Value = ((int)(quantity));
            this.Adapter.UpdateCommand.Parameters[3].Value = ((int)(selling_price));
            this.Adapter.UpdateCommand.Parameters[4].Value = ((System.DateTime)(date));
            this.Adapter.UpdateCommand.Parameters[5].Value = ((int)(Original_sale_id));
            this.Adapter.UpdateCommand.Parameters[6].Value = ((int)(Original_cus_id));
            this.Adapter.UpdateCommand.Parameters[7].Value = ((int)(Original_item_id));
            this.Adapter.UpdateCommand.Parameters[8].Value = ((int)(Original_quantity));
            this.Adapter.UpdateCommand.Parameters[9].Value = ((int)(Original_selling_price));
            this.Adapter.UpdateCommand.Parameters[10].Value = ((System.DateTime)(Original_date));
            this.Adapter.UpdateCommand.Parameters[11].Value = ((int)(sale_id));
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.UpdateCommand.Connection.State;
            if (((this.Adapter.UpdateCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.UpdateCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.UpdateCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.UpdateCommand.Connection.Close();
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(int cus_id, int item_id, int quantity, int selling_price, System.DateTime date, int Original_sale_id, int Original_cus_id, int Original_item_id, int Original_quantity, int Original_selling_price, System.DateTime Original_date) {
            return this.Update(cus_id, item_id, quantity, selling_price, date, Original_sale_id, Original_cus_id, Original_item_id, Original_quantity, Original_selling_price, Original_date, Original_sale_id);
        }
    }
   
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.ComponentModel.DataObjectAttribute(true)]
    [global::System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" +
        ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
    public partial class supplierTableAdapter : global::System.ComponentModel.Component {
        
        private global::System.Data.SqlClient.SqlDataAdapter _adapter;
        
        private global::System.Data.SqlClient.SqlConnection _connection;
        
        private global::System.Data.SqlClient.SqlTransaction _transaction;
        
        private global::System.Data.SqlClient.SqlCommand[] _commandCollection;
        
        private bool _clearBeforeFill;
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        public supplierTableAdapter() {
            this.ClearBeforeFill = true;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        protected internal global::System.Data.SqlClient.SqlDataAdapter Adapter {
            get {
                if ((this._adapter == null)) {
                    this.InitAdapter();
                }
                return this._adapter;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        internal global::System.Data.SqlClient.SqlConnection Connection {
            get {
                if ((this._connection == null)) {
                    this.InitConnection();
                }
                return this._connection;
            }
            set {
                this._connection = value;
                if ((this.Adapter.InsertCommand != null)) {
                    this.Adapter.InsertCommand.Connection = value;
                }
                if ((this.Adapter.DeleteCommand != null)) {
                    this.Adapter.DeleteCommand.Connection = value;
                }
                if ((this.Adapter.UpdateCommand != null)) {
                    this.Adapter.UpdateCommand.Connection = value;
                }
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1)) {
                    if ((this.CommandCollection[i] != null)) {
                        ((global::System.Data.SqlClient.SqlCommand)(this.CommandCollection[i])).Connection = value;
                    }
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        internal global::System.Data.SqlClient.SqlTransaction Transaction {
            get {
                return this._transaction;
            }
            set {
                this._transaction = value;
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1)) {
                    this.CommandCollection[i].Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.DeleteCommand != null))) {
                    this.Adapter.DeleteCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.InsertCommand != null))) {
                    this.Adapter.InsertCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.UpdateCommand != null))) {
                    this.Adapter.UpdateCommand.Transaction = this._transaction;
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        protected global::System.Data.SqlClient.SqlCommand[] CommandCollection {
            get {
                if ((this._commandCollection == null)) {
                    this.InitCommandCollection();
                }
                return this._commandCollection;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        public bool ClearBeforeFill {
            get {
                return this._clearBeforeFill;
            }
            set {
                this._clearBeforeFill = value;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        private void InitAdapter() {
            this._adapter = new global::System.Data.SqlClient.SqlDataAdapter();
            global::System.Data.Common.DataTableMapping tableMapping = new global::System.Data.Common.DataTableMapping();
            tableMapping.SourceTable = "Table";
            tableMapping.DataSetTable = "supplier";
            tableMapping.ColumnMappings.Add("sup_id", "sup_id");
            tableMapping.ColumnMappings.Add("sup_address", "sup_address");
            tableMapping.ColumnMappings.Add("sup_phone", "sup_phone");
            tableMapping.ColumnMappings.Add("entry_date", "entry_date");
            tableMapping.ColumnMappings.Add("sup_name", "sup_name");
            this._adapter.TableMappings.Add(tableMapping);
            this._adapter.DeleteCommand = new global::System.Data.SqlClient.SqlCommand();
            this._adapter.DeleteCommand.Connection = this.Connection;
            this._adapter.DeleteCommand.CommandText = @"DELETE FROM [dbo].[supplier] WHERE (([sup_id] = @Original_sup_id) AND ((@IsNull_sup_address = 1 AND [sup_address] IS NULL) OR ([sup_address] = @Original_sup_address)) AND ((@IsNull_sup_phone = 1 AND [sup_phone] IS NULL) OR ([sup_phone] = @Original_sup_phone)) AND ([entry_date] = @Original_entry_date) AND ((@IsNull_sup_name = 1 AND [sup_name] IS NULL) OR ([sup_name] = @Original_sup_name)))";
            this._adapter.DeleteCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_sup_id", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "sup_id", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_sup_address", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "sup_address", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_sup_address", global::System.Data.SqlDbType.VarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "sup_address", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_sup_phone", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "sup_phone", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_sup_phone", global::System.Data.SqlDbType.VarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "sup_phone", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_entry_date", global::System.Data.SqlDbType.Date, 0, global::System.Data.ParameterDirection.Input, 0, 0, "entry_date", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_sup_name", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "sup_name", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_sup_name", global::System.Data.SqlDbType.VarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "sup_name", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.InsertCommand = new global::System.Data.SqlClient.SqlCommand();
            this._adapter.InsertCommand.Connection = this.Connection;
            this._adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[supplier] ([sup_address], [sup_phone], [entry_date], [sup_name" +
                "]) VALUES (@sup_address, @sup_phone, @entry_date, @sup_name);\r\nSELECT sup_id, su" +
                "p_address, sup_phone, entry_date, sup_name FROM supplier WHERE (sup_id = SCOPE_I" +
                "DENTITY())";
            this._adapter.InsertCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@sup_address", global::System.Data.SqlDbType.VarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "sup_address", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@sup_phone", global::System.Data.SqlDbType.VarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "sup_phone", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@entry_date", global::System.Data.SqlDbType.Date, 0, global::System.Data.ParameterDirection.Input, 0, 0, "entry_date", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@sup_name", global::System.Data.SqlDbType.VarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "sup_name", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand = new global::System.Data.SqlClient.SqlCommand();
            this._adapter.UpdateCommand.Connection = this.Connection;
            this._adapter.UpdateCommand.CommandText = @"UPDATE [dbo].[supplier] SET [sup_address] = @sup_address, [sup_phone] = @sup_phone, [entry_date] = @entry_date, [sup_name] = @sup_name WHERE (([sup_id] = @Original_sup_id) AND ((@IsNull_sup_address = 1 AND [sup_address] IS NULL) OR ([sup_address] = @Original_sup_address)) AND ((@IsNull_sup_phone = 1 AND [sup_phone] IS NULL) OR ([sup_phone] = @Original_sup_phone)) AND ([entry_date] = @Original_entry_date) AND ((@IsNull_sup_name = 1 AND [sup_name] IS NULL) OR ([sup_name] = @Original_sup_name)));
SELECT sup_id, sup_address, sup_phone, entry_date, sup_name FROM supplier WHERE (sup_id = @sup_id)";
            this._adapter.UpdateCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@sup_address", global::System.Data.SqlDbType.VarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "sup_address", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@sup_phone", global::System.Data.SqlDbType.VarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "sup_phone", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@entry_date", global::System.Data.SqlDbType.Date, 0, global::System.Data.ParameterDirection.Input, 0, 0, "entry_date", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@sup_name", global::System.Data.SqlDbType.VarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "sup_name", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_sup_id", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "sup_id", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_sup_address", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "sup_address", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_sup_address", global::System.Data.SqlDbType.VarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "sup_address", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_sup_phone", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "sup_phone", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_sup_phone", global::System.Data.SqlDbType.VarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "sup_phone", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_entry_date", global::System.Data.SqlDbType.Date, 0, global::System.Data.ParameterDirection.Input, 0, 0, "entry_date", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_sup_name", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "sup_name", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_sup_name", global::System.Data.SqlDbType.VarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "sup_name", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@sup_id", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.Input, 0, 0, "sup_id", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        private void InitConnection() {
            this._connection = new global::System.Data.SqlClient.SqlConnection();
            this._connection.ConnectionString = global::inventory.Properties.Settings.Default.supermartConnectionString;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        private void InitCommandCollection() {
            this._commandCollection = new global::System.Data.SqlClient.SqlCommand[1];
            this._commandCollection[0] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[0].Connection = this.Connection;
            this._commandCollection[0].CommandText = "SELECT sup_id, sup_address, sup_phone, entry_date, sup_name FROM dbo.supplier";
            this._commandCollection[0].CommandType = global::System.Data.CommandType.Text;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Fill, true)]
        public virtual int Fill(supermartDataSet1.supplierDataTable dataTable) {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            if ((this.ClearBeforeFill == true)) {
                dataTable.Clear();
            }
            int returnValue = this.Adapter.Fill(dataTable);
            return returnValue;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Select, true)]
        public virtual supermartDataSet1.supplierDataTable GetData() {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            supermartDataSet1.supplierDataTable dataTable = new supermartDataSet1.supplierDataTable();
            this.Adapter.Fill(dataTable);
            return dataTable;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(supermartDataSet1.supplierDataTable dataTable) {
            return this.Adapter.Update(dataTable);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(supermartDataSet1 dataSet) {
            return this.Adapter.Update(dataSet, "supplier");
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow dataRow) {
            return this.Adapter.Update(new global::System.Data.DataRow[] {
                        dataRow});
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow[] dataRows) {
            return this.Adapter.Update(dataRows);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(int Original_sup_id, string Original_sup_address, string Original_sup_phone, System.DateTime Original_entry_date, string Original_sup_name) {
            this.Adapter.DeleteCommand.Parameters[0].Value = ((int)(Original_sup_id));
            if ((Original_sup_address == null)) {
                this.Adapter.DeleteCommand.Parameters[1].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.DeleteCommand.Parameters[1].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[2].Value = ((string)(Original_sup_address));
            }
            if ((Original_sup_phone == null)) {
                this.Adapter.DeleteCommand.Parameters[3].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[4].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.DeleteCommand.Parameters[3].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[4].Value = ((string)(Original_sup_phone));
            }
            this.Adapter.DeleteCommand.Parameters[5].Value = ((System.DateTime)(Original_entry_date));
            if ((Original_sup_name == null)) {
                this.Adapter.DeleteCommand.Parameters[6].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[7].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.DeleteCommand.Parameters[6].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[7].Value = ((string)(Original_sup_name));
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.DeleteCommand.Connection.State;
            if (((this.Adapter.DeleteCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.DeleteCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.DeleteCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.DeleteCommand.Connection.Close();
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(string sup_address, string sup_phone, System.DateTime entry_date, string sup_name) {
            if ((sup_address == null)) {
                this.Adapter.InsertCommand.Parameters[0].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.InsertCommand.Parameters[0].Value = ((string)(sup_address));
            }
            if ((sup_phone == null)) {
                this.Adapter.InsertCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.InsertCommand.Parameters[1].Value = ((string)(sup_phone));
            }
            this.Adapter.InsertCommand.Parameters[2].Value = ((System.DateTime)(entry_date));
            if ((sup_name == null)) {
                this.Adapter.InsertCommand.Parameters[3].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.InsertCommand.Parameters[3].Value = ((string)(sup_name));
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.InsertCommand.Connection.State;
            if (((this.Adapter.InsertCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.InsertCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.InsertCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.InsertCommand.Connection.Close();
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(string sup_address, string sup_phone, System.DateTime entry_date, string sup_name, int Original_sup_id, string Original_sup_address, string Original_sup_phone, System.DateTime Original_entry_date, string Original_sup_name, int sup_id) {
            if ((sup_address == null)) {
                this.Adapter.UpdateCommand.Parameters[0].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[0].Value = ((string)(sup_address));
            }
            if ((sup_phone == null)) {
                this.Adapter.UpdateCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[1].Value = ((string)(sup_phone));
            }
            this.Adapter.UpdateCommand.Parameters[2].Value = ((System.DateTime)(entry_date));
            if ((sup_name == null)) {
                this.Adapter.UpdateCommand.Parameters[3].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[3].Value = ((string)(sup_name));
            }
            this.Adapter.UpdateCommand.Parameters[4].Value = ((int)(Original_sup_id));
            if ((Original_sup_address == null)) {
                this.Adapter.UpdateCommand.Parameters[5].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[6].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[5].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[6].Value = ((string)(Original_sup_address));
            }
            if ((Original_sup_phone == null)) {
                this.Adapter.UpdateCommand.Parameters[7].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[8].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[7].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[8].Value = ((string)(Original_sup_phone));
            }
            this.Adapter.UpdateCommand.Parameters[9].Value = ((System.DateTime)(Original_entry_date));
            if ((Original_sup_name == null)) {
                this.Adapter.UpdateCommand.Parameters[10].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[11].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[10].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[11].Value = ((string)(Original_sup_name));
            }
            this.Adapter.UpdateCommand.Parameters[12].Value = ((int)(sup_id));
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.UpdateCommand.Connection.State;
            if (((this.Adapter.UpdateCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.UpdateCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.UpdateCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.UpdateCommand.Connection.Close();
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(string sup_address, string sup_phone, System.DateTime entry_date, string sup_name, int Original_sup_id, string Original_sup_address, string Original_sup_phone, System.DateTime Original_entry_date, string Original_sup_name) {
            return this.Update(sup_address, sup_phone, entry_date, sup_name, Original_sup_id, Original_sup_address, Original_sup_phone, Original_entry_date, Original_sup_name, Original_sup_id);
        }
    }
    
   
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerDesigner, Microsoft.VSD" +
        "esigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapterManager")]
    public partial class TableAdapterManager : global::System.ComponentModel.Component {
        
        private UpdateOrderOption _updateOrder;
        
        private customerTableAdapter _customerTableAdapter;
        
        private itemTableAdapter _itemTableAdapter;
        
        private purchaseTableAdapter _purchaseTableAdapter;
        
        private saleTableAdapter _saleTableAdapter;
        
        private supplierTableAdapter _supplierTableAdapter;
        
        private bool _backupDataSetBeforeUpdate;
        
        private global::System.Data.IDbConnection _connection;
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        public UpdateOrderOption UpdateOrder {
            get {
                return this._updateOrder;
            }
            set {
                this._updateOrder = value;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microso" +
            "ft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3" +
            "a", "System.Drawing.Design.UITypeEditor")]
        public customerTableAdapter customerTableAdapter {
            get {
                return this._customerTableAdapter;
            }
            set {
                this._customerTableAdapter = value;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microso" +
            "ft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3" +
            "a", "System.Drawing.Design.UITypeEditor")]
        public itemTableAdapter itemTableAdapter {
            get {
                return this._itemTableAdapter;
            }
            set {
                this._itemTableAdapter = value;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microso" +
            "ft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3" +
            "a", "System.Drawing.Design.UITypeEditor")]
        public purchaseTableAdapter purchaseTableAdapter {
            get {
                return this._purchaseTableAdapter;
            }
            set {
                this._purchaseTableAdapter = value;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microso" +
            "ft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3" +
            "a", "System.Drawing.Design.UITypeEditor")]
        public saleTableAdapter saleTableAdapter {
            get {
                return this._saleTableAdapter;
            }
            set {
                this._saleTableAdapter = value;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microso" +
            "ft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3" +
            "a", "System.Drawing.Design.UITypeEditor")]
        public supplierTableAdapter supplierTableAdapter {
            get {
                return this._supplierTableAdapter;
            }
            set {
                this._supplierTableAdapter = value;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        public bool BackupDataSetBeforeUpdate {
            get {
                return this._backupDataSetBeforeUpdate;
            }
            set {
                this._backupDataSetBeforeUpdate = value;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        public global::System.Data.IDbConnection Connection {
            get {
                if ((this._connection != null)) {
                    return this._connection;
                }
                if (((this._customerTableAdapter != null) 
                            && (this._customerTableAdapter.Connection != null))) {
                    return this._customerTableAdapter.Connection;
                }
                if (((this._itemTableAdapter != null) 
                            && (this._itemTableAdapter.Connection != null))) {
                    return this._itemTableAdapter.Connection;
                }
                if (((this._purchaseTableAdapter != null) 
                            && (this._purchaseTableAdapter.Connection != null))) {
                    return this._purchaseTableAdapter.Connection;
                }
                if (((this._saleTableAdapter != null) 
                            && (this._saleTableAdapter.Connection != null))) {
                    return this._saleTableAdapter.Connection;
                }
                if (((this._supplierTableAdapter != null) 
                            && (this._supplierTableAdapter.Connection != null))) {
                    return this._supplierTableAdapter.Connection;
                }
                return null;
            }
            set {
                this._connection = value;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        public int TableAdapterInstanceCount {
            get {
                int count = 0;
                if ((this._customerTableAdapter != null)) {
                    count = (count + 1);
                }
                if ((this._itemTableAdapter != null)) {
                    count = (count + 1);
                }
                if ((this._purchaseTableAdapter != null)) {
                    count = (count + 1);
                }
                if ((this._saleTableAdapter != null)) {
                    count = (count + 1);
                }
                if ((this._supplierTableAdapter != null)) {
                    count = (count + 1);
                }
                return count;
            }
        }
        
       
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        private int UpdateUpdatedRows(supermartDataSet1 dataSet, global::System.Collections.Generic.List<global::System.Data.DataRow> allChangedRows, global::System.Collections.Generic.List<global::System.Data.DataRow> allAddedRows) {
            int result = 0;
            if ((this._customerTableAdapter != null)) {
                global::System.Data.DataRow[] updatedRows = dataSet.customer.Select(null, null, global::System.Data.DataViewRowState.ModifiedCurrent);
                updatedRows = this.GetRealUpdatedRows(updatedRows, allAddedRows);
                if (((updatedRows != null) 
                            && (0 < updatedRows.Length))) {
                    result = (result + this._customerTableAdapter.Update(updatedRows));
                    allChangedRows.AddRange(updatedRows);
                }
            }
            if ((this._itemTableAdapter != null)) {
                global::System.Data.DataRow[] updatedRows = dataSet.item.Select(null, null, global::System.Data.DataViewRowState.ModifiedCurrent);
                updatedRows = this.GetRealUpdatedRows(updatedRows, allAddedRows);
                if (((updatedRows != null) 
                            && (0 < updatedRows.Length))) {
                    result = (result + this._itemTableAdapter.Update(updatedRows));
                    allChangedRows.AddRange(updatedRows);
                }
            }
            if ((this._purchaseTableAdapter != null)) {
                global::System.Data.DataRow[] updatedRows = dataSet.purchase.Select(null, null, global::System.Data.DataViewRowState.ModifiedCurrent);
                updatedRows = this.GetRealUpdatedRows(updatedRows, allAddedRows);
                if (((updatedRows != null) 
                            && (0 < updatedRows.Length))) {
                    result = (result + this._purchaseTableAdapter.Update(updatedRows));
                    allChangedRows.AddRange(updatedRows);
                }
            }
            if ((this._saleTableAdapter != null)) {
                global::System.Data.DataRow[] updatedRows = dataSet.sale.Select(null, null, global::System.Data.DataViewRowState.ModifiedCurrent);
                updatedRows = this.GetRealUpdatedRows(updatedRows, allAddedRows);
                if (((updatedRows != null) 
                            && (0 < updatedRows.Length))) {
                    result = (result + this._saleTableAdapter.Update(updatedRows));
                    allChangedRows.AddRange(updatedRows);
                }
            }
            if ((this._supplierTableAdapter != null)) {
                global::System.Data.DataRow[] updatedRows = dataSet.supplier.Select(null, null, global::System.Data.DataViewRowState.ModifiedCurrent);
                updatedRows = this.GetRealUpdatedRows(updatedRows, allAddedRows);
                if (((updatedRows != null) 
                            && (0 < updatedRows.Length))) {
                    result = (result + this._supplierTableAdapter.Update(updatedRows));
                    allChangedRows.AddRange(updatedRows);
                }
            }
            return result;
        }
        
       
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        private int UpdateInsertedRows(supermartDataSet1 dataSet, global::System.Collections.Generic.List<global::System.Data.DataRow> allAddedRows) {
            int result = 0;
            if ((this._customerTableAdapter != null)) {
                global::System.Data.DataRow[] addedRows = dataSet.customer.Select(null, null, global::System.Data.DataViewRowState.Added);
                if (((addedRows != null) 
                            && (0 < addedRows.Length))) {
                    result = (result + this._customerTableAdapter.Update(addedRows));
                    allAddedRows.AddRange(addedRows);
                }
            }
            if ((this._itemTableAdapter != null)) {
                global::System.Data.DataRow[] addedRows = dataSet.item.Select(null, null, global::System.Data.DataViewRowState.Added);
                if (((addedRows != null) 
                            && (0 < addedRows.Length))) {
                    result = (result + this._itemTableAdapter.Update(addedRows));
                    allAddedRows.AddRange(addedRows);
                }
            }
            if ((this._purchaseTableAdapter != null)) {
                global::System.Data.DataRow[] addedRows = dataSet.purchase.Select(null, null, global::System.Data.DataViewRowState.Added);
                if (((addedRows != null) 
                            && (0 < addedRows.Length))) {
                    result = (result + this._purchaseTableAdapter.Update(addedRows));
                    allAddedRows.AddRange(addedRows);
                }
            }
            if ((this._saleTableAdapter != null)) {
                global::System.Data.DataRow[] addedRows = dataSet.sale.Select(null, null, global::System.Data.DataViewRowState.Added);
                if (((addedRows != null) 
                            && (0 < addedRows.Length))) {
                    result = (result + this._saleTableAdapter.Update(addedRows));
                    allAddedRows.AddRange(addedRows);
                }
            }
            if ((this._supplierTableAdapter != null)) {
                global::System.Data.DataRow[] addedRows = dataSet.supplier.Select(null, null, global::System.Data.DataViewRowState.Added);
                if (((addedRows != null) 
                            && (0 < addedRows.Length))) {
                    result = (result + this._supplierTableAdapter.Update(addedRows));
                    allAddedRows.AddRange(addedRows);
                }
            }
            return result;
        }
       
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        private int UpdateDeletedRows(supermartDataSet1 dataSet, global::System.Collections.Generic.List<global::System.Data.DataRow> allChangedRows) {
            int result = 0;
            if ((this._supplierTableAdapter != null)) {
                global::System.Data.DataRow[] deletedRows = dataSet.supplier.Select(null, null, global::System.Data.DataViewRowState.Deleted);
                if (((deletedRows != null) 
                            && (0 < deletedRows.Length))) {
                    result = (result + this._supplierTableAdapter.Update(deletedRows));
                    allChangedRows.AddRange(deletedRows);
                }
            }
            if ((this._saleTableAdapter != null)) {
                global::System.Data.DataRow[] deletedRows = dataSet.sale.Select(null, null, global::System.Data.DataViewRowState.Deleted);
                if (((deletedRows != null) 
                            && (0 < deletedRows.Length))) {
                    result = (result + this._saleTableAdapter.Update(deletedRows));
                    allChangedRows.AddRange(deletedRows);
                }
            }
            if ((this._purchaseTableAdapter != null)) {
                global::System.Data.DataRow[] deletedRows = dataSet.purchase.Select(null, null, global::System.Data.DataViewRowState.Deleted);
                if (((deletedRows != null) 
                            && (0 < deletedRows.Length))) {
                    result = (result + this._purchaseTableAdapter.Update(deletedRows));
                    allChangedRows.AddRange(deletedRows);
                }
            }
            if ((this._itemTableAdapter != null)) {
                global::System.Data.DataRow[] deletedRows = dataSet.item.Select(null, null, global::System.Data.DataViewRowState.Deleted);
                if (((deletedRows != null) 
                            && (0 < deletedRows.Length))) {
                    result = (result + this._itemTableAdapter.Update(deletedRows));
                    allChangedRows.AddRange(deletedRows);
                }
            }
            if ((this._customerTableAdapter != null)) {
                global::System.Data.DataRow[] deletedRows = dataSet.customer.Select(null, null, global::System.Data.DataViewRowState.Deleted);
                if (((deletedRows != null) 
                            && (0 < deletedRows.Length))) {
                    result = (result + this._customerTableAdapter.Update(deletedRows));
                    allChangedRows.AddRange(deletedRows);
                }
            }
            return result;
        }
    
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        private global::System.Data.DataRow[] GetRealUpdatedRows(global::System.Data.DataRow[] updatedRows, global::System.Collections.Generic.List<global::System.Data.DataRow> allAddedRows) {
            if (((updatedRows == null) 
                        || (updatedRows.Length < 1))) {
                return updatedRows;
            }
            if (((allAddedRows == null) 
                        || (allAddedRows.Count < 1))) {
                return updatedRows;
            }
            global::System.Collections.Generic.List<global::System.Data.DataRow> realUpdatedRows = new global::System.Collections.Generic.List<global::System.Data.DataRow>();
            for (int i = 0; (i < updatedRows.Length); i = (i + 1)) {
                global::System.Data.DataRow row = updatedRows[i];
                if ((allAddedRows.Contains(row) == false)) {
                    realUpdatedRows.Add(row);
                }
            }
            return realUpdatedRows.ToArray();
        }
        
       
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        public virtual int UpdateAll(supermartDataSet1 dataSet) {
            if ((dataSet == null)) {
                throw new global::System.ArgumentNullException("dataSet");
            }
            if ((dataSet.HasChanges() == false)) {
                return 0;
            }
            if (((this._customerTableAdapter != null) 
                        && (this.MatchTableAdapterConnection(this._customerTableAdapter.Connection) == false))) {
                throw new global::System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection s" +
                        "tring.");
            }
            if (((this._itemTableAdapter != null) 
                        && (this.MatchTableAdapterConnection(this._itemTableAdapter.Connection) == false))) {
                throw new global::System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection s" +
                        "tring.");
            }
            if (((this._purchaseTableAdapter != null) 
                        && (this.MatchTableAdapterConnection(this._purchaseTableAdapter.Connection) == false))) {
                throw new global::System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection s" +
                        "tring.");
            }
            if (((this._saleTableAdapter != null) 
                        && (this.MatchTableAdapterConnection(this._saleTableAdapter.Connection) == false))) {
                throw new global::System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection s" +
                        "tring.");
            }
            if (((this._supplierTableAdapter != null) 
                        && (this.MatchTableAdapterConnection(this._supplierTableAdapter.Connection) == false))) {
                throw new global::System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection s" +
                        "tring.");
            }
            global::System.Data.IDbConnection workConnection = this.Connection;
            if ((workConnection == null)) {
                throw new global::System.ApplicationException("TableAdapterManager contains no connection information. Set each TableAdapterMana" +
                        "ger TableAdapter property to a valid TableAdapter instance.");
            }
            bool workConnOpened = false;
            if (((workConnection.State & global::System.Data.ConnectionState.Broken) 
                        == global::System.Data.ConnectionState.Broken)) {
                workConnection.Close();
            }
            if ((workConnection.State == global::System.Data.ConnectionState.Closed)) {
                workConnection.Open();
                workConnOpened = true;
            }
            global::System.Data.IDbTransaction workTransaction = workConnection.BeginTransaction();
            if ((workTransaction == null)) {
                throw new global::System.ApplicationException("The transaction cannot begin. The current data connection does not support transa" +
                        "ctions or the current state is not allowing the transaction to begin.");
            }
            global::System.Collections.Generic.List<global::System.Data.DataRow> allChangedRows = new global::System.Collections.Generic.List<global::System.Data.DataRow>();
            global::System.Collections.Generic.List<global::System.Data.DataRow> allAddedRows = new global::System.Collections.Generic.List<global::System.Data.DataRow>();
            global::System.Collections.Generic.List<global::System.Data.Common.DataAdapter> adaptersWithAcceptChangesDuringUpdate = new global::System.Collections.Generic.List<global::System.Data.Common.DataAdapter>();
            global::System.Collections.Generic.Dictionary<object, global::System.Data.IDbConnection> revertConnections = new global::System.Collections.Generic.Dictionary<object, global::System.Data.IDbConnection>();
            int result = 0;
            global::System.Data.DataSet backupDataSet = null;
            if (this.BackupDataSetBeforeUpdate) {
                backupDataSet = new global::System.Data.DataSet();
                backupDataSet.Merge(dataSet);
            }
            try {
               
                if ((this._customerTableAdapter != null)) {
                    revertConnections.Add(this._customerTableAdapter, this._customerTableAdapter.Connection);
                    this._customerTableAdapter.Connection = ((global::System.Data.SqlClient.SqlConnection)(workConnection));
                    this._customerTableAdapter.Transaction = ((global::System.Data.SqlClient.SqlTransaction)(workTransaction));
                    if (this._customerTableAdapter.Adapter.AcceptChangesDuringUpdate) {
                        this._customerTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        adaptersWithAcceptChangesDuringUpdate.Add(this._customerTableAdapter.Adapter);
                    }
                }
                if ((this._itemTableAdapter != null)) {
                    revertConnections.Add(this._itemTableAdapter, this._itemTableAdapter.Connection);
                    this._itemTableAdapter.Connection = ((global::System.Data.SqlClient.SqlConnection)(workConnection));
                    this._itemTableAdapter.Transaction = ((global::System.Data.SqlClient.SqlTransaction)(workTransaction));
                    if (this._itemTableAdapter.Adapter.AcceptChangesDuringUpdate) {
                        this._itemTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        adaptersWithAcceptChangesDuringUpdate.Add(this._itemTableAdapter.Adapter);
                    }
                }
                if ((this._purchaseTableAdapter != null)) {
                    revertConnections.Add(this._purchaseTableAdapter, this._purchaseTableAdapter.Connection);
                    this._purchaseTableAdapter.Connection = ((global::System.Data.SqlClient.SqlConnection)(workConnection));
                    this._purchaseTableAdapter.Transaction = ((global::System.Data.SqlClient.SqlTransaction)(workTransaction));
                    if (this._purchaseTableAdapter.Adapter.AcceptChangesDuringUpdate) {
                        this._purchaseTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        adaptersWithAcceptChangesDuringUpdate.Add(this._purchaseTableAdapter.Adapter);
                    }
                }
                if ((this._saleTableAdapter != null)) {
                    revertConnections.Add(this._saleTableAdapter, this._saleTableAdapter.Connection);
                    this._saleTableAdapter.Connection = ((global::System.Data.SqlClient.SqlConnection)(workConnection));
                    this._saleTableAdapter.Transaction = ((global::System.Data.SqlClient.SqlTransaction)(workTransaction));
                    if (this._saleTableAdapter.Adapter.AcceptChangesDuringUpdate) {
                        this._saleTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        adaptersWithAcceptChangesDuringUpdate.Add(this._saleTableAdapter.Adapter);
                    }
                }
                if ((this._supplierTableAdapter != null)) {
                    revertConnections.Add(this._supplierTableAdapter, this._supplierTableAdapter.Connection);
                    this._supplierTableAdapter.Connection = ((global::System.Data.SqlClient.SqlConnection)(workConnection));
                    this._supplierTableAdapter.Transaction = ((global::System.Data.SqlClient.SqlTransaction)(workTransaction));
                    if (this._supplierTableAdapter.Adapter.AcceptChangesDuringUpdate) {
                        this._supplierTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        adaptersWithAcceptChangesDuringUpdate.Add(this._supplierTableAdapter.Adapter);
                    }
                }
               
                if ((this.UpdateOrder == UpdateOrderOption.UpdateInsertDelete)) {
                    result = (result + this.UpdateUpdatedRows(dataSet, allChangedRows, allAddedRows));
                    result = (result + this.UpdateInsertedRows(dataSet, allAddedRows));
                }
                else {
                    result = (result + this.UpdateInsertedRows(dataSet, allAddedRows));
                    result = (result + this.UpdateUpdatedRows(dataSet, allChangedRows, allAddedRows));
                }
                result = (result + this.UpdateDeletedRows(dataSet, allChangedRows));
              
                workTransaction.Commit();
                if ((0 < allAddedRows.Count)) {
                    global::System.Data.DataRow[] rows = new System.Data.DataRow[allAddedRows.Count];
                    allAddedRows.CopyTo(rows);
                    for (int i = 0; (i < rows.Length); i = (i + 1)) {
                        global::System.Data.DataRow row = rows[i];
                        row.AcceptChanges();
                    }
                }
                if ((0 < allChangedRows.Count)) {
                    global::System.Data.DataRow[] rows = new System.Data.DataRow[allChangedRows.Count];
                    allChangedRows.CopyTo(rows);
                    for (int i = 0; (i < rows.Length); i = (i + 1)) {
                        global::System.Data.DataRow row = rows[i];
                        row.AcceptChanges();
                    }
                }
            }
            catch (global::System.Exception ex) {
                workTransaction.Rollback();
               
                if (this.BackupDataSetBeforeUpdate) {
                    global::System.Diagnostics.Debug.Assert((backupDataSet != null));
                    dataSet.Clear();
                    dataSet.Merge(backupDataSet);
                }
                else {
                    if ((0 < allAddedRows.Count)) {
                        global::System.Data.DataRow[] rows = new System.Data.DataRow[allAddedRows.Count];
                        allAddedRows.CopyTo(rows);
                        for (int i = 0; (i < rows.Length); i = (i + 1)) {
                            global::System.Data.DataRow row = rows[i];
                            row.AcceptChanges();
                            row.SetAdded();
                        }
                    }
                }
                throw ex;
            }
            finally {
                if (workConnOpened) {
                    workConnection.Close();
                }
                if ((this._customerTableAdapter != null)) {
                    this._customerTableAdapter.Connection = ((global::System.Data.SqlClient.SqlConnection)(revertConnections[this._customerTableAdapter]));
                    this._customerTableAdapter.Transaction = null;
                }
                if ((this._itemTableAdapter != null)) {
                    this._itemTableAdapter.Connection = ((global::System.Data.SqlClient.SqlConnection)(revertConnections[this._itemTableAdapter]));
                    this._itemTableAdapter.Transaction = null;
                }
                if ((this._purchaseTableAdapter != null)) {
                    this._purchaseTableAdapter.Connection = ((global::System.Data.SqlClient.SqlConnection)(revertConnections[this._purchaseTableAdapter]));
                    this._purchaseTableAdapter.Transaction = null;
                }
                if ((this._saleTableAdapter != null)) {
                    this._saleTableAdapter.Connection = ((global::System.Data.SqlClient.SqlConnection)(revertConnections[this._saleTableAdapter]));
                    this._saleTableAdapter.Transaction = null;
                }
                if ((this._supplierTableAdapter != null)) {
                    this._supplierTableAdapter.Connection = ((global::System.Data.SqlClient.SqlConnection)(revertConnections[this._supplierTableAdapter]));
                    this._supplierTableAdapter.Transaction = null;
                }
                if ((0 < adaptersWithAcceptChangesDuringUpdate.Count)) {
                    global::System.Data.Common.DataAdapter[] adapters = new System.Data.Common.DataAdapter[adaptersWithAcceptChangesDuringUpdate.Count];
                    adaptersWithAcceptChangesDuringUpdate.CopyTo(adapters);
                    for (int i = 0; (i < adapters.Length); i = (i + 1)) {
                        global::System.Data.Common.DataAdapter adapter = adapters[i];
                        adapter.AcceptChangesDuringUpdate = true;
                    }
                }
            }
            return result;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        protected virtual void SortSelfReferenceRows(global::System.Data.DataRow[] rows, global::System.Data.DataRelation relation, bool childFirst) {
            global::System.Array.Sort<global::System.Data.DataRow>(rows, new SelfReferenceComparer(relation, childFirst));
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        protected virtual bool MatchTableAdapterConnection(global::System.Data.IDbConnection inputConnection) {
            if ((this._connection != null)) {
                return true;
            }
            if (((this.Connection == null) 
                        || (inputConnection == null))) {
                return true;
            }
            if (string.Equals(this.Connection.ConnectionString, inputConnection.ConnectionString, global::System.StringComparison.Ordinal)) {
                return true;
            }
            return false;
        }
        
       
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        public enum UpdateOrderOption {
            
            InsertUpdateDelete = 0,
            
            UpdateInsertDelete = 1,
        }
       
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        private class SelfReferenceComparer : object, global::System.Collections.Generic.IComparer<global::System.Data.DataRow> {
            
            private global::System.Data.DataRelation _relation;
            
            private int _childFirst;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            internal SelfReferenceComparer(global::System.Data.DataRelation relation, bool childFirst) {
                this._relation = relation;
                if (childFirst) {
                    this._childFirst = -1;
                }
                else {
                    this._childFirst = 1;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            private global::System.Data.DataRow GetRoot(global::System.Data.DataRow row, out int distance) {
                global::System.Diagnostics.Debug.Assert((row != null));
                global::System.Data.DataRow root = row;
                distance = 0;

                global::System.Collections.Generic.IDictionary<global::System.Data.DataRow, global::System.Data.DataRow> traversedRows = new global::System.Collections.Generic.Dictionary<global::System.Data.DataRow, global::System.Data.DataRow>();
                traversedRows[row] = row;

                global::System.Data.DataRow parent = row.GetParentRow(this._relation, global::System.Data.DataRowVersion.Default);
                for (
                ; ((parent != null) 
                            && (traversedRows.ContainsKey(parent) == false)); 
                ) {
                    distance = (distance + 1);
                    root = parent;
                    traversedRows[parent] = parent;
                    parent = parent.GetParentRow(this._relation, global::System.Data.DataRowVersion.Default);
                }

                if ((distance == 0)) {
                    traversedRows.Clear();
                    traversedRows[row] = row;
                    parent = row.GetParentRow(this._relation, global::System.Data.DataRowVersion.Original);
                    for (
                    ; ((parent != null) 
                                && (traversedRows.ContainsKey(parent) == false)); 
                    ) {
                        distance = (distance + 1);
                        root = parent;
                        traversedRows[parent] = parent;
                        parent = parent.GetParentRow(this._relation, global::System.Data.DataRowVersion.Original);
                    }
                }

                return root;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public int Compare(global::System.Data.DataRow row1, global::System.Data.DataRow row2) {
                if (object.ReferenceEquals(row1, row2)) {
                    return 0;
                }
                if ((row1 == null)) {
                    return -1;
                }
                if ((row2 == null)) {
                    return 1;
                }

                int distance1 = 0;
                global::System.Data.DataRow root1 = this.GetRoot(row1, out distance1);

                int distance2 = 0;
                global::System.Data.DataRow root2 = this.GetRoot(row2, out distance2);

                if (object.ReferenceEquals(root1, root2)) {
                    return (this._childFirst * distance1.CompareTo(distance2));
                }
                else {
                    global::System.Diagnostics.Debug.Assert(((root1.Table != null) 
                                    && (root2.Table != null)));
                    if ((root1.Table.Rows.IndexOf(root1) < root2.Table.Rows.IndexOf(root2))) {
                        return -1;
                    }
                    else {
                        return 1;
                    }
                }
            }
        }
    }
}

#pragma warning restore 1591