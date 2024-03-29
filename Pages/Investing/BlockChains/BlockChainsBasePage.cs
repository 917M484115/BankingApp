﻿using BankingApp.Pages.Common;
using BankingApp.Domain.Investing;
using BankingApp.Facade.Investing;
using BankingApp.Data.Investing;
using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using BankingApp.Domain.Investing.Repositories;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BankingApp.Pages.Investing
{
    public abstract class BlockChainsBasePage<TPage>:
        ViewPage<TPage,IBlockChainsRepository,BlockChain,BlockChainView,BlockChainData>
        where TPage:PageModel
    {
        protected BlockChainsBasePage(IBlockChainsRepository r) : base(r, "BlockChains") { }
        protected internal override Uri pageUrl() => new Uri("/Manager/BlockChains", UriKind.Relative);
        protected internal override BlockChain toObject(BlockChainView v) => new BlockChainViewFactory().Create(v);
        protected internal override BlockChainView toView(BlockChain o) => new BlockChainViewFactory().Create(o);
        protected override void createTableColumns()
        {
            createColumn(x => Item.Id);
            createColumn(x => Item.Name);
            
            
        }
        public override string GetName(IHtmlHelper<TPage> h, int i) => i switch
        {
            3 or 4 => getName<DateTime?>(h, i),
            _ => base.GetName(h, i)
        };
        public override IHtmlContent GetValue(IHtmlHelper<TPage> h, int i) => i switch
        {
            3 or 4 => getValue<DateTime?>(h, i),
            _ => base.GetValue(h, i)
        };
    }
}
