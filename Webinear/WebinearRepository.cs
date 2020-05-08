﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace Webinear
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the WebinearRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("7c05e38d-ab39-4bf6-a397-03adedef6f29")]
    public partial class WebinearRepository : RepoGenBaseFolder
    {
        static WebinearRepository instance = new WebinearRepository();
        WebinearRepositoryFolders.ApplicationUnderTestAppFolder _applicationundertest;
        WebinearRepositoryFolders.OneDriveAppFolder _onedrive;
        WebinearRepositoryFolders.AbrirAppFolder _abrir;
        WebinearRepositoryFolders.PersonalCloudStorageMicrosoftOneDriAppFolder _personalcloudstoragemicrosoftonedri;

        /// <summary>
        /// Gets the singleton class instance representing the WebinearRepository element repository.
        /// </summary>
        [RepositoryFolder("7c05e38d-ab39-4bf6-a397-03adedef6f29")]
        public static WebinearRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public WebinearRepository() 
            : base("WebinearRepository", "/", null, 0, false, "7c05e38d-ab39-4bf6-a397-03adedef6f29", ".\\RepositoryImages\\WebinearRepository7c05e38d.rximgres")
        {
            _applicationundertest = new WebinearRepositoryFolders.ApplicationUnderTestAppFolder(this);
            _onedrive = new WebinearRepositoryFolders.OneDriveAppFolder(this);
            _abrir = new WebinearRepositoryFolders.AbrirAppFolder(this);
            _personalcloudstoragemicrosoftonedri = new WebinearRepositoryFolders.PersonalCloudStorageMicrosoftOneDriAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("7c05e38d-ab39-4bf6-a397-03adedef6f29")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The ApplicationUnderTest folder.
        /// </summary>
        [RepositoryFolder("ab06e985-e727-4101-a7d5-b6f7becc30e2")]
        public virtual WebinearRepositoryFolders.ApplicationUnderTestAppFolder ApplicationUnderTest
        {
            get { return _applicationundertest; }
        }

        /// <summary>
        /// The OneDrive folder.
        /// </summary>
        [RepositoryFolder("964008ba-e1ff-45d9-9e35-987aa75f258b")]
        public virtual WebinearRepositoryFolders.OneDriveAppFolder OneDrive
        {
            get { return _onedrive; }
        }

        /// <summary>
        /// The Abrir folder.
        /// </summary>
        [RepositoryFolder("b51da30f-7e31-41a0-8865-e10814e4fea4")]
        public virtual WebinearRepositoryFolders.AbrirAppFolder Abrir
        {
            get { return _abrir; }
        }

        /// <summary>
        /// The PersonalCloudStorageMicrosoftOneDri folder.
        /// </summary>
        [RepositoryFolder("9a32e70c-b44e-47a7-a973-0d4959bc9e3e")]
        public virtual WebinearRepositoryFolders.PersonalCloudStorageMicrosoftOneDriAppFolder PersonalCloudStorageMicrosoftOneDri
        {
            get { return _personalcloudstoragemicrosoftonedri; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class WebinearRepositoryFolders
    {
        /// <summary>
        /// The ApplicationUnderTestAppFolder folder.
        /// </summary>
        [RepositoryFolder("ab06e985-e727-4101-a7d5-b6f7becc30e2")]
        public partial class ApplicationUnderTestAppFolder : RepoGenBaseFolder
        {
            WebinearRepositoryFolders.SomeDivTagFolder _somedivtag;
            WebinearRepositoryFolders.OdBasePageBelowHeaderOdBasePageBeloFolder _odbasepagebelowheaderodbasepagebelo;
            RepoItemInfo _misarchivosInfo;
            RepoItemInfo _carpetaInfo;
            RepoItemInfo _textInfo;
            RepoItemInfo _crearInfo;
            RepoItemInfo _archivosInfo;
            RepoItemInfo _imgtagfInfo;
            RepoItemInfo _mecontrolsignoutlinkInfo;

            /// <summary>
            /// Creates a new ApplicationUnderTest  folder.
            /// </summary>
            public ApplicationUnderTestAppFolder(RepoGenBaseFolder parentFolder) :
                    base("ApplicationUnderTest", "/dom[@domain='onedrive.live.com']", parentFolder, 30000, null, false, "ab06e985-e727-4101-a7d5-b6f7becc30e2", "")
            {
                _somedivtag = new WebinearRepositoryFolders.SomeDivTagFolder(this);
                _odbasepagebelowheaderodbasepagebelo = new WebinearRepositoryFolders.OdBasePageBelowHeaderOdBasePageBeloFolder(this);
                _misarchivosInfo = new RepoItemInfo(this, "MisArchivos", ".//div[#'appRoot']/div/div[2]/div[5]/main//h1[@innertext='Mis archivos']", 30000, null, "fdd98b2f-a234-4a63-8822-8e20a8733ea5");
                _carpetaInfo = new RepoItemInfo(this, "Carpeta", "body/div[3]/div//ul/li[@title='Carpeta']/button[@title='Carpeta']/?/?/span[@innertext='Carpeta']", 30000, null, "874c4bcd-72ce-422e-ae8c-e822cf1be9a3");
                _textInfo = new RepoItemInfo(this, "Text", ".//div[#'od-Dialog-content']//input[@type='text']", 30000, null, "884ce380-329d-40f6-ba68-adca3cb750c9");
                _crearInfo = new RepoItemInfo(this, "Crear", ".//div[#'appRoot']/div/div[5]/div/div/div/div/div[2]/div/div/div[2]/div[2]//span[@innertext='Crear']", 30000, null, "7ef60b90-7f93-4834-b6e6-efd8b0b76b1f");
                _archivosInfo = new RepoItemInfo(this, "Archivos", "body/div[3]/div//ul/li[@title='Archivos']/button[@title='Archivos']/?/?/span[@innertext='Archivos']", 30000, null, "aac94574-a57c-49f6-9013-9485ff8bd75c");
                _imgtagfInfo = new RepoItemInfo(this, "ImgTagF", ".//div[#'appRoot']/div/div[1]/div/div[1]/div[3]/div[1]/button[@title>'Administrador de cuenta para']/div/div[2]//img[@alt='F']", 30000, null, "a492356a-c3a9-4e00-926e-b26327f8e855");
                _mecontrolsignoutlinkInfo = new RepoItemInfo(this, "MeControlSignoutLink", ".//a[#'meControlSignoutLink']", 30000, null, "f81a20db-3052-4552-9cdc-7bb03c87c0d6");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("ab06e985-e727-4101-a7d5-b6f7becc30e2")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("ab06e985-e727-4101-a7d5-b6f7becc30e2")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The MisArchivos item.
            /// </summary>
            [RepositoryItem("fdd98b2f-a234-4a63-8822-8e20a8733ea5")]
            public virtual Ranorex.H1Tag MisArchivos
            {
                get
                {
                    return _misarchivosInfo.CreateAdapter<Ranorex.H1Tag>(true);
                }
            }

            /// <summary>
            /// The MisArchivos item info.
            /// </summary>
            [RepositoryItemInfo("fdd98b2f-a234-4a63-8822-8e20a8733ea5")]
            public virtual RepoItemInfo MisArchivosInfo
            {
                get
                {
                    return _misarchivosInfo;
                }
            }

            /// <summary>
            /// The Carpeta item.
            /// </summary>
            [RepositoryItem("874c4bcd-72ce-422e-ae8c-e822cf1be9a3")]
            public virtual Ranorex.SpanTag Carpeta
            {
                get
                {
                    return _carpetaInfo.CreateAdapter<Ranorex.SpanTag>(true);
                }
            }

            /// <summary>
            /// The Carpeta item info.
            /// </summary>
            [RepositoryItemInfo("874c4bcd-72ce-422e-ae8c-e822cf1be9a3")]
            public virtual RepoItemInfo CarpetaInfo
            {
                get
                {
                    return _carpetaInfo;
                }
            }

            /// <summary>
            /// The Text item.
            /// </summary>
            [RepositoryItem("884ce380-329d-40f6-ba68-adca3cb750c9")]
            public virtual Ranorex.InputTag Text
            {
                get
                {
                    return _textInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The Text item info.
            /// </summary>
            [RepositoryItemInfo("884ce380-329d-40f6-ba68-adca3cb750c9")]
            public virtual RepoItemInfo TextInfo
            {
                get
                {
                    return _textInfo;
                }
            }

            /// <summary>
            /// The Crear item.
            /// </summary>
            [RepositoryItem("7ef60b90-7f93-4834-b6e6-efd8b0b76b1f")]
            public virtual Ranorex.SpanTag Crear
            {
                get
                {
                    return _crearInfo.CreateAdapter<Ranorex.SpanTag>(true);
                }
            }

            /// <summary>
            /// The Crear item info.
            /// </summary>
            [RepositoryItemInfo("7ef60b90-7f93-4834-b6e6-efd8b0b76b1f")]
            public virtual RepoItemInfo CrearInfo
            {
                get
                {
                    return _crearInfo;
                }
            }

            /// <summary>
            /// The Archivos item.
            /// </summary>
            [RepositoryItem("aac94574-a57c-49f6-9013-9485ff8bd75c")]
            public virtual Ranorex.SpanTag Archivos
            {
                get
                {
                    return _archivosInfo.CreateAdapter<Ranorex.SpanTag>(true);
                }
            }

            /// <summary>
            /// The Archivos item info.
            /// </summary>
            [RepositoryItemInfo("aac94574-a57c-49f6-9013-9485ff8bd75c")]
            public virtual RepoItemInfo ArchivosInfo
            {
                get
                {
                    return _archivosInfo;
                }
            }

            /// <summary>
            /// The ImgTagF item.
            /// </summary>
            [RepositoryItem("a492356a-c3a9-4e00-926e-b26327f8e855")]
            public virtual Ranorex.ImgTag ImgTagF
            {
                get
                {
                    return _imgtagfInfo.CreateAdapter<Ranorex.ImgTag>(true);
                }
            }

            /// <summary>
            /// The ImgTagF item info.
            /// </summary>
            [RepositoryItemInfo("a492356a-c3a9-4e00-926e-b26327f8e855")]
            public virtual RepoItemInfo ImgTagFInfo
            {
                get
                {
                    return _imgtagfInfo;
                }
            }

            /// <summary>
            /// The MeControlSignoutLink item.
            /// </summary>
            [RepositoryItem("f81a20db-3052-4552-9cdc-7bb03c87c0d6")]
            public virtual Ranorex.ATag MeControlSignoutLink
            {
                get
                {
                    return _mecontrolsignoutlinkInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The MeControlSignoutLink item info.
            /// </summary>
            [RepositoryItemInfo("f81a20db-3052-4552-9cdc-7bb03c87c0d6")]
            public virtual RepoItemInfo MeControlSignoutLinkInfo
            {
                get
                {
                    return _mecontrolsignoutlinkInfo;
                }
            }

            /// <summary>
            /// The SomeDivTag folder.
            /// </summary>
            [RepositoryFolder("ddeb0015-73ae-43c1-a54e-bdb8de78fd21")]
            public virtual WebinearRepositoryFolders.SomeDivTagFolder SomeDivTag
            {
                get { return _somedivtag; }
            }

            /// <summary>
            /// The OdBasePageBelowHeaderOdBasePageBelo folder.
            /// </summary>
            [RepositoryFolder("afa0188d-c2ad-4217-bbdf-4b6f473642dd")]
            public virtual WebinearRepositoryFolders.OdBasePageBelowHeaderOdBasePageBeloFolder OdBasePageBelowHeaderOdBasePageBelo
            {
                get { return _odbasepagebelowheaderodbasepagebelo; }
            }
        }

        /// <summary>
        /// The SomeDivTagFolder folder.
        /// </summary>
        [RepositoryFolder("ddeb0015-73ae-43c1-a54e-bdb8de78fd21")]
        public partial class SomeDivTagFolder : RepoGenBaseFolder
        {
            RepoItemInfo _emailInfo;
            RepoItemInfo _personalaccountInfo;
            RepoItemInfo _submitInfo;

            /// <summary>
            /// Creates a new SomeDivTag  folder.
            /// </summary>
            public SomeDivTagFolder(RepoGenBaseFolder parentFolder) :
                    base("SomeDivTag", ".//section[#'mainContent']/iframe[@src='https://odc.officeapps.live.com/odc/v2.0/hrd?rs=en-us&Ver=16&app=23&p=6&hm=0']/body/div[2]/?/?/main/div[2]", parentFolder, 30000, null, false, "ddeb0015-73ae-43c1-a54e-bdb8de78fd21", "")
            {
                _emailInfo = new RepoItemInfo(this, "Email", "div[2]/?/?/input[@type='email']", 30000, null, "a04f3fb6-5d1e-43c6-bb7b-46c2cfce194b");
                _personalaccountInfo = new RepoItemInfo(this, "PersonalAccount", "div[3]/?/?/div[@innertext='Personal account']", 30000, null, "000d72b9-c9fc-4257-8bac-a83ece67a260");
                _submitInfo = new RepoItemInfo(this, "Submit", "div[4]/input[@type='submit']", 30000, null, "7262f51a-b9b3-4ca1-8095-25bfb56b8ab4");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("ddeb0015-73ae-43c1-a54e-bdb8de78fd21")]
            public virtual Ranorex.DivTag Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("ddeb0015-73ae-43c1-a54e-bdb8de78fd21")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Email item.
            /// </summary>
            [RepositoryItem("a04f3fb6-5d1e-43c6-bb7b-46c2cfce194b")]
            public virtual Ranorex.InputTag Email
            {
                get
                {
                    return _emailInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The Email item info.
            /// </summary>
            [RepositoryItemInfo("a04f3fb6-5d1e-43c6-bb7b-46c2cfce194b")]
            public virtual RepoItemInfo EmailInfo
            {
                get
                {
                    return _emailInfo;
                }
            }

            /// <summary>
            /// The PersonalAccount item.
            /// </summary>
            [RepositoryItem("000d72b9-c9fc-4257-8bac-a83ece67a260")]
            public virtual Ranorex.DivTag PersonalAccount
            {
                get
                {
                    return _personalaccountInfo.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The PersonalAccount item info.
            /// </summary>
            [RepositoryItemInfo("000d72b9-c9fc-4257-8bac-a83ece67a260")]
            public virtual RepoItemInfo PersonalAccountInfo
            {
                get
                {
                    return _personalaccountInfo;
                }
            }

            /// <summary>
            /// The Submit item.
            /// </summary>
            [RepositoryItem("7262f51a-b9b3-4ca1-8095-25bfb56b8ab4")]
            public virtual Ranorex.InputTag Submit
            {
                get
                {
                    return _submitInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The Submit item info.
            /// </summary>
            [RepositoryItemInfo("7262f51a-b9b3-4ca1-8095-25bfb56b8ab4")]
            public virtual RepoItemInfo SubmitInfo
            {
                get
                {
                    return _submitInfo;
                }
            }
        }

        /// <summary>
        /// The OdBasePageBelowHeaderOdBasePageBeloFolder folder.
        /// </summary>
        [RepositoryFolder("afa0188d-c2ad-4217-bbdf-4b6f473642dd")]
        public partial class OdBasePageBelowHeaderOdBasePageBeloFolder : RepoGenBaseFolder
        {
            RepoItemInfo _nuevoInfo;
            RepoItemInfo _cargarInfo;
            RepoItemInfo _prueba1Info;
            RepoItemInfo _pruebatxtInfo;
            RepoItemInfo _pruebaInfo;

            /// <summary>
            /// Creates a new OdBasePageBelowHeaderOdBasePageBelo  folder.
            /// </summary>
            public OdBasePageBelowHeaderOdBasePageBeloFolder(RepoGenBaseFolder parentFolder) :
                    base("OdBasePageBelowHeaderOdBasePageBelo", ".//div[#'appRoot']/div/div[2]", parentFolder, 30000, null, false, "afa0188d-c2ad-4217-bbdf-4b6f473642dd", "")
            {
                _nuevoInfo = new RepoItemInfo(this, "Nuevo", "div[2]/div/div[2]/div/div/div/div/div/div/div/div/div/div[1]/div[1]/button[@title>'Crear una carpeta o un documento']/span/span/span[@innertext='Nuevo']", 30000, null, "329ac363-6f12-41dd-a909-80d734e5c88f");
                _cargarInfo = new RepoItemInfo(this, "Cargar", "div[2]/div/div[2]/div/div/div/div/div/div/div/div/div/div[1]/div[2]/button[@title>'Cargar archivos de tu equipo']/span/span/span[@innertext='Cargar']", 30000, null, "77d4c652-6d01-4882-85d6-39fe5bbff17f");
                _prueba1Info = new RepoItemInfo(this, "Prueba1", "div[5]/main//nav/ul/?/?/span[@title='Prueba']", 30000, null, "bbd760b1-32df-42c5-a238-9a7716c4fb8e");
                _pruebatxtInfo = new RepoItemInfo(this, "PruebaTxt", "div[5]/main/div/div/div/div[2]/div/div/div/div/div/div/div/div/div/div/div/div//a[@href>'https://onedrive.live.com']/span[3]/span[1]/span/span[2]/span[@innertext='prueba.txt']", 30000, null, "913d4461-d693-4add-addb-7c7a7997a250");
                _pruebaInfo = new RepoItemInfo(this, "Prueba", "div[5]/main/div/div/div[2]/div[2]/div/div/div/div/div/div/div/div/div[1]//a[@href>'https://onedrive.live.com']/span[3]/span[1]/span/span[2]/span[@innertext='Prueba']", 30000, null, "075b741b-f718-4019-8b2f-163fce576fce");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("afa0188d-c2ad-4217-bbdf-4b6f473642dd")]
            public virtual Ranorex.DivTag Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("afa0188d-c2ad-4217-bbdf-4b6f473642dd")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Nuevo item.
            /// </summary>
            [RepositoryItem("329ac363-6f12-41dd-a909-80d734e5c88f")]
            public virtual Ranorex.SpanTag Nuevo
            {
                get
                {
                    return _nuevoInfo.CreateAdapter<Ranorex.SpanTag>(true);
                }
            }

            /// <summary>
            /// The Nuevo item info.
            /// </summary>
            [RepositoryItemInfo("329ac363-6f12-41dd-a909-80d734e5c88f")]
            public virtual RepoItemInfo NuevoInfo
            {
                get
                {
                    return _nuevoInfo;
                }
            }

            /// <summary>
            /// The Cargar item.
            /// </summary>
            [RepositoryItem("77d4c652-6d01-4882-85d6-39fe5bbff17f")]
            public virtual Ranorex.SpanTag Cargar
            {
                get
                {
                    return _cargarInfo.CreateAdapter<Ranorex.SpanTag>(true);
                }
            }

            /// <summary>
            /// The Cargar item info.
            /// </summary>
            [RepositoryItemInfo("77d4c652-6d01-4882-85d6-39fe5bbff17f")]
            public virtual RepoItemInfo CargarInfo
            {
                get
                {
                    return _cargarInfo;
                }
            }

            /// <summary>
            /// The Prueba1 item.
            /// </summary>
            [RepositoryItem("bbd760b1-32df-42c5-a238-9a7716c4fb8e")]
            public virtual Ranorex.SpanTag Prueba1
            {
                get
                {
                    return _prueba1Info.CreateAdapter<Ranorex.SpanTag>(true);
                }
            }

            /// <summary>
            /// The Prueba1 item info.
            /// </summary>
            [RepositoryItemInfo("bbd760b1-32df-42c5-a238-9a7716c4fb8e")]
            public virtual RepoItemInfo Prueba1Info
            {
                get
                {
                    return _prueba1Info;
                }
            }

            /// <summary>
            /// The PruebaTxt item.
            /// </summary>
            [RepositoryItem("913d4461-d693-4add-addb-7c7a7997a250")]
            public virtual Ranorex.SpanTag PruebaTxt
            {
                get
                {
                    return _pruebatxtInfo.CreateAdapter<Ranorex.SpanTag>(true);
                }
            }

            /// <summary>
            /// The PruebaTxt item info.
            /// </summary>
            [RepositoryItemInfo("913d4461-d693-4add-addb-7c7a7997a250")]
            public virtual RepoItemInfo PruebaTxtInfo
            {
                get
                {
                    return _pruebatxtInfo;
                }
            }

            /// <summary>
            /// The Prueba item.
            /// </summary>
            [RepositoryItem("075b741b-f718-4019-8b2f-163fce576fce")]
            public virtual Ranorex.SpanTag Prueba
            {
                get
                {
                    return _pruebaInfo.CreateAdapter<Ranorex.SpanTag>(true);
                }
            }

            /// <summary>
            /// The Prueba item info.
            /// </summary>
            [RepositoryItemInfo("075b741b-f718-4019-8b2f-163fce576fce")]
            public virtual RepoItemInfo PruebaInfo
            {
                get
                {
                    return _pruebaInfo;
                }
            }
        }

        /// <summary>
        /// The OneDriveAppFolder folder.
        /// </summary>
        [RepositoryFolder("964008ba-e1ff-45d9-9e35-987aa75f258b")]
        public partial class OneDriveAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _somedivtagInfo;
            RepoItemInfo _passwdInfo;
            RepoItemInfo _idsibutton9Info;

            /// <summary>
            /// Creates a new OneDrive  folder.
            /// </summary>
            public OneDriveAppFolder(RepoGenBaseFolder parentFolder) :
                    base("OneDrive", "/dom[@domain='login.live.com']", parentFolder, 30000, null, false, "964008ba-e1ff-45d9-9e35-987aa75f258b", "")
            {
                _somedivtagInfo = new RepoItemInfo(this, "SomeDivTag", ".//form[@name='f1']/div/div/div[1]/div[3]/div", 30000, null, "da95b3bb-fa4a-45b7-adaf-972c09fbc51c");
                _passwdInfo = new RepoItemInfo(this, "Passwd", "body/?/?/form[@name='f1']/div/div/div[1]//div/div[2]/div/div[2]//input[@name='passwd']", 30000, null, "e9149842-e18e-4c52-92ce-7f6700bc8c8a");
                _idsibutton9Info = new RepoItemInfo(this, "IdSIButton9", ".//input[#'idSIButton9']", 30000, null, "c9e6d337-fffb-46f7-a623-fb665c72faca");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("964008ba-e1ff-45d9-9e35-987aa75f258b")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("964008ba-e1ff-45d9-9e35-987aa75f258b")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The SomeDivTag item.
            /// </summary>
            [RepositoryItem("da95b3bb-fa4a-45b7-adaf-972c09fbc51c")]
            public virtual Ranorex.DivTag SomeDivTag
            {
                get
                {
                    return _somedivtagInfo.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The SomeDivTag item info.
            /// </summary>
            [RepositoryItemInfo("da95b3bb-fa4a-45b7-adaf-972c09fbc51c")]
            public virtual RepoItemInfo SomeDivTagInfo
            {
                get
                {
                    return _somedivtagInfo;
                }
            }

            /// <summary>
            /// The Passwd item.
            /// </summary>
            [RepositoryItem("e9149842-e18e-4c52-92ce-7f6700bc8c8a")]
            public virtual Ranorex.InputTag Passwd
            {
                get
                {
                    return _passwdInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The Passwd item info.
            /// </summary>
            [RepositoryItemInfo("e9149842-e18e-4c52-92ce-7f6700bc8c8a")]
            public virtual RepoItemInfo PasswdInfo
            {
                get
                {
                    return _passwdInfo;
                }
            }

            /// <summary>
            /// The IdSIButton9 item.
            /// </summary>
            [RepositoryItem("c9e6d337-fffb-46f7-a623-fb665c72faca")]
            public virtual Ranorex.InputTag IdSIButton9
            {
                get
                {
                    return _idsibutton9Info.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The IdSIButton9 item info.
            /// </summary>
            [RepositoryItemInfo("c9e6d337-fffb-46f7-a623-fb665c72faca")]
            public virtual RepoItemInfo IdSIButton9Info
            {
                get
                {
                    return _idsibutton9Info;
                }
            }
        }

        /// <summary>
        /// The AbrirAppFolder folder.
        /// </summary>
        [RepositoryFolder("b51da30f-7e31-41a0-8865-e10814e4fea4")]
        public partial class AbrirAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _escritorioInfo;
            RepoItemInfo _text1148Info;
            RepoItemInfo _buttonabrirInfo;

            /// <summary>
            /// Creates a new Abrir  folder.
            /// </summary>
            public AbrirAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Abrir", "/form[@title='Abrir']", parentFolder, 30000, null, true, "b51da30f-7e31-41a0-8865-e10814e4fea4", "")
            {
                _escritorioInfo = new RepoItemInfo(this, "Escritorio", "element[@class='WorkerW']/container[@controlid='40965']//toolbar[@controlid='1001']/button[@text='Escritorio']", 30000, null, "d47191ea-cd7c-46fc-a1b3-75b92b2055f3");
                _text1148Info = new RepoItemInfo(this, "Text1148", "?/?/text[@controlid='1148']", 30000, null, "be108905-7299-4897-bf61-741bc3e3db6a");
                _buttonabrirInfo = new RepoItemInfo(this, "ButtonAbrir", "button[@text='&Abrir']", 30000, null, "f3f366a6-e5c6-478e-a832-aa09fb1132bb");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("b51da30f-7e31-41a0-8865-e10814e4fea4")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("b51da30f-7e31-41a0-8865-e10814e4fea4")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Escritorio item.
            /// </summary>
            [RepositoryItem("d47191ea-cd7c-46fc-a1b3-75b92b2055f3")]
            public virtual Ranorex.Button Escritorio
            {
                get
                {
                    return _escritorioInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Escritorio item info.
            /// </summary>
            [RepositoryItemInfo("d47191ea-cd7c-46fc-a1b3-75b92b2055f3")]
            public virtual RepoItemInfo EscritorioInfo
            {
                get
                {
                    return _escritorioInfo;
                }
            }

            /// <summary>
            /// The Text1148 item.
            /// </summary>
            [RepositoryItem("be108905-7299-4897-bf61-741bc3e3db6a")]
            public virtual Ranorex.Text Text1148
            {
                get
                {
                    return _text1148Info.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Text1148 item info.
            /// </summary>
            [RepositoryItemInfo("be108905-7299-4897-bf61-741bc3e3db6a")]
            public virtual RepoItemInfo Text1148Info
            {
                get
                {
                    return _text1148Info;
                }
            }

            /// <summary>
            /// The ButtonAbrir item.
            /// </summary>
            [RepositoryItem("f3f366a6-e5c6-478e-a832-aa09fb1132bb")]
            public virtual Ranorex.Button ButtonAbrir
            {
                get
                {
                    return _buttonabrirInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The ButtonAbrir item info.
            /// </summary>
            [RepositoryItemInfo("f3f366a6-e5c6-478e-a832-aa09fb1132bb")]
            public virtual RepoItemInfo ButtonAbrirInfo
            {
                get
                {
                    return _buttonabrirInfo;
                }
            }
        }

        /// <summary>
        /// The PersonalCloudStorageMicrosoftOneDriAppFolder folder.
        /// </summary>
        [RepositoryFolder("9a32e70c-b44e-47a7-a973-0d4959bc9e3e")]
        public partial class PersonalCloudStorageMicrosoftOneDriAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _spantagsigninInfo;

            /// <summary>
            /// Creates a new PersonalCloudStorageMicrosoftOneDri  folder.
            /// </summary>
            public PersonalCloudStorageMicrosoftOneDriAppFolder(RepoGenBaseFolder parentFolder) :
                    base("PersonalCloudStorageMicrosoftOneDri", "/dom[@domain~'microsoft']", parentFolder, 30000, null, false, "9a32e70c-b44e-47a7-a973-0d4959bc9e3e", "")
            {
                _spantagsigninInfo = new RepoItemInfo(this, "SpanTagSignIn", ".//div[#'heroregion']/?/?/section/div/div/div/div/div/div//a[@href>'https://go.microsoft.com/']/span[@innertext~'Sign in']", 30000, null, "bbfe3c0e-1099-4977-a203-8d31002dc951");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("9a32e70c-b44e-47a7-a973-0d4959bc9e3e")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("9a32e70c-b44e-47a7-a973-0d4959bc9e3e")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The SpanTagSignIn item.
            /// </summary>
            [RepositoryItem("bbfe3c0e-1099-4977-a203-8d31002dc951")]
            public virtual Ranorex.SpanTag SpanTagSignIn
            {
                get
                {
                    return _spantagsigninInfo.CreateAdapter<Ranorex.SpanTag>(true);
                }
            }

            /// <summary>
            /// The SpanTagSignIn item info.
            /// </summary>
            [RepositoryItemInfo("bbfe3c0e-1099-4977-a203-8d31002dc951")]
            public virtual RepoItemInfo SpanTagSignInInfo
            {
                get
                {
                    return _spantagsigninInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
