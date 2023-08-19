using System;

// Token: 0x02000061 RID: 97
internal sealed class <Module>{baa82f7d-fa88-4239-844b-66b7ec16de84}
{
	// Token: 0x060001C3 RID: 451 RVA: 0x00002E69 File Offset: 0x00001069
	// Note: this type is marked as 'beforefieldinit'.
	static <Module>{baa82f7d-fa88-4239-844b-66b7ec16de84}()
	{
		<Module>{baa82f7d-fa88-4239-844b-66b7ec16de84}.w29407045b30a4c83ba1791b7633b3c57();
	}

	// Token: 0x060001C4 RID: 452 RVA: 0x0000D2DC File Offset: 0x0000B4DC
	internal static void w29407045b30a4c83ba1791b7633b3c57()
	{
		/*
An exception occurred when decompiling this method (060001C4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void <Module>{baa82f7d-fa88-4239-844b-66b7ec16de84}::w29407045b30a4c83ba1791b7633b3c57()

 ---> System.NullReferenceException: Object reference not set to an instance of an object.
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.SubstituteTypeArgs(TypeSig type, TypeSig typeContext, IMethod method) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 977
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.GetFieldType(IField field) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 969
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.DoInferTypeForExpression(ILExpression expr, TypeSig expectedType, Boolean forceInferChildren) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 308
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.InferTypeForExpression(ILExpression expr, TypeSig expectedType, Boolean forceInferChildren) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 302
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.DoInferTypeForExpression(ILExpression expr, TypeSig expectedType, Boolean forceInferChildren) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 312
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.InferTypeForExpression(ILExpression expr, TypeSig expectedType, Boolean forceInferChildren) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 302
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.DoInferTypeForExpression(ILExpression expr, TypeSig expectedType, Boolean forceInferChildren) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 852
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.InferTypeForExpression(ILExpression expr, TypeSig expectedType, Boolean forceInferChildren) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 302
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.RunInference(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 276
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.RunInference() in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 219
   at ICSharpCode.Decompiler.ILAst.TypeAnalysis.Run(DecompilerContext context, ILBlock method) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\TypeAnalysis.cs:line 50
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 253
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
	}

	// Token: 0x0400014E RID: 334
	internal int m_f4f0d7379e2546baa83a0f8c21891ca4;

	// Token: 0x0400014F RID: 335
	internal int m_36c73331c0b84f95870ce230b4e03496;

	// Token: 0x04000150 RID: 336
	internal int m_57da73a428534835826c4e1b6a15b859;

	// Token: 0x04000151 RID: 337
	internal int m_3cbab977d7bb4719b007c80fb918baca;

	// Token: 0x04000152 RID: 338
	internal int m_fb39288dbb1a497f8ba4212b7c3d5b4b;

	// Token: 0x04000153 RID: 339
	internal int m_4012bb32e8ab4afe89f8ff672960c8fd;

	// Token: 0x04000154 RID: 340
	internal int m_4395b937702045bab6228273e5b48f47;

	// Token: 0x04000155 RID: 341
	internal int m_9b82a071485848ab8e227994c28b1542;

	// Token: 0x04000156 RID: 342
	internal int m_d1c05aac7bd84c0a960c8f6f8d1a39e3;

	// Token: 0x04000157 RID: 343
	internal int m_e907b0791e064ecb86a6ff9a19158d47;

	// Token: 0x04000158 RID: 344
	internal int m_cef4a75d578943249a696b0a58875686;

	// Token: 0x04000159 RID: 345
	internal int m_fe01201be94f4e8180e45fa1a9116493;

	// Token: 0x0400015A RID: 346
	internal int m_c597e409dc5348bbad643f50976edc2c;

	// Token: 0x0400015B RID: 347
	internal int m_46ddf52aeeaa4a04b99de2db5fd2d364;

	// Token: 0x0400015C RID: 348
	internal int m_d56d9d10ad7943b2930bc44232935bdd;

	// Token: 0x0400015D RID: 349
	internal int m_e6e13a63ed2a4f72b1b301e39d9e525d;

	// Token: 0x0400015E RID: 350
	internal int m_cd68eb08855a44659e5497772d544b09;

	// Token: 0x0400015F RID: 351
	internal int m_ce69cd08d9104d52a4971d1026674af8;

	// Token: 0x04000160 RID: 352
	internal int m_fac646b7396f414e9c00a453ae9b7fa3;

	// Token: 0x04000161 RID: 353
	internal int m_5f8d2c9bd1924903bf6a6b85744bb81d;

	// Token: 0x04000162 RID: 354
	internal int m_e6aaa1d6dc3949868f66428ab648befb;

	// Token: 0x04000163 RID: 355
	internal int m_d46e7af8f5e8497bbe556952f50628e1;

	// Token: 0x04000164 RID: 356
	internal int m_767bc7853a9b44cea754ea957d6c5a92;

	// Token: 0x04000165 RID: 357
	internal int m_2e0b2e9ec16242f1b5289bb8c208e504;

	// Token: 0x04000166 RID: 358
	internal int m_df6f49e73259403e98de2e9ae14d2a77;

	// Token: 0x04000167 RID: 359
	internal int m_526f429c18d64500b5f6f6c72fdaa1c4;

	// Token: 0x04000168 RID: 360
	internal int m_0c00d41d8907491ebf422a8c0c059e4c;

	// Token: 0x04000169 RID: 361
	internal int m_907ae5967cc24cd4a0263d4ed2cc10e1;

	// Token: 0x0400016A RID: 362
	internal int m_60370cbe8b5d4dfbbe429cc46233e888;

	// Token: 0x0400016B RID: 363
	internal int m_9f1bec510c984aca91a78f86b9dcb7ba;

	// Token: 0x0400016C RID: 364
	internal int m_e6b3ab14e94444bcafce602dc5d34ac6;

	// Token: 0x0400016D RID: 365
	internal int m_ee5f14f442b641c6b14ef8ac6264c3b1;

	// Token: 0x0400016E RID: 366
	internal int m_e913acbfb80949aab83c80f77957ce29;

	// Token: 0x0400016F RID: 367
	internal int m_e234c789e0294a8b9756e01f7535b34b;

	// Token: 0x04000170 RID: 368
	internal int m_913ef98aaf9f4bfaa8ec89d44b182578;

	// Token: 0x04000171 RID: 369
	internal int m_da4e20dfb99f4119a1c114b4acfefdc2;

	// Token: 0x04000172 RID: 370
	internal int m_ca40a5e4fdcc4708b813c3ce9c53504c;

	// Token: 0x04000173 RID: 371
	internal int m_c813afbab0254679b738817d48447ebd;

	// Token: 0x04000174 RID: 372
	internal int m_98569a1e361d4fe48aeecca814d22ab2;

	// Token: 0x04000175 RID: 373
	internal int m_74955c4c719f48a1bac8ac7eacdb720b;

	// Token: 0x04000176 RID: 374
	internal int m_8e50ad1eae124012a89a3a7b56473aa8;

	// Token: 0x04000177 RID: 375
	internal int m_d579115110f8445890281ece750249e5;

	// Token: 0x04000178 RID: 376
	internal int m_83ea04fed0bd4aa09da93ca70131deaf;

	// Token: 0x04000179 RID: 377
	internal int m_b57dfc55fbe4474b993a7d8109a18de0;

	// Token: 0x0400017A RID: 378
	internal int m_e631043bebdf4c96925aa7889c361457;

	// Token: 0x0400017B RID: 379
	internal int m_a719a95447a44dacb1fa96394a8e789d;

	// Token: 0x0400017C RID: 380
	internal int m_e335257dc2eb472d92f2f5a1005eb935;

	// Token: 0x0400017D RID: 381
	internal int m_dd8c032667ea46e6bdd1a3a206b78f29;

	// Token: 0x0400017E RID: 382
	internal int m_790a0f18221c41fa94e762460b2bd1f2;

	// Token: 0x0400017F RID: 383
	internal int m_c3f9ada22bcf46afab9ebdd7407070ab;

	// Token: 0x04000180 RID: 384
	internal int m_c52864f355cb48a4971f9ff79b3aee46;

	// Token: 0x04000181 RID: 385
	internal int m_7beed62c96984254a830882292b942da;

	// Token: 0x04000182 RID: 386
	internal int m_023982c7a69e484abf44d84a454d1de4;

	// Token: 0x04000183 RID: 387
	internal int m_a7ad43d7913f46dcaf2dd9792aa1d23c;

	// Token: 0x04000184 RID: 388
	internal int m_28d931ea15ea424e91b03f232dbc4f6b;

	// Token: 0x04000185 RID: 389
	internal int m_e03b52e9b16f460d907c3bcab697421c;

	// Token: 0x04000186 RID: 390
	internal int m_4b45697bc7184fa8abe1339cd061d1c2;

	// Token: 0x04000187 RID: 391
	internal int m_f96dd57b4cac42b3ae1d4e74dc2615b8;

	// Token: 0x04000188 RID: 392
	internal int m_c230ed606822483398cfd2096715f571;

	// Token: 0x04000189 RID: 393
	internal int m_2531f9a7121a4cfbb949e683d53fa92c;

	// Token: 0x0400018A RID: 394
	internal int m_16f116625fee463fb07a1dc3a05db2c4;

	// Token: 0x0400018B RID: 395
	internal int m_70f16a40d79d4fdb8725b850e2ca0bf7;

	// Token: 0x0400018C RID: 396
	internal int m_c74f6367d8604c9e9b24987eaa96ee97;

	// Token: 0x0400018D RID: 397
	internal int m_2a1fd3e935184b76800f0686eacbf7f0;

	// Token: 0x0400018E RID: 398
	internal int m_9273f93696224e3d9e4a75b29f1ee77a;

	// Token: 0x0400018F RID: 399
	internal int m_0ce3159988554246b3e9a09505f06e07;

	// Token: 0x04000190 RID: 400
	internal int m_10715c3606894612af3a1de69f749ec1;

	// Token: 0x04000191 RID: 401
	internal int m_6223c9b514cc418fadf336d24300e06e;

	// Token: 0x04000192 RID: 402
	internal int m_e913f4171acb4ad286818227edf1b448;

	// Token: 0x04000193 RID: 403
	internal int m_2c6c9b1c7aa44535b454219c4fbb551a;

	// Token: 0x04000194 RID: 404
	internal int m_8bb3ad35c143492c8094645c01ae0d5d;

	// Token: 0x04000195 RID: 405
	internal int m_2541d62052f84e3a9b7eff2d335bd25d;

	// Token: 0x04000196 RID: 406
	internal int m_8d86d5bcae5443f0ba6859c64504eac5;

	// Token: 0x04000197 RID: 407
	internal int m_4d0f499fe68642e695e88f247bb34da7;

	// Token: 0x04000198 RID: 408
	internal int m_94214321ff7a4a799042bafdc9f2651f;

	// Token: 0x04000199 RID: 409
	internal int m_5834233b03d84617b882da20076d2fc8;

	// Token: 0x0400019A RID: 410
	internal int m_f70da114a90240dbb99ff39f62940a78;

	// Token: 0x0400019B RID: 411
	internal int m_5eba008fb5254f89a8ff90b4899b1f80;

	// Token: 0x0400019C RID: 412
	internal int m_acc9336ced99400a964c36bdd3e65cac;

	// Token: 0x0400019D RID: 413
	internal int m_b5ef0fbdeef04b029efea8da74555a1d;

	// Token: 0x0400019E RID: 414
	internal int m_5acd84f4c6814da4a8f081263e51a1bc;

	// Token: 0x0400019F RID: 415
	internal int m_836e23e8089b41729977bd7d853d6345;

	// Token: 0x040001A0 RID: 416
	internal int m_8bda1a17579e4e9bb5606720e79b4efc;

	// Token: 0x040001A1 RID: 417
	internal int m_828a85a846584ad3960b4da51c85813c;

	// Token: 0x040001A2 RID: 418
	internal int m_e4343849771d4fbd8d2f601dbec1efb5;

	// Token: 0x040001A3 RID: 419
	internal int m_7b527c7e34b14ce9bae28abd4d8b4102;

	// Token: 0x040001A4 RID: 420
	internal static <Module>{baa82f7d-fa88-4239-844b-66b7ec16de84} m_02c76c30bfbd4e02b5fdcb51a7b0a250;

	// Token: 0x040001A5 RID: 421
	internal int m_e0a4896155bc4df0840da9c2bfc1905a;

	// Token: 0x040001A6 RID: 422
	internal int m_c18abd39154143ebad3536b7e7852a6a;

	// Token: 0x040001A7 RID: 423
	internal int m_a1d2fd98a258437a89bc4088599f1bd1;

	// Token: 0x040001A8 RID: 424
	internal int m_c2f9f4e9da8c4d38be8e8ee98b9f2d24;

	// Token: 0x040001A9 RID: 425
	internal int m_83cde211cc5e46ccaba53e7249635314;

	// Token: 0x040001AA RID: 426
	internal int m_56a522a594864baabb3d4f427b6074bf;

	// Token: 0x040001AB RID: 427
	internal int m_a6567624a6e647ce9c8b2957c2dcafd2;

	// Token: 0x040001AC RID: 428
	internal int m_27ca1bc3be47486e860346db277eaef6;

	// Token: 0x040001AD RID: 429
	internal int m_ee6c4f23cd9546419d0243f4490fcfe9;

	// Token: 0x040001AE RID: 430
	internal int m_ad249889787f4d568e7ea852c36c1688;

	// Token: 0x040001AF RID: 431
	internal int m_00471ac6ba234bdcb75796239ed29112;

	// Token: 0x040001B0 RID: 432
	internal int m_5e399128c9034fa3b4a63f843882f768;

	// Token: 0x040001B1 RID: 433
	internal int m_921b25a7c0ea48e58c8827415c392f53;

	// Token: 0x040001B2 RID: 434
	internal int m_c845c06abb164941bb136371dc514609;

	// Token: 0x040001B3 RID: 435
	internal int m_4c23d2421c064d07b6ff94e785116b49;

	// Token: 0x040001B4 RID: 436
	internal int m_c7bf36b48884486b9123e725d2c81cca;

	// Token: 0x040001B5 RID: 437
	internal int m_0edc7b4ab0be4738bc30e72e729a2c5c;

	// Token: 0x040001B6 RID: 438
	internal int m_b7941bd07ff14fd7a3d84473e31c53f6;

	// Token: 0x040001B7 RID: 439
	internal int m_975401026f7f447faee3e9dc5feacb6e;

	// Token: 0x040001B8 RID: 440
	internal int m_4986755dd4af49c2848193f2bcfd5256;

	// Token: 0x040001B9 RID: 441
	internal int m_ecefa7c668854e9584fbb0e2f7793f8e;

	// Token: 0x040001BA RID: 442
	internal int m_33865e395f394da68c12486a7f1703e6;

	// Token: 0x040001BB RID: 443
	internal int m_46588f6abda54da2b8f3948a922cb0a0;

	// Token: 0x040001BC RID: 444
	internal int m_b52c915f1f29495ea91e778720dde5f3;

	// Token: 0x040001BD RID: 445
	internal int m_a3f58be4f41c4b66b8036b8c5c845fa2;

	// Token: 0x040001BE RID: 446
	internal int m_8bfac70e8c89437690cdcced608a230f;

	// Token: 0x040001BF RID: 447
	internal int m_089faa378b394b819ef8d805f65edb73;

	// Token: 0x040001C0 RID: 448
	internal int m_da96a028ec7249a383cc364cc4938988;

	// Token: 0x040001C1 RID: 449
	internal int m_a83d4fd5092944c1a81cf0ca3d2de0da;

	// Token: 0x040001C2 RID: 450
	internal int m_8b973710beb14c50a4a8925318cc9e66;

	// Token: 0x040001C3 RID: 451
	internal int m_42796c68cabb4d759963cd661d465402;

	// Token: 0x040001C4 RID: 452
	internal int m_eeb2147f3f6a42cbb4a82b9b99355965;
}
