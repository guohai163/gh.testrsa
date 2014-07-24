##Microsoft .Net RSA encrypt and decrypt demo##
###名词解释###
RSA加密算法是一种非对称加密算法。在公开密钥加密和电子商业中RSA被广泛使用。RSA是1977年由罗纳德·李维斯特（Ron Rivest）、阿迪·萨莫尔（Adi Shamir）和伦纳德·阿德曼（Leonard Adleman）一起提出的。当时他们三人都在麻省理工学院工作。RSA就是他们三人姓氏开头字母拼在一起组成的。

非对称加密即有公私钥成对出现，公钥只负责对数据进行加密。并可以做为公用发放给任何人。私钥用来对数据进行解密。本次教程我们使用.net框架的RSACryptoServiceProvider进行演示。

###密钥的产生与导出###
1. 生成公私钥对  
	`aspnet_regiis.exe -pc {密钥容器名} -exp`  
    *其中`-pc` 为创建秘要容器命令，`-exp`参数为所创建的密钥为可导出*
2. 导出密钥
	1. 导出公钥用来发布给其它机器进行加密
		`aspnet_regiis.exe -px {密钥容器名} {密钥存储路径}`
	2. 导出私钥用来进行备份
		`aspnet_regiis.exe -px {密钥容器名} {密钥存储路径} -pri`
3. 导入密钥，	在公有计算机上导入公钥进行加密操作
	`aspnet_regiis.exe -pi {密钥容器名} {密钥存储路径}`
		


###参考资料###
[ASP.NET IIS Registration Tool ](http://msdn.microsoft.com/zh-cn/library/k6h9cz8h(v=vs.100).aspx)  
