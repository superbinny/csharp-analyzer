using System;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Exercism.Analyzers.CSharp.Analyzers;

internal class ShowAllAnalyzer : Analyzer
{
    public ShowAllAnalyzer(Submission submission) : base(submission)
    {
    }

    static int Tabs = 0;
    public override void Visit(SyntaxNode node)
    {
        Tabs++;
        var indents = new String(' ', Tabs);
        Console.WriteLine(indents + node.Kind() + ": " + DetailType(node));
        base.Visit(node);
        Tabs--;
    }

    private string DetailType(SyntaxNode node)
    {
        // https://github.com/dotnet/roslyn/
        // https://sapehin.com/blog/csharp-via-roslynapi-the-big-picture/
        Type nodeType = node.GetType();
        string desc;

        #region

        if (nodeType == typeof(AccessorDeclarationSyntax))
        {
            AccessorDeclarationSyntax node_Syntax = node as AccessorDeclarationSyntax;
            desc = "AccessorDeclarationSyntax";
        }
        else if (nodeType == typeof(AccessorListSyntax))
        {
            AccessorListSyntax node_Syntax = node as AccessorListSyntax;
            desc = "AccessorListSyntax";
        }
        else if (nodeType == typeof(AliasQualifiedNameSyntax))
        {
            AliasQualifiedNameSyntax node_Syntax = node as AliasQualifiedNameSyntax;
            desc = "AliasQualifiedNameSyntax";
        }
        else if (nodeType == typeof(AllowsConstraintClauseSyntax))
        {
            AllowsConstraintClauseSyntax node_Syntax = node as AllowsConstraintClauseSyntax;
            desc = "AllowsConstraintClauseSyntax";
        }
        else if (nodeType == typeof(AllowsConstraintSyntax))
        {
            AllowsConstraintSyntax node_Syntax = node as AllowsConstraintSyntax;
            desc = "AllowsConstraintSyntax";
        }
        else if (nodeType == typeof(AnonymousFunctionExpressionSyntax))
        {
            AnonymousFunctionExpressionSyntax node_Syntax = node as AnonymousFunctionExpressionSyntax;
            desc = "AnonymousFunctionExpressionSyntax";
        }
        else if (nodeType == typeof(AnonymousMethodExpressionSyntax))
        {
            AnonymousMethodExpressionSyntax node_Syntax = node as AnonymousMethodExpressionSyntax;
            desc = "AnonymousMethodExpressionSyntax";
        }
        else if (nodeType == typeof(AnonymousObjectCreationExpressionSyntax))
        {
            AnonymousObjectCreationExpressionSyntax node_Syntax = node as AnonymousObjectCreationExpressionSyntax;
            desc = "AnonymousObjectCreationExpressionSyntax";
        }
        else if (nodeType == typeof(AnonymousObjectMemberDeclaratorSyntax))
        {
            AnonymousObjectMemberDeclaratorSyntax node_Syntax = node as AnonymousObjectMemberDeclaratorSyntax;
            desc = "AnonymousObjectMemberDeclaratorSyntax";
        }
        else if (nodeType == typeof(ArgumentListSyntax))
        {
            ArgumentListSyntax node_Syntax = node as ArgumentListSyntax;
            desc = "ArgumentListSyntax";
        }
        else if (nodeType == typeof(ArgumentSyntax))
        {
            ArgumentSyntax node_Syntax = node as ArgumentSyntax;
            desc = "ArgumentSyntax";
        }
        else if (nodeType == typeof(ArrayCreationExpressionSyntax))
        {
            ArrayCreationExpressionSyntax node_Syntax = node as ArrayCreationExpressionSyntax;
            desc = "ArrayCreationExpressionSyntax";
        }
        else if (nodeType == typeof(ArrayRankSpecifierSyntax))
        {
            ArrayRankSpecifierSyntax node_Syntax = node as ArrayRankSpecifierSyntax;
            desc = "ArrayRankSpecifierSyntax";
        }
        else if (nodeType == typeof(ArrayTypeSyntax))
        {
            ArrayTypeSyntax node_Syntax = node as ArrayTypeSyntax;
            desc = "ArrayTypeSyntax";
        }
        else if (nodeType == typeof(ArrowExpressionClauseSyntax))
        {
            ArrowExpressionClauseSyntax node_Syntax = node as ArrowExpressionClauseSyntax;
            desc = "ArrowExpressionClauseSyntax";
        }
        else if (nodeType == typeof(AssignmentExpressionSyntax))
        {
            AssignmentExpressionSyntax node_Syntax = node as AssignmentExpressionSyntax;
            desc = "AssignmentExpressionSyntax";
        }
        else if (nodeType == typeof(AttributeArgumentListSyntax))
        {
            AttributeArgumentListSyntax node_Syntax = node as AttributeArgumentListSyntax;
            desc = "AttributeArgumentListSyntax";
        }
        else if (nodeType == typeof(AttributeArgumentSyntax))
        {
            AttributeArgumentSyntax node_Syntax = node as AttributeArgumentSyntax;
            desc = "AttributeArgumentSyntax";
        }
        else if (nodeType == typeof(AttributeListSyntax))
        {
            AttributeListSyntax node_Syntax = node as AttributeListSyntax;
            desc = "AttributeListSyntax";
        }
        else if (nodeType == typeof(AttributeSyntax))
        {
            AttributeSyntax node_Syntax = node as AttributeSyntax;
            desc = "AttributeSyntax";
        }
        else if (nodeType == typeof(AttributeTargetSpecifierSyntax))
        {
            AttributeTargetSpecifierSyntax node_Syntax = node as AttributeTargetSpecifierSyntax;
            desc = node_Syntax.Identifier.Text;
        }
        else if (nodeType == typeof(AwaitExpressionSyntax))
        {
            AwaitExpressionSyntax node_Syntax = node as AwaitExpressionSyntax;
            desc = "AwaitExpressionSyntax";
        }
        else if (nodeType == typeof(BadDirectiveTriviaSyntax))
        {
            BadDirectiveTriviaSyntax node_Syntax = node as BadDirectiveTriviaSyntax;
            desc = node_Syntax.Identifier.Text;
        }
        else if (nodeType == typeof(BaseArgumentListSyntax))
        {
            BaseArgumentListSyntax node_Syntax = node as BaseArgumentListSyntax;
            desc = "BaseArgumentListSyntax";
        }
        else if (nodeType == typeof(BaseCrefParameterListSyntax))
        {
            BaseCrefParameterListSyntax node_Syntax = node as BaseCrefParameterListSyntax;
            desc = "BaseCrefParameterListSyntax";
        }
        else if (nodeType == typeof(BaseExpressionColonSyntax))
        {
            BaseExpressionColonSyntax node_Syntax = node as BaseExpressionColonSyntax;
            desc = "BaseExpressionColonSyntax";
        }
        else if (nodeType == typeof(BaseExpressionSyntax))
        {
            BaseExpressionSyntax node_Syntax = node as BaseExpressionSyntax;
            desc = "BaseExpressionSyntax";
        }
        else if (nodeType == typeof(BaseFieldDeclarationSyntax))
        {
            BaseFieldDeclarationSyntax node_Syntax = node as BaseFieldDeclarationSyntax;
            desc = "BaseFieldDeclarationSyntax";
        }
        else if (nodeType == typeof(BaseListSyntax))
        {
            BaseListSyntax node_Syntax = node as BaseListSyntax;
            desc = "BaseListSyntax";
        }
        else if (nodeType == typeof(BaseMethodDeclarationSyntax))
        {
            BaseMethodDeclarationSyntax node_Syntax = node as BaseMethodDeclarationSyntax;
            desc = "BaseMethodDeclarationSyntax";
        }
        else if (nodeType == typeof(BaseNamespaceDeclarationSyntax))
        {
            BaseNamespaceDeclarationSyntax node_Syntax = node as BaseNamespaceDeclarationSyntax;
            desc = "BaseNamespaceDeclarationSyntax";
        }
        else if (nodeType == typeof(BaseObjectCreationExpressionSyntax))
        {
            BaseObjectCreationExpressionSyntax node_Syntax = node as BaseObjectCreationExpressionSyntax;
            desc = "BaseObjectCreationExpressionSyntax";
        }
        else if (nodeType == typeof(BaseParameterListSyntax))
        {
            BaseParameterListSyntax node_Syntax = node as BaseParameterListSyntax;
            desc = "BaseParameterListSyntax";
        }
        else if (nodeType == typeof(BaseParameterSyntax))
        {
            BaseParameterSyntax node_Syntax = node as BaseParameterSyntax;
            desc = "BaseParameterSyntax";
        }
        else if (nodeType == typeof(BasePropertyDeclarationSyntax))
        {
            BasePropertyDeclarationSyntax node_Syntax = node as BasePropertyDeclarationSyntax;
            desc = "BasePropertyDeclarationSyntax";
        }
        else if (nodeType == typeof(BaseTypeDeclarationSyntax))
        {
            BaseTypeDeclarationSyntax node_Syntax = node as BaseTypeDeclarationSyntax;
            desc = node_Syntax.Identifier.Text;
        }
        else if (nodeType == typeof(BaseTypeSyntax))
        {
            BaseTypeSyntax node_Syntax = node as BaseTypeSyntax;
            desc = "BaseTypeSyntax";
        }
        else if (nodeType == typeof(BinaryExpressionSyntax))
        {
            BinaryExpressionSyntax node_Syntax = node as BinaryExpressionSyntax;
            desc = "BinaryExpressionSyntax";
        }
        else if (nodeType == typeof(BinaryPatternSyntax))
        {
            BinaryPatternSyntax node_Syntax = node as BinaryPatternSyntax;
            desc = "BinaryPatternSyntax";
        }
        else if (nodeType == typeof(BlockSyntax))
        {
            BlockSyntax node_Syntax = node as BlockSyntax;
            desc = "BlockSyntax";
        }
        else if (nodeType == typeof(BracketedArgumentListSyntax))
        {
            BracketedArgumentListSyntax node_Syntax = node as BracketedArgumentListSyntax;
            desc = "BracketedArgumentListSyntax";
        }
        else if (nodeType == typeof(BracketedParameterListSyntax))
        {
            BracketedParameterListSyntax node_Syntax = node as BracketedParameterListSyntax;
            desc = "BracketedParameterListSyntax";
        }
        else if (nodeType == typeof(BranchingDirectiveTriviaSyntax))
        {
            BranchingDirectiveTriviaSyntax node_Syntax = node as BranchingDirectiveTriviaSyntax;
            desc = "BranchingDirectiveTriviaSyntax";
        }
        else if (nodeType == typeof(BreakStatementSyntax))
        {
            BreakStatementSyntax node_Syntax = node as BreakStatementSyntax;
            desc = "BreakStatementSyntax";
        }
        else if (nodeType == typeof(CasePatternSwitchLabelSyntax))
        {
            CasePatternSwitchLabelSyntax node_Syntax = node as CasePatternSwitchLabelSyntax;
            desc = "CasePatternSwitchLabelSyntax";
        }
        else if (nodeType == typeof(CaseSwitchLabelSyntax))
        {
            CaseSwitchLabelSyntax node_Syntax = node as CaseSwitchLabelSyntax;
            desc = "CaseSwitchLabelSyntax";
        }
        else if (nodeType == typeof(CastExpressionSyntax))
        {
            CastExpressionSyntax node_Syntax = node as CastExpressionSyntax;
            desc = "CastExpressionSyntax";
        }
        else if (nodeType == typeof(CatchClauseSyntax))
        {
            CatchClauseSyntax node_Syntax = node as CatchClauseSyntax;
            desc = "CatchClauseSyntax";
        }
        else if (nodeType == typeof(CatchDeclarationSyntax))
        {
            CatchDeclarationSyntax node_Syntax = node as CatchDeclarationSyntax;
            desc = node_Syntax.Identifier.Text;
        }
        else if (nodeType == typeof(CatchFilterClauseSyntax))
        {
            CatchFilterClauseSyntax node_Syntax = node as CatchFilterClauseSyntax;
            desc = "CatchFilterClauseSyntax";
        }
        else if (nodeType == typeof(CheckedExpressionSyntax))
        {
            CheckedExpressionSyntax node_Syntax = node as CheckedExpressionSyntax;
            desc = "CheckedExpressionSyntax";
        }
        else if (nodeType == typeof(CheckedStatementSyntax))
        {
            CheckedStatementSyntax node_Syntax = node as CheckedStatementSyntax;
            desc = "CheckedStatementSyntax";
        }
        else if (nodeType == typeof(ClassDeclarationSyntax))
        {
            ClassDeclarationSyntax node_Syntax = node as ClassDeclarationSyntax;
            desc = node_Syntax.Identifier.Text;
        }
        else if (nodeType == typeof(ClassOrStructConstraintSyntax))
        {
            ClassOrStructConstraintSyntax node_Syntax = node as ClassOrStructConstraintSyntax;
            desc = "ClassOrStructConstraintSyntax";
        }
        else if (nodeType == typeof(CollectionElementSyntax))
        {
            CollectionElementSyntax node_Syntax = node as CollectionElementSyntax;
            desc = "CollectionElementSyntax";
        }
        else if (nodeType == typeof(CollectionExpressionSyntax))
        {
            CollectionExpressionSyntax node_Syntax = node as CollectionExpressionSyntax;
            desc = "CollectionExpressionSyntax";
        }
        else if (nodeType == typeof(CommonForEachStatementSyntax))
        {
            CommonForEachStatementSyntax node_Syntax = node as CommonForEachStatementSyntax;
            desc = "CommonForEachStatementSyntax";
        }
        else if (nodeType == typeof(CompilationUnitSyntax))
        {
            CompilationUnitSyntax node_Syntax = node as CompilationUnitSyntax;
            desc = "CompilationUnitSyntax";
        }
        else if (nodeType == typeof(ConditionalAccessExpressionSyntax))
        {
            ConditionalAccessExpressionSyntax node_Syntax = node as ConditionalAccessExpressionSyntax;
            desc = "ConditionalAccessExpressionSyntax";
        }
        else if (nodeType == typeof(ConditionalDirectiveTriviaSyntax))
        {
            ConditionalDirectiveTriviaSyntax node_Syntax = node as ConditionalDirectiveTriviaSyntax;
            desc = "ConditionalDirectiveTriviaSyntax";
        }
        else if (nodeType == typeof(ConditionalExpressionSyntax))
        {
            ConditionalExpressionSyntax node_Syntax = node as ConditionalExpressionSyntax;
            desc = "ConditionalExpressionSyntax";
        }
        else if (nodeType == typeof(ConstantPatternSyntax))
        {
            ConstantPatternSyntax node_Syntax = node as ConstantPatternSyntax;
            desc = "ConstantPatternSyntax";
        }
        else if (nodeType == typeof(ConstructorConstraintSyntax))
        {
            ConstructorConstraintSyntax node_Syntax = node as ConstructorConstraintSyntax;
            desc = "ConstructorConstraintSyntax";
        }
        else if (nodeType == typeof(ConstructorDeclarationSyntax))
        {
            ConstructorDeclarationSyntax node_Syntax = node as ConstructorDeclarationSyntax;
            desc = node_Syntax.Identifier.Text;
        }
        else if (nodeType == typeof(ConstructorInitializerSyntax))
        {
            ConstructorInitializerSyntax node_Syntax = node as ConstructorInitializerSyntax;
            desc = "ConstructorInitializerSyntax";
        }
        else if (nodeType == typeof(ContinueStatementSyntax))
        {
            ContinueStatementSyntax node_Syntax = node as ContinueStatementSyntax;
            desc = "ContinueStatementSyntax";
        }
        else if (nodeType == typeof(ConversionOperatorDeclarationSyntax))
        {
            ConversionOperatorDeclarationSyntax node_Syntax = node as ConversionOperatorDeclarationSyntax;
            desc = "ConversionOperatorDeclarationSyntax";
        }
        else if (nodeType == typeof(ConversionOperatorMemberCrefSyntax))
        {
            ConversionOperatorMemberCrefSyntax node_Syntax = node as ConversionOperatorMemberCrefSyntax;
            desc = "ConversionOperatorMemberCrefSyntax";
        }
        else if (nodeType == typeof(CrefBracketedParameterListSyntax))
        {
            CrefBracketedParameterListSyntax node_Syntax = node as CrefBracketedParameterListSyntax;
            desc = "CrefBracketedParameterListSyntax";
        }
        else if (nodeType == typeof(CrefParameterListSyntax))
        {
            CrefParameterListSyntax node_Syntax = node as CrefParameterListSyntax;
            desc = "CrefParameterListSyntax";
        }
        else if (nodeType == typeof(CrefParameterSyntax))
        {
            CrefParameterSyntax node_Syntax = node as CrefParameterSyntax;
            desc = "CrefParameterSyntax";
        }
        else if (nodeType == typeof(CrefSyntax))
        {
            CrefSyntax node_Syntax = node as CrefSyntax;
            desc = "CrefSyntax";
        }
        else if (nodeType == typeof(DeclarationExpressionSyntax))
        {
            DeclarationExpressionSyntax node_Syntax = node as DeclarationExpressionSyntax;
            desc = "DeclarationExpressionSyntax";
        }
        else if (nodeType == typeof(DeclarationPatternSyntax))
        {
            DeclarationPatternSyntax node_Syntax = node as DeclarationPatternSyntax;
            desc = "DeclarationPatternSyntax";
        }
        else if (nodeType == typeof(DefaultConstraintSyntax))
        {
            DefaultConstraintSyntax node_Syntax = node as DefaultConstraintSyntax;
            desc = "DefaultConstraintSyntax";
        }
        else if (nodeType == typeof(DefaultExpressionSyntax))
        {
            DefaultExpressionSyntax node_Syntax = node as DefaultExpressionSyntax;
            desc = "DefaultExpressionSyntax";
        }
        else if (nodeType == typeof(DefaultSwitchLabelSyntax))
        {
            DefaultSwitchLabelSyntax node_Syntax = node as DefaultSwitchLabelSyntax;
            desc = "DefaultSwitchLabelSyntax";
        }
        else if (nodeType == typeof(DefineDirectiveTriviaSyntax))
        {
            DefineDirectiveTriviaSyntax node_Syntax = node as DefineDirectiveTriviaSyntax;
            desc = "DefineDirectiveTriviaSyntax";
        }
        else if (nodeType == typeof(DelegateDeclarationSyntax))
        {
            DelegateDeclarationSyntax node_Syntax = node as DelegateDeclarationSyntax;
            desc = node_Syntax.Identifier.Text;
        }
        else if (nodeType == typeof(DestructorDeclarationSyntax))
        {
            DestructorDeclarationSyntax node_Syntax = node as DestructorDeclarationSyntax;
            desc = node_Syntax.Identifier.Text;
        }
        else if (nodeType == typeof(DirectiveTriviaSyntax))
        {
            DirectiveTriviaSyntax node_Syntax = node as DirectiveTriviaSyntax;
            desc = "DirectiveTriviaSyntax";
        }
        else if (nodeType == typeof(DiscardDesignationSyntax))
        {
            DiscardDesignationSyntax node_Syntax = node as DiscardDesignationSyntax;
            desc = "DiscardDesignationSyntax";
        }
        else if (nodeType == typeof(DiscardPatternSyntax))
        {
            DiscardPatternSyntax node_Syntax = node as DiscardPatternSyntax;
            desc = "DiscardPatternSyntax";
        }
        else if (nodeType == typeof(DocumentationCommentTriviaSyntax))
        {
            DocumentationCommentTriviaSyntax node_Syntax = node as DocumentationCommentTriviaSyntax;
            desc = "DocumentationCommentTriviaSyntax";
        }
        else if (nodeType == typeof(DoStatementSyntax))
        {
            DoStatementSyntax node_Syntax = node as DoStatementSyntax;
            desc = "DoStatementSyntax";
        }
        else if (nodeType == typeof(ElementAccessExpressionSyntax))
        {
            ElementAccessExpressionSyntax node_Syntax = node as ElementAccessExpressionSyntax;
            desc = "ElementAccessExpressionSyntax";
        }
        else if (nodeType == typeof(ElementBindingExpressionSyntax))
        {
            ElementBindingExpressionSyntax node_Syntax = node as ElementBindingExpressionSyntax;
            desc = "ElementBindingExpressionSyntax";
        }
        else if (nodeType == typeof(ElifDirectiveTriviaSyntax))
        {
            ElifDirectiveTriviaSyntax node_Syntax = node as ElifDirectiveTriviaSyntax;
            desc = "ElifDirectiveTriviaSyntax";
        }
        else if (nodeType == typeof(ElseClauseSyntax))
        {
            ElseClauseSyntax node_Syntax = node as ElseClauseSyntax;
            desc = "ElseClauseSyntax";
        }
        else if (nodeType == typeof(ElseDirectiveTriviaSyntax))
        {
            ElseDirectiveTriviaSyntax node_Syntax = node as ElseDirectiveTriviaSyntax;
            desc = "ElseDirectiveTriviaSyntax";
        }
        else if (nodeType == typeof(EmptyStatementSyntax))
        {
            EmptyStatementSyntax node_Syntax = node as EmptyStatementSyntax;
            desc = "EmptyStatementSyntax";
        }
        else if (nodeType == typeof(EndIfDirectiveTriviaSyntax))
        {
            EndIfDirectiveTriviaSyntax node_Syntax = node as EndIfDirectiveTriviaSyntax;
            desc = "EndIfDirectiveTriviaSyntax";
        }
        else if (nodeType == typeof(EndRegionDirectiveTriviaSyntax))
        {
            EndRegionDirectiveTriviaSyntax node_Syntax = node as EndRegionDirectiveTriviaSyntax;
            desc = "EndRegionDirectiveTriviaSyntax";
        }
        else if (nodeType == typeof(EnumDeclarationSyntax))
        {
            EnumDeclarationSyntax node_Syntax = node as EnumDeclarationSyntax;
            desc = node_Syntax.Identifier.Text;
        }
        else if (nodeType == typeof(EnumMemberDeclarationSyntax))
        {
            EnumMemberDeclarationSyntax node_Syntax = node as EnumMemberDeclarationSyntax;
            desc = node_Syntax.Identifier.Text;
        }
        else if (nodeType == typeof(EqualsValueClauseSyntax))
        {
            EqualsValueClauseSyntax node_Syntax = node as EqualsValueClauseSyntax;
            desc = "EqualsValueClauseSyntax";
        }
        else if (nodeType == typeof(ErrorDirectiveTriviaSyntax))
        {
            ErrorDirectiveTriviaSyntax node_Syntax = node as ErrorDirectiveTriviaSyntax;
            desc = "ErrorDirectiveTriviaSyntax";
        }
        else if (nodeType == typeof(EventDeclarationSyntax))
        {
            EventDeclarationSyntax node_Syntax = node as EventDeclarationSyntax;
            desc = node_Syntax.Identifier.Text;
        }
        else if (nodeType == typeof(EventFieldDeclarationSyntax))
        {
            EventFieldDeclarationSyntax node_Syntax = node as EventFieldDeclarationSyntax;
            desc = "EventFieldDeclarationSyntax";
        }
        else if (nodeType == typeof(ExplicitInterfaceSpecifierSyntax))
        {
            ExplicitInterfaceSpecifierSyntax node_Syntax = node as ExplicitInterfaceSpecifierSyntax;
            desc = "ExplicitInterfaceSpecifierSyntax";
        }
        else if (nodeType == typeof(ExpressionColonSyntax))
        {
            ExpressionColonSyntax node_Syntax = node as ExpressionColonSyntax;
            desc = "ExpressionColonSyntax";
        }
        else if (nodeType == typeof(ExpressionElementSyntax))
        {
            ExpressionElementSyntax node_Syntax = node as ExpressionElementSyntax;
            desc = "ExpressionElementSyntax";
        }
        else if (nodeType == typeof(ExpressionOrPatternSyntax))
        {
            ExpressionOrPatternSyntax node_Syntax = node as ExpressionOrPatternSyntax;
            desc = "ExpressionOrPatternSyntax";
        }
        else if (nodeType == typeof(ExpressionStatementSyntax))
        {
            ExpressionStatementSyntax node_Syntax = node as ExpressionStatementSyntax;
            desc = "ExpressionStatementSyntax";
        }
        else if (nodeType == typeof(ExpressionSyntax))
        {
            ExpressionSyntax node_Syntax = node as ExpressionSyntax;
            desc = "ExpressionSyntax";
        }
        else if (nodeType == typeof(ExternAliasDirectiveSyntax))
        {
            ExternAliasDirectiveSyntax node_Syntax = node as ExternAliasDirectiveSyntax;
            desc = node_Syntax.Identifier.Text;
        }
        else if (nodeType == typeof(FieldDeclarationSyntax))
        {
            FieldDeclarationSyntax node_Syntax = node as FieldDeclarationSyntax;
            desc = "FieldDeclarationSyntax";
        }
        else if (nodeType == typeof(FieldExpressionSyntax))
        {
            FieldExpressionSyntax node_Syntax = node as FieldExpressionSyntax;
            desc = "FieldExpressionSyntax";
        }
        else if (nodeType == typeof(FileScopedNamespaceDeclarationSyntax))
        {
            FileScopedNamespaceDeclarationSyntax node_Syntax = node as FileScopedNamespaceDeclarationSyntax;
            desc = "FileScopedNamespaceDeclarationSyntax";
        }
        else if (nodeType == typeof(FinallyClauseSyntax))
        {
            FinallyClauseSyntax node_Syntax = node as FinallyClauseSyntax;
            desc = "FinallyClauseSyntax";
        }
        else if (nodeType == typeof(FixedStatementSyntax))
        {
            FixedStatementSyntax node_Syntax = node as FixedStatementSyntax;
            desc = "FixedStatementSyntax";
        }
        else if (nodeType == typeof(ForEachStatementSyntax))
        {
            ForEachStatementSyntax node_Syntax = node as ForEachStatementSyntax;
            desc = "ForEachStatementSyntax";
        }
        else if (nodeType == typeof(ForEachVariableStatementSyntax))
        {
            ForEachVariableStatementSyntax node_Syntax = node as ForEachVariableStatementSyntax;
            desc = "ForEachVariableStatementSyntax";
        }
        else if (nodeType == typeof(ForStatementSyntax))
        {
            ForStatementSyntax node_Syntax = node as ForStatementSyntax;
            desc = "ForStatementSyntax";
        }
        else if (nodeType == typeof(FromClauseSyntax))
        {
            FromClauseSyntax node_Syntax = node as FromClauseSyntax;
            desc = node_Syntax.Identifier.Text;
        }
        else if (nodeType == typeof(FunctionPointerCallingConventionSyntax))
        {
            FunctionPointerCallingConventionSyntax node_Syntax = node as FunctionPointerCallingConventionSyntax;
            desc = "FunctionPointerCallingConventionSyntax";
        }
        else if (nodeType == typeof(FunctionPointerParameterListSyntax))
        {
            FunctionPointerParameterListSyntax node_Syntax = node as FunctionPointerParameterListSyntax;
            desc = "FunctionPointerParameterListSyntax";
        }
        else if (nodeType == typeof(FunctionPointerParameterSyntax))
        {
            FunctionPointerParameterSyntax node_Syntax = node as FunctionPointerParameterSyntax;
            desc = "FunctionPointerParameterSyntax";
        }
        else if (nodeType == typeof(FunctionPointerTypeSyntax))
        {
            FunctionPointerTypeSyntax node_Syntax = node as FunctionPointerTypeSyntax;
            desc = "FunctionPointerTypeSyntax";
        }
        else if (nodeType == typeof(FunctionPointerUnmanagedCallingConventionListSyntax))
        {
            FunctionPointerUnmanagedCallingConventionListSyntax node_Syntax = node as FunctionPointerUnmanagedCallingConventionListSyntax;
            desc = "FunctionPointerUnmanagedCallingConventionListSyntax";
        }
        else if (nodeType == typeof(FunctionPointerUnmanagedCallingConventionSyntax))
        {
            FunctionPointerUnmanagedCallingConventionSyntax node_Syntax = node as FunctionPointerUnmanagedCallingConventionSyntax;
            desc = "FunctionPointerUnmanagedCallingConventionSyntax";
        }
        else if (nodeType == typeof(GenericNameSyntax))
        {
            GenericNameSyntax node_Syntax = node as GenericNameSyntax;
            desc = node_Syntax.Identifier.Text;
        }
        else if (nodeType == typeof(GlobalStatementSyntax))
        {
            GlobalStatementSyntax node_Syntax = node as GlobalStatementSyntax;
            desc = "GlobalStatementSyntax";
        }
        else if (nodeType == typeof(GotoStatementSyntax))
        {
            GotoStatementSyntax node_Syntax = node as GotoStatementSyntax;
            desc = "GotoStatementSyntax";
        }
        else if (nodeType == typeof(GroupClauseSyntax))
        {
            GroupClauseSyntax node_Syntax = node as GroupClauseSyntax;
            desc = "GroupClauseSyntax";
        }
        else if (nodeType == typeof(IdentifierNameSyntax))
        {
            IdentifierNameSyntax node_Syntax = node as IdentifierNameSyntax;
            desc = "IdentifierNameSyntax";
        }
        else if (nodeType == typeof(IfDirectiveTriviaSyntax))
        {
            IfDirectiveTriviaSyntax node_Syntax = node as IfDirectiveTriviaSyntax;
            desc = "IfDirectiveTriviaSyntax";
        }
        else if (nodeType == typeof(IfStatementSyntax))
        {
            IfStatementSyntax node_Syntax = node as IfStatementSyntax;
            desc = "IfStatementSyntax";
        }
        else if (nodeType == typeof(ImplicitArrayCreationExpressionSyntax))
        {
            ImplicitArrayCreationExpressionSyntax node_Syntax = node as ImplicitArrayCreationExpressionSyntax;
            desc = "ImplicitArrayCreationExpressionSyntax";
        }
        else if (nodeType == typeof(ImplicitElementAccessSyntax))
        {
            ImplicitElementAccessSyntax node_Syntax = node as ImplicitElementAccessSyntax;
            desc = "ImplicitElementAccessSyntax";
        }
        else if (nodeType == typeof(ImplicitObjectCreationExpressionSyntax))
        {
            ImplicitObjectCreationExpressionSyntax node_Syntax = node as ImplicitObjectCreationExpressionSyntax;
            desc = "ImplicitObjectCreationExpressionSyntax";
        }
        else if (nodeType == typeof(ImplicitStackAllocArrayCreationExpressionSyntax))
        {
            ImplicitStackAllocArrayCreationExpressionSyntax node_Syntax = node as ImplicitStackAllocArrayCreationExpressionSyntax;
            desc = "ImplicitStackAllocArrayCreationExpressionSyntax";
        }
        else if (nodeType == typeof(IncompleteMemberSyntax))
        {
            IncompleteMemberSyntax node_Syntax = node as IncompleteMemberSyntax;
            desc = "IncompleteMemberSyntax";
        }
        else if (nodeType == typeof(IndexerDeclarationSyntax))
        {
            IndexerDeclarationSyntax node_Syntax = node as IndexerDeclarationSyntax;
            desc = "IndexerDeclarationSyntax";
        }
        else if (nodeType == typeof(IndexerMemberCrefSyntax))
        {
            IndexerMemberCrefSyntax node_Syntax = node as IndexerMemberCrefSyntax;
            desc = "IndexerMemberCrefSyntax";
        }
        else if (nodeType == typeof(InitializerExpressionSyntax))
        {
            InitializerExpressionSyntax node_Syntax = node as InitializerExpressionSyntax;
            desc = "InitializerExpressionSyntax";
        }
        else if (nodeType == typeof(InstanceExpressionSyntax))
        {
            InstanceExpressionSyntax node_Syntax = node as InstanceExpressionSyntax;
            desc = "InstanceExpressionSyntax";
        }
        else if (nodeType == typeof(InterfaceDeclarationSyntax))
        {
            InterfaceDeclarationSyntax node_Syntax = node as InterfaceDeclarationSyntax;
            desc = node_Syntax.Identifier.Text;
        }
        else if (nodeType == typeof(InterpolatedStringContentSyntax))
        {
            InterpolatedStringContentSyntax node_Syntax = node as InterpolatedStringContentSyntax;
            desc = "InterpolatedStringContentSyntax";
        }
        else if (nodeType == typeof(InterpolatedStringExpressionSyntax))
        {
            InterpolatedStringExpressionSyntax node_Syntax = node as InterpolatedStringExpressionSyntax;
            desc = "InterpolatedStringExpressionSyntax";
        }
        else if (nodeType == typeof(InterpolatedStringTextSyntax))
        {
            InterpolatedStringTextSyntax node_Syntax = node as InterpolatedStringTextSyntax;
            desc = "InterpolatedStringTextSyntax";
        }
        else if (nodeType == typeof(InterpolationAlignmentClauseSyntax))
        {
            InterpolationAlignmentClauseSyntax node_Syntax = node as InterpolationAlignmentClauseSyntax;
            desc = "InterpolationAlignmentClauseSyntax";
        }
        else if (nodeType == typeof(InterpolationFormatClauseSyntax))
        {
            InterpolationFormatClauseSyntax node_Syntax = node as InterpolationFormatClauseSyntax;
            desc = "InterpolationFormatClauseSyntax";
        }
        else if (nodeType == typeof(InterpolationSyntax))
        {
            InterpolationSyntax node_Syntax = node as InterpolationSyntax;
            desc = "InterpolationSyntax";
        }
        else if (nodeType == typeof(InvocationExpressionSyntax))
        {
            InvocationExpressionSyntax node_Syntax = node as InvocationExpressionSyntax;
            desc = "InvocationExpressionSyntax";
        }
        else if (nodeType == typeof(IsPatternExpressionSyntax))
        {
            IsPatternExpressionSyntax node_Syntax = node as IsPatternExpressionSyntax;
            desc = "IsPatternExpressionSyntax";
        }
        else if (nodeType == typeof(JoinClauseSyntax))
        {
            JoinClauseSyntax node_Syntax = node as JoinClauseSyntax;
            desc = node_Syntax.Identifier.Text;
        }
        else if (nodeType == typeof(JoinIntoClauseSyntax))
        {
            JoinIntoClauseSyntax node_Syntax = node as JoinIntoClauseSyntax;
            desc = node_Syntax.Identifier.Text;
        }
        else if (nodeType == typeof(LabeledStatementSyntax))
        {
            LabeledStatementSyntax node_Syntax = node as LabeledStatementSyntax;
            desc = node_Syntax.Identifier.Text;
        }
        else if (nodeType == typeof(LambdaExpressionSyntax))
        {
            LambdaExpressionSyntax node_Syntax = node as LambdaExpressionSyntax;
            desc = "LambdaExpressionSyntax";
        }
        else if (nodeType == typeof(LetClauseSyntax))
        {
            LetClauseSyntax node_Syntax = node as LetClauseSyntax;
            desc = node_Syntax.Identifier.Text;
        }
        else if (nodeType == typeof(LineDirectivePositionSyntax))
        {
            LineDirectivePositionSyntax node_Syntax = node as LineDirectivePositionSyntax;
            desc = "LineDirectivePositionSyntax";
        }
        else if (nodeType == typeof(LineDirectiveTriviaSyntax))
        {
            LineDirectiveTriviaSyntax node_Syntax = node as LineDirectiveTriviaSyntax;
            desc = "LineDirectiveTriviaSyntax";
        }
        else if (nodeType == typeof(LineOrSpanDirectiveTriviaSyntax))
        {
            LineOrSpanDirectiveTriviaSyntax node_Syntax = node as LineOrSpanDirectiveTriviaSyntax;
            desc = "LineOrSpanDirectiveTriviaSyntax";
        }
        else if (nodeType == typeof(LineSpanDirectiveTriviaSyntax))
        {
            LineSpanDirectiveTriviaSyntax node_Syntax = node as LineSpanDirectiveTriviaSyntax;
            desc = "LineSpanDirectiveTriviaSyntax";
        }
        else if (nodeType == typeof(ListPatternSyntax))
        {
            ListPatternSyntax node_Syntax = node as ListPatternSyntax;
            desc = "ListPatternSyntax";
        }
        else if (nodeType == typeof(LiteralExpressionSyntax))
        {
            LiteralExpressionSyntax node_Syntax = node as LiteralExpressionSyntax;
            desc = "LiteralExpressionSyntax";
        }
        else if (nodeType == typeof(LoadDirectiveTriviaSyntax))
        {
            LoadDirectiveTriviaSyntax node_Syntax = node as LoadDirectiveTriviaSyntax;
            desc = "LoadDirectiveTriviaSyntax";
        }
        else if (nodeType == typeof(LocalDeclarationStatementSyntax))
        {
            LocalDeclarationStatementSyntax node_Syntax = node as LocalDeclarationStatementSyntax;
            desc = "LocalDeclarationStatementSyntax";
        }
        else if (nodeType == typeof(LocalFunctionStatementSyntax))
        {
            LocalFunctionStatementSyntax node_Syntax = node as LocalFunctionStatementSyntax;
            desc = node_Syntax.Identifier.Text;
        }
        else if (nodeType == typeof(LockStatementSyntax))
        {
            LockStatementSyntax node_Syntax = node as LockStatementSyntax;
            desc = "LockStatementSyntax";
        }
        else if (nodeType == typeof(MakeRefExpressionSyntax))
        {
            MakeRefExpressionSyntax node_Syntax = node as MakeRefExpressionSyntax;
            desc = "MakeRefExpressionSyntax";
        }
        else if (nodeType == typeof(MemberAccessExpressionSyntax))
        {
            MemberAccessExpressionSyntax node_Syntax = node as MemberAccessExpressionSyntax;
            desc = "MemberAccessExpressionSyntax";
        }
        else if (nodeType == typeof(MemberBindingExpressionSyntax))
        {
            MemberBindingExpressionSyntax node_Syntax = node as MemberBindingExpressionSyntax;
            desc = "MemberBindingExpressionSyntax";
        }
        else if (nodeType == typeof(MemberCrefSyntax))
        {
            MemberCrefSyntax node_Syntax = node as MemberCrefSyntax;
            desc = "MemberCrefSyntax";
        }
        else if (nodeType == typeof(MemberDeclarationSyntax))
        {
            MemberDeclarationSyntax node_Syntax = node as MemberDeclarationSyntax;
            desc = "MemberDeclarationSyntax";
        }
        else if (nodeType == typeof(MethodDeclarationSyntax))
        {
            MethodDeclarationSyntax node_Syntax = node as MethodDeclarationSyntax;
            desc = "MethodDeclarationSyntax";
        }
        else if (nodeType == typeof(NameColonSyntax))
        {
            NameColonSyntax node_Syntax = node as NameColonSyntax;
            desc = "NameColonSyntax";
        }
        else if (nodeType == typeof(NameEqualsSyntax))
        {
            NameEqualsSyntax node_Syntax = node as NameEqualsSyntax;
            desc = "NameEqualsSyntax";
        }
        else if (nodeType == typeof(NameMemberCrefSyntax))
        {
            NameMemberCrefSyntax node_Syntax = node as NameMemberCrefSyntax;
            desc = "NameMemberCrefSyntax";
        }
        else if (nodeType == typeof(NamespaceDeclarationSyntax))
        {
            NamespaceDeclarationSyntax node_Syntax = node as NamespaceDeclarationSyntax;
            desc = "NamespaceDeclarationSyntax";
        }
        else if (nodeType == typeof(NameSyntax))
        {
            NameSyntax node_Syntax = node as NameSyntax;
            desc = "NameSyntax";
        }
        else if (nodeType == typeof(NullableDirectiveTriviaSyntax))
        {
            NullableDirectiveTriviaSyntax node_Syntax = node as NullableDirectiveTriviaSyntax;
            desc = "NullableDirectiveTriviaSyntax";
        }
        else if (nodeType == typeof(NullableTypeSyntax))
        {
            NullableTypeSyntax node_Syntax = node as NullableTypeSyntax;
            desc = "NullableTypeSyntax";
        }
        else if (nodeType == typeof(ObjectCreationExpressionSyntax))
        {
            ObjectCreationExpressionSyntax node_Syntax = node as ObjectCreationExpressionSyntax;
            desc = "ObjectCreationExpressionSyntax";
        }
        else if (nodeType == typeof(OmittedArraySizeExpressionSyntax))
        {
            OmittedArraySizeExpressionSyntax node_Syntax = node as OmittedArraySizeExpressionSyntax;
            desc = "OmittedArraySizeExpressionSyntax";
        }
        else if (nodeType == typeof(OmittedTypeArgumentSyntax))
        {
            OmittedTypeArgumentSyntax node_Syntax = node as OmittedTypeArgumentSyntax;
            desc = "OmittedTypeArgumentSyntax";
        }
        else if (nodeType == typeof(OperatorDeclarationSyntax))
        {
            OperatorDeclarationSyntax node_Syntax = node as OperatorDeclarationSyntax;
            desc = "OperatorDeclarationSyntax";
        }
        else if (nodeType == typeof(OperatorMemberCrefSyntax))
        {
            OperatorMemberCrefSyntax node_Syntax = node as OperatorMemberCrefSyntax;
            desc = "OperatorMemberCrefSyntax";
        }
        else if (nodeType == typeof(OrderByClauseSyntax))
        {
            OrderByClauseSyntax node_Syntax = node as OrderByClauseSyntax;
            desc = "OrderByClauseSyntax";
        }
        else if (nodeType == typeof(OrderingSyntax))
        {
            OrderingSyntax node_Syntax = node as OrderingSyntax;
            desc = "OrderingSyntax";
        }
        else if (nodeType == typeof(ParameterListSyntax))
        {
            ParameterListSyntax node_Syntax = node as ParameterListSyntax;
            desc = "ParameterListSyntax";
        }
        else if (nodeType == typeof(ParameterSyntax))
        {
            ParameterSyntax node_Syntax = node as ParameterSyntax;
            desc = "ParameterSyntax";
        }
        else if (nodeType == typeof(ParenthesizedExpressionSyntax))
        {
            ParenthesizedExpressionSyntax node_Syntax = node as ParenthesizedExpressionSyntax;
            desc = "ParenthesizedExpressionSyntax";
        }
        else if (nodeType == typeof(ParenthesizedLambdaExpressionSyntax))
        {
            ParenthesizedLambdaExpressionSyntax node_Syntax = node as ParenthesizedLambdaExpressionSyntax;
            desc = "ParenthesizedLambdaExpressionSyntax";
        }
        else if (nodeType == typeof(ParenthesizedPatternSyntax))
        {
            ParenthesizedPatternSyntax node_Syntax = node as ParenthesizedPatternSyntax;
            desc = "ParenthesizedPatternSyntax";
        }
        else if (nodeType == typeof(ParenthesizedVariableDesignationSyntax))
        {
            ParenthesizedVariableDesignationSyntax node_Syntax = node as ParenthesizedVariableDesignationSyntax;
            desc = "ParenthesizedVariableDesignationSyntax";
        }
        else if (nodeType == typeof(PatternSyntax))
        {
            PatternSyntax node_Syntax = node as PatternSyntax;
            desc = "PatternSyntax";
        }
        else if (nodeType == typeof(PointerTypeSyntax))
        {
            PointerTypeSyntax node_Syntax = node as PointerTypeSyntax;
            desc = "PointerTypeSyntax";
        }
        else if (nodeType == typeof(PositionalPatternClauseSyntax))
        {
            PositionalPatternClauseSyntax node_Syntax = node as PositionalPatternClauseSyntax;
            desc = "PositionalPatternClauseSyntax";
        }
        else if (nodeType == typeof(PostfixUnaryExpressionSyntax))
        {
            PostfixUnaryExpressionSyntax node_Syntax = node as PostfixUnaryExpressionSyntax;
            desc = "PostfixUnaryExpressionSyntax";
        }
        else if (nodeType == typeof(PragmaChecksumDirectiveTriviaSyntax))
        {
            PragmaChecksumDirectiveTriviaSyntax node_Syntax = node as PragmaChecksumDirectiveTriviaSyntax;
            desc = "PragmaChecksumDirectiveTriviaSyntax";
        }
        else if (nodeType == typeof(PragmaWarningDirectiveTriviaSyntax))
        {
            PragmaWarningDirectiveTriviaSyntax node_Syntax = node as PragmaWarningDirectiveTriviaSyntax;
            desc = "PragmaWarningDirectiveTriviaSyntax";
        }
        else if (nodeType == typeof(PredefinedTypeSyntax))
        {
            PredefinedTypeSyntax node_Syntax = node as PredefinedTypeSyntax;
            desc = "PredefinedTypeSyntax";
        }
        else if (nodeType == typeof(PrefixUnaryExpressionSyntax))
        {
            PrefixUnaryExpressionSyntax node_Syntax = node as PrefixUnaryExpressionSyntax;
            desc = "PrefixUnaryExpressionSyntax";
        }
        else if (nodeType == typeof(PrimaryConstructorBaseTypeSyntax))
        {
            PrimaryConstructorBaseTypeSyntax node_Syntax = node as PrimaryConstructorBaseTypeSyntax;
            desc = "PrimaryConstructorBaseTypeSyntax";
        }
        else if (nodeType == typeof(PropertyDeclarationSyntax))
        {
            PropertyDeclarationSyntax node_Syntax = node as PropertyDeclarationSyntax;
            desc = "PropertyDeclarationSyntax";
        }
        else if (nodeType == typeof(PropertyPatternClauseSyntax))
        {
            PropertyPatternClauseSyntax node_Syntax = node as PropertyPatternClauseSyntax;
            desc = "PropertyPatternClauseSyntax";
        }
        else if (nodeType == typeof(QualifiedCrefSyntax))
        {
            QualifiedCrefSyntax node_Syntax = node as QualifiedCrefSyntax;
            desc = "QualifiedCrefSyntax";
        }
        else if (nodeType == typeof(QualifiedNameSyntax))
        {
            QualifiedNameSyntax node_Syntax = node as QualifiedNameSyntax;
            desc = "QualifiedNameSyntax";
        }
        else if (nodeType == typeof(QueryBodySyntax))
        {
            QueryBodySyntax node_Syntax = node as QueryBodySyntax;
            desc = "QueryBodySyntax";
        }
        else if (nodeType == typeof(QueryClauseSyntax))
        {
            QueryClauseSyntax node_Syntax = node as QueryClauseSyntax;
            desc = "QueryClauseSyntax";
        }
        else if (nodeType == typeof(QueryContinuationSyntax))
        {
            QueryContinuationSyntax node_Syntax = node as QueryContinuationSyntax;
            desc = node_Syntax.Identifier.Text;
        }
        else if (nodeType == typeof(QueryExpressionSyntax))
        {
            QueryExpressionSyntax node_Syntax = node as QueryExpressionSyntax;
            desc = "QueryExpressionSyntax";
        }
        else if (nodeType == typeof(RangeExpressionSyntax))
        {
            RangeExpressionSyntax node_Syntax = node as RangeExpressionSyntax;
            desc = "RangeExpressionSyntax";
        }
        else if (nodeType == typeof(RecordDeclarationSyntax))
        {
            RecordDeclarationSyntax node_Syntax = node as RecordDeclarationSyntax;
            desc = node_Syntax.Identifier.Text;
        }
        else if (nodeType == typeof(RecursivePatternSyntax))
        {
            RecursivePatternSyntax node_Syntax = node as RecursivePatternSyntax;
            desc = "RecursivePatternSyntax";
        }
        else if (nodeType == typeof(ReferenceDirectiveTriviaSyntax))
        {
            ReferenceDirectiveTriviaSyntax node_Syntax = node as ReferenceDirectiveTriviaSyntax;
            desc = "ReferenceDirectiveTriviaSyntax";
        }
        else if (nodeType == typeof(RefExpressionSyntax))
        {
            RefExpressionSyntax node_Syntax = node as RefExpressionSyntax;
            desc = "RefExpressionSyntax";
        }
        else if (nodeType == typeof(RefStructConstraintSyntax))
        {
            RefStructConstraintSyntax node_Syntax = node as RefStructConstraintSyntax;
            desc = "RefStructConstraintSyntax";
        }
        else if (nodeType == typeof(RefTypeExpressionSyntax))
        {
            RefTypeExpressionSyntax node_Syntax = node as RefTypeExpressionSyntax;
            desc = "RefTypeExpressionSyntax";
        }
        else if (nodeType == typeof(RefTypeSyntax))
        {
            RefTypeSyntax node_Syntax = node as RefTypeSyntax;
            desc = "RefTypeSyntax";
        }
        else if (nodeType == typeof(RefValueExpressionSyntax))
        {
            RefValueExpressionSyntax node_Syntax = node as RefValueExpressionSyntax;
            desc = "RefValueExpressionSyntax";
        }
        else if (nodeType == typeof(RegionDirectiveTriviaSyntax))
        {
            RegionDirectiveTriviaSyntax node_Syntax = node as RegionDirectiveTriviaSyntax;
            desc = "RegionDirectiveTriviaSyntax";
        }
        else if (nodeType == typeof(RelationalPatternSyntax))
        {
            RelationalPatternSyntax node_Syntax = node as RelationalPatternSyntax;
            desc = "RelationalPatternSyntax";
        }
        else if (nodeType == typeof(ReturnStatementSyntax))
        {
            ReturnStatementSyntax node_Syntax = node as ReturnStatementSyntax;
            desc = "ReturnStatementSyntax";
        }
        else if (nodeType == typeof(ScopedTypeSyntax))
        {
            ScopedTypeSyntax node_Syntax = node as ScopedTypeSyntax;
            desc = "ScopedTypeSyntax";
        }
        else if (nodeType == typeof(SelectClauseSyntax))
        {
            SelectClauseSyntax node_Syntax = node as SelectClauseSyntax;
            desc = "SelectClauseSyntax";
        }
        else if (nodeType == typeof(SelectOrGroupClauseSyntax))
        {
            SelectOrGroupClauseSyntax node_Syntax = node as SelectOrGroupClauseSyntax;
            desc = "SelectOrGroupClauseSyntax";
        }
        else if (nodeType == typeof(ShebangDirectiveTriviaSyntax))
        {
            ShebangDirectiveTriviaSyntax node_Syntax = node as ShebangDirectiveTriviaSyntax;
            desc = "ShebangDirectiveTriviaSyntax";
        }
        else if (nodeType == typeof(SimpleBaseTypeSyntax))
        {
            SimpleBaseTypeSyntax node_Syntax = node as SimpleBaseTypeSyntax;
            desc = "SimpleBaseTypeSyntax";
        }
        else if (nodeType == typeof(SimpleLambdaExpressionSyntax))
        {
            SimpleLambdaExpressionSyntax node_Syntax = node as SimpleLambdaExpressionSyntax;
            desc = "SimpleLambdaExpressionSyntax";
        }
        else if (nodeType == typeof(SimpleNameSyntax))
        {
            SimpleNameSyntax node_Syntax = node as SimpleNameSyntax;
            desc = node_Syntax.Identifier.Text;
        }
        else if (nodeType == typeof(SingleVariableDesignationSyntax))
        {
            SingleVariableDesignationSyntax node_Syntax = node as SingleVariableDesignationSyntax;
            desc = node_Syntax.Identifier.Text;
        }
        else if (nodeType == typeof(SizeOfExpressionSyntax))
        {
            SizeOfExpressionSyntax node_Syntax = node as SizeOfExpressionSyntax;
            desc = "SizeOfExpressionSyntax";
        }
        else if (nodeType == typeof(SkippedTokensTriviaSyntax))
        {
            SkippedTokensTriviaSyntax node_Syntax = node as SkippedTokensTriviaSyntax;
            desc = "SkippedTokensTriviaSyntax";
        }
        else if (nodeType == typeof(SlicePatternSyntax))
        {
            SlicePatternSyntax node_Syntax = node as SlicePatternSyntax;
            desc = "SlicePatternSyntax";
        }
        else if (nodeType == typeof(SpreadElementSyntax))
        {
            SpreadElementSyntax node_Syntax = node as SpreadElementSyntax;
            desc = "SpreadElementSyntax";
        }
        else if (nodeType == typeof(StackAllocArrayCreationExpressionSyntax))
        {
            StackAllocArrayCreationExpressionSyntax node_Syntax = node as StackAllocArrayCreationExpressionSyntax;
            desc = "StackAllocArrayCreationExpressionSyntax";
        }
        else if (nodeType == typeof(StatementSyntax))
        {
            StatementSyntax node_Syntax = node as StatementSyntax;
            desc = "StatementSyntax";
        }
        else if (nodeType == typeof(StructDeclarationSyntax))
        {
            StructDeclarationSyntax node_Syntax = node as StructDeclarationSyntax;
            desc = node_Syntax.Identifier.Text;
        }
        else if (nodeType == typeof(StructuredTriviaSyntax))
        {
            StructuredTriviaSyntax node_Syntax = node as StructuredTriviaSyntax;
            desc = "StructuredTriviaSyntax";
        }
        else if (nodeType == typeof(SubpatternSyntax))
        {
            SubpatternSyntax node_Syntax = node as SubpatternSyntax;
            desc = "SubpatternSyntax";
        }
        else if (nodeType == typeof(SwitchExpressionArmSyntax))
        {
            SwitchExpressionArmSyntax node_Syntax = node as SwitchExpressionArmSyntax;
            desc = "SwitchExpressionArmSyntax";
        }
        else if (nodeType == typeof(SwitchExpressionSyntax))
        {
            SwitchExpressionSyntax node_Syntax = node as SwitchExpressionSyntax;
            desc = "SwitchExpressionSyntax";
        }
        else if (nodeType == typeof(SwitchLabelSyntax))
        {
            SwitchLabelSyntax node_Syntax = node as SwitchLabelSyntax;
            desc = "SwitchLabelSyntax";
        }
        else if (nodeType == typeof(SwitchSectionSyntax))
        {
            SwitchSectionSyntax node_Syntax = node as SwitchSectionSyntax;
            desc = "SwitchSectionSyntax";
        }
        else if (nodeType == typeof(SwitchStatementSyntax))
        {
            SwitchStatementSyntax node_Syntax = node as SwitchStatementSyntax;
            desc = "SwitchStatementSyntax";
        }
        else if (nodeType == typeof(ThisExpressionSyntax))
        {
            ThisExpressionSyntax node_Syntax = node as ThisExpressionSyntax;
            desc = "ThisExpressionSyntax";
        }
        else if (nodeType == typeof(ThrowExpressionSyntax))
        {
            ThrowExpressionSyntax node_Syntax = node as ThrowExpressionSyntax;
            desc = "ThrowExpressionSyntax";
        }
        else if (nodeType == typeof(ThrowStatementSyntax))
        {
            ThrowStatementSyntax node_Syntax = node as ThrowStatementSyntax;
            desc = "ThrowStatementSyntax";
        }
        else if (nodeType == typeof(TryStatementSyntax))
        {
            TryStatementSyntax node_Syntax = node as TryStatementSyntax;
            desc = "TryStatementSyntax";
        }
        else if (nodeType == typeof(TupleElementSyntax))
        {
            TupleElementSyntax node_Syntax = node as TupleElementSyntax;
            desc = node_Syntax.Identifier.Text;
        }
        else if (nodeType == typeof(TupleExpressionSyntax))
        {
            TupleExpressionSyntax node_Syntax = node as TupleExpressionSyntax;
            desc = "TupleExpressionSyntax";
        }
        else if (nodeType == typeof(TupleTypeSyntax))
        {
            TupleTypeSyntax node_Syntax = node as TupleTypeSyntax;
            desc = "TupleTypeSyntax";
        }
        else if (nodeType == typeof(TypeArgumentListSyntax))
        {
            TypeArgumentListSyntax node_Syntax = node as TypeArgumentListSyntax;
            desc = "TypeArgumentListSyntax";
        }
        else if (nodeType == typeof(TypeConstraintSyntax))
        {
            TypeConstraintSyntax node_Syntax = node as TypeConstraintSyntax;
            desc = "TypeConstraintSyntax";
        }
        else if (nodeType == typeof(TypeCrefSyntax))
        {
            TypeCrefSyntax node_Syntax = node as TypeCrefSyntax;
            desc = "TypeCrefSyntax";
        }
        else if (nodeType == typeof(TypeDeclarationSyntax))
        {
            TypeDeclarationSyntax node_Syntax = node as TypeDeclarationSyntax;
            desc = node_Syntax.Identifier.Text;
        }
        else if (nodeType == typeof(TypeOfExpressionSyntax))
        {
            TypeOfExpressionSyntax node_Syntax = node as TypeOfExpressionSyntax;
            desc = "TypeOfExpressionSyntax";
        }
        else if (nodeType == typeof(TypeParameterConstraintClauseSyntax))
        {
            TypeParameterConstraintClauseSyntax node_Syntax = node as TypeParameterConstraintClauseSyntax;
            desc = "TypeParameterConstraintClauseSyntax";
        }
        else if (nodeType == typeof(TypeParameterConstraintSyntax))
        {
            TypeParameterConstraintSyntax node_Syntax = node as TypeParameterConstraintSyntax;
            desc = "TypeParameterConstraintSyntax";
        }
        else if (nodeType == typeof(TypeParameterListSyntax))
        {
            TypeParameterListSyntax node_Syntax = node as TypeParameterListSyntax;
            desc = "TypeParameterListSyntax";
        }
        else if (nodeType == typeof(TypeParameterSyntax))
        {
            TypeParameterSyntax node_Syntax = node as TypeParameterSyntax;
            desc = node_Syntax.Identifier.Text;
        }
        else if (nodeType == typeof(TypePatternSyntax))
        {
            TypePatternSyntax node_Syntax = node as TypePatternSyntax;
            desc = "TypePatternSyntax";
        }
        else if (nodeType == typeof(TypeSyntax))
        {
            TypeSyntax node_Syntax = node as TypeSyntax;
            desc = "TypeSyntax";
        }
        else if (nodeType == typeof(UnaryPatternSyntax))
        {
            UnaryPatternSyntax node_Syntax = node as UnaryPatternSyntax;
            desc = "UnaryPatternSyntax";
        }
        else if (nodeType == typeof(UndefDirectiveTriviaSyntax))
        {
            UndefDirectiveTriviaSyntax node_Syntax = node as UndefDirectiveTriviaSyntax;
            desc = "UndefDirectiveTriviaSyntax";
        }
        else if (nodeType == typeof(UnsafeStatementSyntax))
        {
            UnsafeStatementSyntax node_Syntax = node as UnsafeStatementSyntax;
            desc = "UnsafeStatementSyntax";
        }
        else if (nodeType == typeof(UsingDirectiveSyntax))
        {
            UsingDirectiveSyntax node_Syntax = node as UsingDirectiveSyntax;
            desc = "UsingDirectiveSyntax";
        }
        else if (nodeType == typeof(UsingStatementSyntax))
        {
            UsingStatementSyntax node_Syntax = node as UsingStatementSyntax;
            desc = "UsingStatementSyntax";
        }
        else if (nodeType == typeof(VariableDeclarationSyntax))
        {
            VariableDeclarationSyntax node_Syntax = node as VariableDeclarationSyntax;
            desc = "VariableDeclarationSyntax";
        }
        else if (nodeType == typeof(VariableDeclaratorSyntax))
        {
            VariableDeclaratorSyntax node_Syntax = node as VariableDeclaratorSyntax;
            desc = node_Syntax.Identifier.Text;
        }
        else if (nodeType == typeof(VariableDesignationSyntax))
        {
            VariableDesignationSyntax node_Syntax = node as VariableDesignationSyntax;
            desc = "VariableDesignationSyntax";
        }
        else if (nodeType == typeof(VarPatternSyntax))
        {
            VarPatternSyntax node_Syntax = node as VarPatternSyntax;
            desc = "VarPatternSyntax";
        }
        else if (nodeType == typeof(WarningDirectiveTriviaSyntax))
        {
            WarningDirectiveTriviaSyntax node_Syntax = node as WarningDirectiveTriviaSyntax;
            desc = "WarningDirectiveTriviaSyntax";
        }
        else if (nodeType == typeof(WhenClauseSyntax))
        {
            WhenClauseSyntax node_Syntax = node as WhenClauseSyntax;
            desc = "WhenClauseSyntax";
        }
        else if (nodeType == typeof(WhereClauseSyntax))
        {
            WhereClauseSyntax node_Syntax = node as WhereClauseSyntax;
            desc = "WhereClauseSyntax";
        }
        else if (nodeType == typeof(WhileStatementSyntax))
        {
            WhileStatementSyntax node_Syntax = node as WhileStatementSyntax;
            desc = "WhileStatementSyntax";
        }
        else if (nodeType == typeof(WithExpressionSyntax))
        {
            WithExpressionSyntax node_Syntax = node as WithExpressionSyntax;
            desc = "WithExpressionSyntax";
        }
        else if (nodeType == typeof(XmlAttributeSyntax))
        {
            XmlAttributeSyntax node_Syntax = node as XmlAttributeSyntax;
            desc = "XmlAttributeSyntax";
        }
        else if (nodeType == typeof(XmlCDataSectionSyntax))
        {
            XmlCDataSectionSyntax node_Syntax = node as XmlCDataSectionSyntax;
            desc = "XmlCDataSectionSyntax";
        }
        else if (nodeType == typeof(XmlCommentSyntax))
        {
            XmlCommentSyntax node_Syntax = node as XmlCommentSyntax;
            desc = "XmlCommentSyntax";
        }
        else if (nodeType == typeof(XmlCrefAttributeSyntax))
        {
            XmlCrefAttributeSyntax node_Syntax = node as XmlCrefAttributeSyntax;
            desc = "XmlCrefAttributeSyntax";
        }
        else if (nodeType == typeof(XmlElementEndTagSyntax))
        {
            XmlElementEndTagSyntax node_Syntax = node as XmlElementEndTagSyntax;
            desc = "XmlElementEndTagSyntax";
        }
        else if (nodeType == typeof(XmlElementStartTagSyntax))
        {
            XmlElementStartTagSyntax node_Syntax = node as XmlElementStartTagSyntax;
            desc = "XmlElementStartTagSyntax";
        }
        else if (nodeType == typeof(XmlElementSyntax))
        {
            XmlElementSyntax node_Syntax = node as XmlElementSyntax;
            desc = "XmlElementSyntax";
        }
        else if (nodeType == typeof(XmlEmptyElementSyntax))
        {
            XmlEmptyElementSyntax node_Syntax = node as XmlEmptyElementSyntax;
            desc = "XmlEmptyElementSyntax";
        }
        else if (nodeType == typeof(XmlNameAttributeSyntax))
        {
            XmlNameAttributeSyntax node_Syntax = node as XmlNameAttributeSyntax;
            desc = node_Syntax.Identifier.ToString();
        }
        else if (nodeType == typeof(XmlNameSyntax))
        {
            XmlNameSyntax node_Syntax = node as XmlNameSyntax;
            desc = "XmlNameSyntax";
        }
        else if (nodeType == typeof(XmlNodeSyntax))
        {
            XmlNodeSyntax node_Syntax = node as XmlNodeSyntax;
            desc = "XmlNodeSyntax";
        }
        else if (nodeType == typeof(XmlPrefixSyntax))
        {
            XmlPrefixSyntax node_Syntax = node as XmlPrefixSyntax;
            desc = "XmlPrefixSyntax";
        }
        else if (nodeType == typeof(XmlProcessingInstructionSyntax))
        {
            XmlProcessingInstructionSyntax node_Syntax = node as XmlProcessingInstructionSyntax;
            desc = "XmlProcessingInstructionSyntax";
        }
        else if (nodeType == typeof(XmlTextAttributeSyntax))
        {
            XmlTextAttributeSyntax node_Syntax = node as XmlTextAttributeSyntax;
            desc = "XmlTextAttributeSyntax";
        }
        else if (nodeType == typeof(XmlTextSyntax))
        {
            XmlTextSyntax node_Syntax = node as XmlTextSyntax;
            desc = "XmlTextSyntax";
        }
        else if (nodeType == typeof(YieldStatementSyntax))
        {
            YieldStatementSyntax node_Syntax = node as YieldStatementSyntax;
            desc = "YieldStatementSyntax";
        }
        else
            desc = $"UnknowType: {node.GetType()}";

        #endregion

        desc = desc + $"({node.Span.Start}, {node.Span.End})";
        string code = node.ToString().Trim();
        code = code.Replace("\t", " ");
        code = code.Replace("\r", "");
        code = code.Replace("\n", "");
        code = code.Replace("  ", " ");
        code = code.Replace("  ", " ");
        int len = code.Length > 50 ? 50 : code.Length;
        return desc + "  // " + code.Substring(0, len);
    }
}