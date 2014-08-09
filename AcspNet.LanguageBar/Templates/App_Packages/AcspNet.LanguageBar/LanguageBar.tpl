<script type="text/javascript">
	function ChangeLanguage()
	{
		$('#LanguageBar').submit();
	}
</script>

<form id="LanguageBar" action="{~}/?act=changeLanguage" method="post">
	<select name="Language" onchange="ChangeLanguage();">
		{LanguagesList}
	</select>
</form>
